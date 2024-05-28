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

<<<<<<< HEAD

=======
>>>>>>> Huey-Shin
namespace IOOP_Assignment
{
<<<<<<< HEAD
    public class Database
=======
    public class Databases
>>>>>>> Huey-Shin
    {
        private string ConnectionString;

<<<<<<< HEAD
        public string connectionString { get => ConnectionString; set => ConnectionString = value; }

        private string Query;

        public string query { get => Query; set => Query = value; }

        public Database(string ConnectionString)
=======
        public Databases(string connectionString)
>>>>>>> Huey-Shin
        {
            this.ConnectionString = ConnectionString;
        }

        public string getString(string query)
        {
            string result = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
<<<<<<< HEAD
                try
=======
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
>>>>>>> Huey-Shin
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
                                        if(result == null)
                                        {
                                            result = "";
                                        }
                                    }
                                    else
                                    {
                                        result = "";
                                    }
                                    //result = reader.GetString(0);
                                }catch (SqlException ex)
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

        public List<string> getListOfStrings(string query)
        {
            List<string> result = new List<string>();
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
                                string stringExtracted = reader.GetString(0);
                                result.Add(stringExtracted);
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
        public DateTime getDateTime(string query)
        {
            DateTime result = DateTime.MinValue;

            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        public int getInt(string query)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
<<<<<<< HEAD

        public int getDecimal(string query)
        {
            int result = 0;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
                                decimal decimalValue = reader.GetDecimal(0);

                                result = Decimal.ToInt32(decimalValue);

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
        public int getRecipeStockInt(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
        /*
        public DataTable getDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }*/

        public DataTable getDataTable(string query)
        {
            var dataTable = new DataTable();
            using (var connection = new SqlConnection(ConnectionString))
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
        public string GenerateUniqueID(string uniqueIdentifier, string idName, string tableName)
        {
            string newID = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
                        MessageBox.Show(result.ToString());

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

        public bool insertOrUpdateValuesIntoDatabase(string query)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        connection.Close();
                        return rowsAffected == 1;
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

        public Image getImage(string query)
        {
            Image resultImage = Properties.Resources.errorImage;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand(query, connection);
                        object resultDB = cmd.ExecuteScalar();
                        if(resultDB != null && resultDB != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])cmd.ExecuteScalar();
                            if(imageBytes != null && imageBytes.Length > 0)
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
    public bool insertOrUpdateImageToFile(string imagePath, string query)
        {
            bool result = false;

            byte[] imageBytes = File.ReadAllBytes(imagePath);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ImageData", imageBytes);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if(rowsAffected > 0)
                        {
                            result = true; 
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }catch (SqlException ex) {
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
=======
>>>>>>> Huey-Shin
    }
}
              