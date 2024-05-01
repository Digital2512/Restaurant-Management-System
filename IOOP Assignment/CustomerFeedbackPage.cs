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
            }
            else 
            {
                MessageBox.Show("Feedback Not Sent! ");
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
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
            return (database.GenerateUniqueFeedbackID());
        }

        public bool sendFeedbackToDatabase()
        {
            Database database = new Database(connectionString);
            string uniqueFeedbackID = database.GenerateUniqueFeedbackID();
             string feedbackTopic = Topic;
            string feedbackTitle = Title;
            string feedbackDescription = Description;
            string query = $"INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackTopic, FeedbackTitle, FeedbackDescription) VALUES ('{uniqueFeedbackID}', '{CustomerID}', '{feedbackTopic}', '{feedbackTitle}', '{feedbackDescription}');";
            if (database.insertValuesIntoDatabase(query) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

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

        public int getInt(string Query)
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
                                result = reader.GetInt32(32);
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
        public string GenerateUniqueFeedbackID()
        {
            string newFeedbackID = null;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        string query = "SELECT MAX(CAST(SUBSTRING(FeedbackID, 3, LEN(FeedbackID) - 2) AS INT)) FROM Feedback WHERE FeedbackID LIKE 'FB%';";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int maxNumericPart = Convert.ToInt32(result);
                            maxNumericPart++;
                            newFeedbackID = "FB" + maxNumericPart.ToString("D2");
                        }
                        else
                        {
                            newFeedbackID = "FB001";
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
            return newFeedbackID;
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
                        return rowsAffected == 1; 
                    }
                    else
                    {
                        return false; 
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An Error Occurred: " + ex.Message);
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
}
