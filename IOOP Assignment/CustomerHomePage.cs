using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class CustomerHomePage : Form
    {
        public string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        CustomerReservationPage customerReservationPage = new CustomerReservationPage();
        CustomerOrderPage customerOrderPage = new CustomerOrderPage();
        CustomerFeedbackPage customerFeedbackPage = new CustomerFeedbackPage();
        CustomerProfilePage customerProfilePage = new CustomerProfilePage();
        loginForm loginForm = new loginForm();
        public CustomerHomePage()
        {
            InitializeComponent();
            Database database = new Database(ConnectionString);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    reservationPnl.Width = sidebar.Width;
                    orderPnl.Width = sidebar.Width;
                    feedbackPnl.Width = sidebar.Width;
                    logoutPnl.Width = sidebar.Width;
                    profilePnl.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 120)
                {
                    sidebarExpand= true;
                    sidebarTransition.Stop();

                    reservationPnl.Width = sidebar.Width;
                    orderPnl.Width = sidebar.Width;
                    feedbackPnl.Width = sidebar.Width;
                    logoutPnl.Width = sidebar.Width;
                    profilePnl.Width = sidebar.Width;
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerReservationPage.Visible = true;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerOrderPage.Visible = true;
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerFeedbackPage.Visible = true;
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginForm.Visible = true;
            Database database = new Database(ConnectionString);
            string query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = database.getString(query);
            query = $"UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = {userID}";
            database.insertOrUpdateValuesIntoDatabase(query);
            query = $"UPDATE Customer SET LoggedIn = 'FALSE' WHERE UserID = {userID}";
            database.insertOrUpdateValuesIntoDatabase(query);

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerProfilePage.Visible = true;
        }
    }
}
