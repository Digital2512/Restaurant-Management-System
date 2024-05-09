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

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void headerPnl_Paint(object sender, PaintEventArgs e)
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
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
