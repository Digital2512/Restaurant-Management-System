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
        //change the connection string when using a different laptop to connect to the database
        public string ConnectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string customerID;
        public string reservationID;
        public string orderID;
        public string UserID;
        
        public CustomerHomePage(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            refreshReservationBtn.Visible = false;
            refreshOrderBtn.Visible = false;
            Database database = new Database(ConnectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE UserID = '{userID}';";
            customerID = database.getString(query);
            query = $"SELECT FullName FROM Users WHERE UserID = (SELECT UserID FROM Customer WHERE CustomerID = '{customerID}');";
            string customerName = database.getString(query);
            lblWelcome.Text = $"Welcome,{customerName}";

            query = $"SELECT OrderID FROM Orders WHERE CustomerID = '{customerID}' AND OrderStatus IN ('PENDING', 'IN_PROGRESS', 'COMPLETED')";
            this.orderID = database.getString(query);
            query = $"SELECT ReservationID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus IN ('PENDING', 'APPROVED', 'DEINED');";
            this.reservationID = database.getString(query);
            if (orderID != null || orderID != "")
            {
                query = $"SELECT EstimatedTimeLeft FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                string estimatedTimeString = $"{database.getInt(query).ToString()} Mins Left";
                query = $"SELECT OrderStatus FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                string orderStatus = database.getString(query);
                this.lblOrderStatus.Text = orderStatus;
                if (orderStatus == "IN_PROGRESS")
                {
                    this.lblOrderID.Text = orderID;
                    this.lblOrderStatus.Text = orderStatus;
                    this.lblEstimatedTime.Text = estimatedTimeString;
                    refreshOrderBtn.Visible = false;
                    orderStatusPBox.Image = Properties.Resources.inKitchenIcon;
                }
                else if (orderStatus == "COMPLETED")
                {
                    this.lblOrderID.Text = orderID;
                    this.lblOrderStatus.Text = orderStatus;
                    this.lblEstimatedTime.Text = "N/A";
                    refreshOrderBtn.Visible = true;
                    orderStatusPBox.Image = Properties.Resources.completedIcon;
                }
                else if (orderStatus == "PENDING")
                {
                    this.lblOrderID.Text = orderID;
                    this.lblOrderStatus.Text = orderStatus;
                    this.lblEstimatedTime.Text = "N/A";
                    refreshOrderBtn.Visible = false;
                    orderStatusPBox.Image = Properties.Resources.pendingIcon;
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
                query = $"SELECT PlaceID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationID = '{reservationID}';";
                string placeID = database.getString(query);
                query = $"SELECT ReservationStatus FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationID = '{reservationID}';";
                string reservationStatus = database.getString(query);
                query = $"SELECT PlaceName FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                string placeName = database.getString(query);
                query = $"SELECT Duration FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                int durationMinutes = database.getInt(query);

                    query = $"SELECT ReservedDate FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
                    DateTime? reservedDateTime = database.getDateTimeToProcess(query);

                    string reservedDate = reservedDateTime?.ToString("yyyy-MM-dd") ?? "N/A";

                    query = $"SELECT ReservedStartTime FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationID = '{reservationID}';";
                    int reservedStartTime = database.getInt(query);
                    query = $"SELECT ReservedEndTime FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationID = '{reservationID}';";
                    int reservedEndTime = database.getInt(query);
                    string startTimeFormatted = null;
                    string endTimeFormatted = null;

                    if (durationMinutes == 60)
                    {
                        startTimeFormatted = (reservedStartTime / 100) + ":" + (reservedStartTime % 100).ToString("00");
                        endTimeFormatted = (reservedEndTime / 100) + ":" + (reservedEndTime % 100).ToString("00");
                    }
                    else if (durationMinutes == 120)
                    {
                        startTimeFormatted = (reservedStartTime / 100) + ":" + (reservedStartTime % 100).ToString("00");
                        endTimeFormatted = (reservedEndTime / 100) + ":" + (reservedEndTime % 100).ToString("00");
                    }
                    else if (durationMinutes == 180)
                    {
                        startTimeFormatted = (reservedStartTime / 100) + ":" + (reservedStartTime % 100).ToString("00");
                        endTimeFormatted = (reservedEndTime / 100) + ":" + (reservedEndTime % 100).ToString("00");
                    }

                if (reservationStatus == "APPROVED")
                {
                    refreshReservationBtn.Visible = true;
                    startTimeFormatted = (reservedStartTime / 100) + ":" + (reservedStartTime % 100).ToString("00");
                    endTimeFormatted = (reservedEndTime / 100) + ":" + (reservedEndTime % 100).ToString("00");

                    this.lblReservationID.Text = $"{reservationID}";
                    this.lblPlaceName.Text = $"{placeName}";
                    this.lblDateTimeRange.Text = $"{reservedDate} {startTimeFormatted} - {endTimeFormatted}";
                    this.lblReservationStatus.Text = reservationStatus;
                    refreshReservationBtn.Visible = true;
                    reservationStatusPBox.Image = Properties.Resources.approvedIcon;
                }
                else if (reservationStatus == "DENIED")
                {
                    startTimeFormatted = (reservedStartTime / 100) + ":" + (reservedStartTime % 100).ToString("00");
                    endTimeFormatted = (reservedEndTime / 100) + ":" + (reservedEndTime % 100).ToString("00");

                    this.lblReservationID.Text = $"{reservationID}";
                    this.lblPlaceName.Text = $"{placeName}";
                    this.lblDateTimeRange.Text = $"{reservedDate} {startTimeFormatted} - {endTimeFormatted}";
                    this.lblReservationStatus.Text = reservationStatus;
                    reservationStatusPBox.Image = Properties.Resources.deniedIcon;
                    refreshReservationBtn.Visible = true;
                }
                else if (reservationStatus == "PENDING")
                {
                    startTimeFormatted = (reservedStartTime / 100) + ":" + (reservedStartTime % 100).ToString("00");
                    endTimeFormatted = (reservedEndTime / 100) + ":" + (reservedEndTime % 100).ToString("00");

                    this.lblReservationID.Text = $"{reservationID}";
                    this.lblPlaceName.Text = $"{placeName}";
                    this.lblDateTimeRange.Text = $"{reservedDate} {startTimeFormatted} - {endTimeFormatted}";
                    this.lblReservationStatus.Text = reservationStatus;
                    reservationStatusPBox.Image = Properties.Resources.pendingIcon;
                    refreshReservationBtn.Visible = false;
                }
                else
                {
                    refreshReservationBtn.Visible = false;
                    this.lblReservationID.Text = "N/A";
                    this.lblPlaceName.Text = "N/A";
                    this.lblDateTimeRange.Text = "N/A";
                    this.lblReservationStatus.Text = "N/A";
                    reservationStatusPBox.Image = Properties.Resources.errorImageSmaller;
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
                sidebarFlowLayoutPnl.Width -= 10;
                if (sidebarFlowLayoutPnl.Width <= 40)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    reservationPnl.Width = sidebarFlowLayoutPnl.Width;
                    orderPnl.Width = sidebarFlowLayoutPnl.Width;
                    feedbackPnl.Width = sidebarFlowLayoutPnl.Width;
                    logoutPnl.Width = sidebarFlowLayoutPnl.Width;
                    profilePnl.Width = sidebarFlowLayoutPnl.Width;
                }
            }
            else
            {
                sidebarFlowLayoutPnl.Width += 10;
                if (sidebarFlowLayoutPnl.Width >= 120)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    reservationPnl.Width = sidebarFlowLayoutPnl.Width;
                    orderPnl.Width = sidebarFlowLayoutPnl.Width;
                    feedbackPnl.Width = sidebarFlowLayoutPnl.Width;
                    logoutPnl.Width = sidebarFlowLayoutPnl.Width;
                    profilePnl.Width = sidebarFlowLayoutPnl.Width;
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
            CustomerReservationPage customerReservationPage = new CustomerReservationPage(UserID);
            customerReservationPage.Visible = true;
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomerOrderPage customerOrderPage = new CustomerOrderPage(UserID);
            customerOrderPage.Visible = true;
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CustomerFeedbackPage customerFeedbackPage = new CustomerFeedbackPage(UserID);
            customerFeedbackPage.Visible = true;
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            loginForm loginForm = new loginForm();
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
            CustomerProfilePage customerProfilePage = new CustomerProfilePage(UserID);
            customerProfilePage.Visible = true;
        }

        private void lblPlaceID_Click(object sender, EventArgs e)
        {

        }

        private void refreshReservationButton_Click(object sender, EventArgs e)
        {
            Database database = new Database(ConnectionString);
            string query = $"UPDATE Reservation SET ReservationStatus = 'COMPLETED' WHERE ReservationID = '{reservationID}';";
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                query = $"SELECT ReservationID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
                string updatedReservationID = database.getString(query);

                if (updatedReservationID != null || updatedReservationID != "")
                {
                    query = $"UPDATE Customer SET ReservationID = '{updatedReservationID}' WHERE CustomerID = '{customerID}';";
                    if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        refreshReservationBtn.Visible = false;
                        this.Close();
                        CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
                        customerHomePage.Show();
                    }
                    else if (database.insertOrUpdateValuesIntoDatabase(query) == false)
                    {
                        MessageBox.Show("Reservation ID Not Updated");
                    }
                }
                else
                {
                    query = $"UPDATE Customer SET ReservationID = NULL WHERE ReservationID = '{reservationID}' WHERE CustomerID = '{customerID}';";
                    if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        refreshReservationBtn.Visible = false;
                        this.Close();
                        CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
                        customerHomePage.Show();
                    }
                }
            } else if (database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Reservation Status Not Updated");
            }
            else
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void refreshOrderButton_Click(object sender, EventArgs e)
        {
            Database database = new Database(ConnectionString);
            string query = $"UPDATE Orders SET OrderStatus = 'COMPLETED_ORDER' WHERE OrderID = '{orderID}';";
            if(database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                query = $"SELECT OrderID FROM Orders WHERE CustomerID = '{customerID}' AND (OrderStatus = 'PENDING' OR OrderStatus = 'IN_PROGRESS');";
                string updatedOrderID = database.getString(query);

                if (updatedOrderID != null || updatedOrderID != "")
                {
                    query = $"UPDATE Customer SET OrderID = '{updatedOrderID}'  WHERE CustomerID = '{customerID}';";
                    if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        refreshReservationBtn.Visible = false;
                        this.Close();
                        CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
                        customerHomePage.Show();
                    }else if(database.insertOrUpdateValuesIntoDatabase(query) == false)
                    {
                        MessageBox.Show("Order ID Not Updated");
                    }
                }
                else
                {
                    query = $"UPDATE Customer SET OrderID = NULL  WHERE CustomerID = '{customerID}';";
                    if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        refreshReservationBtn.Visible = false;
                        this.Close();
                        CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
                        customerHomePage.Show();
                    }
                }
            }
            else if(database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Order Status Not Updated");
            }
            else
            {
                MessageBox.Show("An Error Occured");
            }
        }

        private void reservationStatusPBox_Click(object sender, EventArgs e)
        {

        }
    }
}

