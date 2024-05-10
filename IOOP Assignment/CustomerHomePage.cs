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
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            query = $"SELECT FullName FROM Users WHERE UserID = (SELECT UserID FROM Customer WHERE CustomerID = '{customerID}');";
            string customerName = database.getString(query);
            lblWelcome.Text = $"Welcome,{customerName}";

            query = $"SELECT OrderID FROM Orders WHERE CustomerID = '{customerID}' AND OrderStatus = 'MAKING';";
            string orderID = database.getString(query);
            query = $"SELECT ReservationID FROM Reservation WHERE CustomerID = '{customerID}';";
            string reservationID = database.getString(query);
            if (orderID != null || orderID != "")
            {
                this.lblOrderID.Text = orderID;
                query = $"SELECT EstimatedTimeLeft FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                this.lblEstimatedTime.Text = $"{database.getInt(query).ToString()} Mins Left";
                query = $"SELECT OrderStatus FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                string orderStatus = database.getString(query);
                this.lblOrderStatus.Text = orderStatus;
            }
            else if(orderID == null || orderID == "") 
            {
                this.lblOrderID.Text = "N/A";
                this.lblEstimatedTime.Text = "N/A";
                this.lblOrderStatus.Text = "N/A";
            }

            if (reservationID != null || reservationID != "")
            {

                this.lblReservationID.Text = reservationID;
                query = $"SELECT PlaceID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
                string placeID = database.getString(query);
                this.lblPlaceID.Text = placeID;
                query = $"SELECT PlaceName FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                this.lblPlaceName.Text = database.getString(query);
                query = $"SELECT ReservationStatus FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                this.lblReservationStatus.Text = database.getString(query);
            }
            else if(reservationID == null || reservationID != "")
            {
                this.lblReservationID.Text = "N/A";
                this.lblReservationID.Text = "N/A";
                this.lblPlaceID.Text = "N/A";
                this.lblReservationStatus.Text = "N/A";
            }

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
            query = $"UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            database.insertOrUpdateValuesIntoDatabase(query);
            query = $"UPDATE Customer SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            database.insertOrUpdateValuesIntoDatabase(query);

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerProfilePage.Visible = true;
        }

        private void lblOrderNumber_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

