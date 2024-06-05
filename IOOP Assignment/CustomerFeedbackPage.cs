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
            Database database;
            database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);

            string feedbackTopicChosen = topicCBox.Text;
            string feedbackTitle = titleTxtBox.Text;
            string feedbackDescription = descriptionRBox.Text;
            lblCustomerID.Text = customerID.ToString();

            string uniqueFeedbackID = database.GenerateUniqueID("FB", "FeedbackID", "Feedback");
            query = $"INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackTopic, FeedbackTitle, FeedbackDescription) VALUES ('{uniqueFeedbackID}', '{customerID}', '{feedbackTopicChosen}', '{feedbackTitle}', '{feedbackDescription}');";
            if(database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                MessageBox.Show("Feedback Sent! ");
                this.Hide();
                CustomerHomePage customerHomePage = new CustomerHomePage();
                customerHomePage.Show();
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
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage();
            customerHomePage.Show();
        }
    }
}
