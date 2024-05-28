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

            query = $"SELECT OrderID FROM Orders WHERE CustomerID = '{customerID}' AND OrderStatus = 'WAITING_FOR_CHEF';";
            string orderID = database.getTopString(query);
            query = $"SELECT ReservationID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
            string reservationID = database.getTopString(query);
            if (orderID != null || orderID != "")
            {
                query = $"SELECT EstimatedTimeLeft FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                string estimatedTimeString = $"{database.getInt(query).ToString()} Mins Left";
                query = $"SELECT OrderStatus FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                string orderStatus = database.getString(query);
                MessageBox.Show(orderStatus);
                this.lblOrderStatus.Text = orderStatus;
                if (orderStatus == "IN_PROGRESS")
                {
                    this.lblOrderID.Text = orderID;
                    this.lblOrderStatus.Text = orderStatus;
                    this.lblEstimatedTime.Text = estimatedTimeString;
                    //orderStatusPBox.Image = Properties.Resources.inKitchenResized;
                }
                else if (orderStatus == "COMPLETED")
                {
                    this.lblOrderID.Text = orderID;
                    this.lblOrderStatus.Text = orderStatus;
                    this.lblEstimatedTime.Text = "N/A";
                    //orderStatusPBox.Image = Properties.Resources.completedResized;
                }
                else if (orderStatus == "WAITING_FOR_CHEF")
                {
                    this.lblOrderID.Text = orderID;
                    this.lblOrderStatus.Text = orderStatus;
                    this.lblEstimatedTime.Text = "N/A";
                    //orderStatusPBox.Image = Properties.Resources.completedResized;
                }
                else
                {
                    this.lblOrderID.Text = "N/A";
                    this.lblEstimatedTime.Text = "N/A";
                    this.lblOrderStatus.Text = "N/A";
                    orderStatusPBox.Image = Properties.Resources.errorImageSmaller;
                }
            }

            if (reservationID != null || reservationID != "")
            {
                this.lblReservationID.Text = reservationID;
                query = $"SELECT PlaceID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
                string placeID = database.getString(query);
                query = $"SELECT ReservationStatus FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                string reservationStatus = database.getString(query);
                query = $"SELECT PlaceName FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                string placeName = database.getString(query);
                query = $"SELECT Duration FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                int durationMinutes = database.getInt(query);
                if (!string.IsNullOrEmpty(reservationID))
                {
                    query = $"SELECT ReservedDateTime FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
                    DateTime? reservedDateTime = database.getDateTimeToProcess(query);

                    string reservedDate = reservedDateTime?.ToString("yyyy-MM-dd") ?? "N/A";
                    string reservedTime = reservedDateTime?.ToString("HH:mm:ss") ?? "N/A";

                    // Calculate end time by adding duration to reserved date and time
                    DateTime? endDateTime = reservedDateTime?.AddMinutes(durationMinutes);
                    string endDate = endDateTime?.ToString("yyyy-MM-dd") ?? "N/A";
                    string endTime = endDateTime?.ToString("HH:mm:ss") ?? "N/A";

                    // Display reservation details based on status
                    if (reservationStatus == "IN_PROGRESS")
                    {
                        this.lblReservationID.Text = $"{reservationID}";
                        this.lblPlaceName.Text = $"{placeName}";
                        this.lblDateTimeRange.Text = $"{reservedDate} {reservedTime} - {endDate} {endTime}";
                        this.lblReservationStatus.Text = reservationStatus;
                        //reservationStatusPBox.Image = Properties.Resources.inKitchenResized;
                    }
                    else if (reservationStatus == "APPROVED")
                    {
                        this.lblReservationID.Text = $"{reservationID}";
                        this.lblPlaceName.Text = $"{placeName}";
                        this.lblDateTimeRange.Text = $"{reservedDate} {reservedTime} - {endDate} {endTime}";
                        this.lblReservationStatus.Text = reservationStatus;
                        //reservationStatusPBox.Image = Properties.Resources.approvedResized;
                    }
                    else if (reservationStatus == "DENIED")
                    {
                        this.lblReservationID.Text = $"{reservationID}";
                        this.lblPlaceName.Text = $"{placeName}";
                        this.lblDateTimeRange.Text = $"{reservedDate} {reservedTime} - {endDate} {endTime}";
                        this.lblReservationStatus.Text = reservationStatus;
                        //reservationStatusPBox.Image = Properties.Resources.deniedResized;
                    }
                    else if (reservationStatus == "PENDING")
                    {

                        this.lblReservationID.Text = $"{reservationID}";
                        this.lblPlaceName.Text = $"{placeName}";
                        this.lblDateTimeRange.Text = $"{reservedDate} {reservedTime} - {endDate} {endTime}";
                        this.lblReservationStatus.Text = reservationStatus;
                        //reservationStatusPBox.Image = Properties.Resources.pendingResized;
                    }
                    else
                    {
                        this.lblReservationID.Text = "N/A";
                        this.lblPlaceName.Text = "N/A";
                        this.lblDateTimeRange.Text = "N/A";
                        this.lblReservationStatus.Text = "N/A";
                        reservationStatusPBox.Image = Properties.Resources.errorImageSmaller;
                    }
                }
            }

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
                if (sidebar.Width >= 120)
                {
                    sidebarExpand = true;
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

        private void lblPlaceID_Click(object sender, EventArgs e)
        {

        }
    }
}

