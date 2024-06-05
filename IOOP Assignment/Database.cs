using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;


namespace IOOP_Assignment
{
    public class Database
    {
        private string ConnectionString;

        public string connectionStringGetSet { get => ConnectionString; set => ConnectionString = value; }


        //main constructor (you would need to create an object first and define it with a connection string first to use the methods)
        public Database(string ConnectionString)
        {
            this.connectionStringGetSet = ConnectionString;
        }


        //get the first row's string from the database
        public string getString(string query)
        {
            string result = null;
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        result = reader.GetString(0);
                                        if (result == null)
                                        {
                                            result = "";
                                        }
                                    }
                                    else
                                    {
                                        result = "";
                                    }
                                    //result = reader.GetString(0);
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                connection.Close();
                                break;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                    connection.Close();
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

        // get date time from the database
        public DateTime getDateTime(string query)
        {
            DateTime result = DateTime.MinValue;

            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        object scalarResult = cmd.ExecuteScalar();

                        if (scalarResult != null && scalarResult != DBNull.Value && scalarResult is DateTime)
                        {
                            result = (DateTime)scalarResult;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }

            return result;
        }


        // get date time, with a boolean value attached to it which would identify if the date time is null or not, from the database 
        public DateTime? getDateTimeToProcess(string query)
        {
            DateTime? result = null;
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                try
                                {
                                    if (!reader.IsDBNull(0))
                                    {
                                        result = reader.GetDateTime(0);
                                    }
                                }
                                catch (SqlException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

        // get integer from database
        public int getInt(string query)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                result = reader.GetInt32(0);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

        //get decimal, from database, which would be converted to an integer
        public float getDecimal(string query)
        {
            float result = 0.00f;  
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                decimal dbValue = reader.GetDecimal(0); 
                                result = (float)dbValue; 
                                break;
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

        //get data table from the database
        public DataTable getDataTable(string query)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message); ;
                }
            }
            return dataTable;
        }
        //generate a Unique ID, by checking the database first to identify if this ID exist or not and
        //if not, it will return the ID,
        //but if yes then it add a number increment to it,
        //but if the very first ID is not detected at all then it will return the very first ID of that table
        public string GenerateUniqueID(string uniqueIdentifier, string idName, string tableName)
        {
            string newID = null;
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        string query = $"SELECT MAX({idName}) FROM {tableName} WHERE {idName} LIKE @uniqueIdentifier + '%';";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@uniqueIdentifier", uniqueIdentifier);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            string maxID = result.ToString();
                            int numericPart;
                            if (int.TryParse(maxID.Substring(uniqueIdentifier.Length), out numericPart))
                            {
                                numericPart++;
                                newID = $"{uniqueIdentifier}{numericPart:D3}";
                            }
                            else
                            {
                                throw new Exception("Unable to parse numeric part of ID");
                            }
                        }
                        else
                        {
                            newID = $"{uniqueIdentifier}001";
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return newID;
        }


        // insert or update into the database or delete values from the database
        public bool insertOrUpdateValuesIntoDatabase(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();
                        return rowsAffected >= 1;
                    }
                    else
                    {
                        connection.Close();
                        return false;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                    connection.Close();
                    return false;
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
        }

        //get image from the database, which would be converted from an image byte string
        public Image getImage(string query)
        {
            Image resultImage = Properties.Resources.errorImage;
            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        object resultDB = cmd.ExecuteScalar();
                        if (resultDB != null && resultDB != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])cmd.ExecuteScalar();
                            if (imageBytes != null && imageBytes.Length > 0)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    resultImage = Image.FromStream(ms);
                                }
                            }
                        }
                        else
                        {
                            resultImage = Properties.Resources.errorImage;
                        }
                    }
                    else
                    {
                        connection.Close();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                    connection.Close();
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return resultImage;
        }

        //insert image into database, which is converted from a defined image path, which is a string of image bytes
        public bool insertOrUpdateImageToFile(string imagePath, string query)
        {
            bool result = false;

            byte[] imageBytes = File.ReadAllBytes(imagePath);

            using (SqlConnection connection = new SqlConnection(connectionStringGetSet))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ImageData", imageBytes);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message);
                }
                finally
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
                return result;
            }
        }
    }
}
