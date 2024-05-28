using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class CustomerFeedbackPage : Form
    {
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerFeedbackPage()
        {
            InitializeComponent();
            Database database;
            database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            lblCustomerID.Text = customerID.ToString();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Feedback feedback;
            Database database;
            database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);

            string feedbackTopicChosen = topicCBox.Text;
            string feedbackTitle = titleTxtBoc.Text;
            string feedbackDescription = descriptionRBox.Text;

            lblCustomerID.Text = customerID.ToString();

            feedback = new Feedback(customerID, feedbackTopicChosen, feedbackTitle, feedbackDescription);
            if(feedback.sendFeedbackToDatabase() == true)
            {
                MessageBox.Show("Feedback Sent! ");
<<<<<<< HEAD
                this.Hide();
                CustomerHomePage customerHomePage = new CustomerHomePage();
                customerHomePage.Show();
=======
>>>>>>> Huey-Shin
            }
            else 
            {
                MessageBox.Show("Feedback Not Sent! ");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
<<<<<<< HEAD

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage();
            customerHomePage.Show();
        }
=======
>>>>>>> Huey-Shin
    }


    public class Feedback
    {
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private string CustomerID { get; }
        private string Topic { get; }
        private string Title { get; }
        private string Description { get; }

        public Feedback(string CustomerID, string Topic, string Title, string Description)
        {
            this.CustomerID = CustomerID;
            this.Topic = Topic;
            this.Title = Title;
            this.Description = Description;
        }

        public string produceFeedbackID()
        {
            Database database = new Database(connectionString);
            return (database.GenerateUniqueID("FB", "FeedbackID", "Feedback"));
        }

        public bool sendFeedbackToDatabase()
        {
            Database database = new Database(connectionString);
            string uniqueFeedbackID = database.GenerateUniqueID("FB", "FeedbackID", "Feedback");
             string feedbackTopic = Topic;
            string feedbackTitle = Title;
            string feedbackDescription = Description;
            string query = $"INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackTopic, FeedbackTitle, FeedbackDescription) VALUES ('{uniqueFeedbackID}', '{CustomerID}', '{feedbackTopic}', '{feedbackTitle}', '{feedbackDescription}');";
<<<<<<< HEAD
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
=======
            if (database.insertValuesIntoDatabase(query) == true)
>>>>>>> Huey-Shin
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
<<<<<<< HEAD
=======

    public class Database
    {
        private string ConnectionString;

        public string connectionString { get => ConnectionString; set => ConnectionString = value; }

        private string Query;

        public string query { get => Query; set => Query = value; }

        public Database(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public string getString(string query)
        {
            string result = null;
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
                                result = reader.GetString(0);
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
        }
        /*
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
                        string query = $"SELECT MAX(CAST(SUBSTRING(@idName, 3, LEN(@idName) - 2) AS INT)) FROM {tableName} WHERE @idName LIKE @uniqueIdentifier + '%';";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@idName", idName);
                        cmd.Parameters.AddWithValue("@uniqueIdentifier", uniqueIdentifier);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int maxNumericPart = Convert.ToInt32(result);
                            maxNumericPart++;
                            newID = $"{uniqueIdentifier}" + maxNumericPart.ToString("D2");
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
        */
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

        public bool insertValuesIntoDatabase(string query)
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
    }
>>>>>>> Huey-Shin
}
