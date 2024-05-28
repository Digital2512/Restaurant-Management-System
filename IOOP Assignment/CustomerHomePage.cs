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
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> Huey-Shin
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
<<<<<<< HEAD
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
                MessageBox.Show($"Order ID Found : {orderID}");
                this.lblOrderID.Text = orderID;
                query = $"SELECT EstimatedTimeLeft FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                this.lblEstimatedTime.Text = $"{database.getInt(query).ToString()} Mins Left";
                query = $"SELECT OrderStatus FROM Orders WHERE CustomerID = '{customerID}' AND OrderID = '{orderID}';";
                string orderStatus = database.getString(query);
                this.lblOrderStatus.Text = orderStatus;
                if(orderStatus == "IN_PROGRESS")
                {
                    //orderStatusPBox.Image = Properties.Resources.inKitchenResized;
                }else if(orderStatus == "COMPLETED")
                {
                    //orderStatusPBox.Image = Properties.Resources.completedResized;
                }
                else
                {
                    orderStatusPBox.Image = Properties.Resources.errorImageSmaller;
                }
            }
            else if(orderID == null|| orderID == "" || orderID == " ")
            {
                this.lblOrderID.Text = "N/A";
                this.lblEstimatedTime.Text = "N/A";
                this.lblOrderStatus.Text = "N/A";
            }

            if (reservationID != null || reservationID != "")
            {
                MessageBox.Show($"Reservation ID Found : {reservationID}");
                this.lblReservationID.Text = reservationID;
                query = $"SELECT PlaceID FROM Reservation WHERE CustomerID = '{customerID}' AND ReservationStatus = 'PENDING';";
                string placeID = database.getString(query);
                this.lblPlaceID.Text = placeID;
                query = $"SELECT PlaceName FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                this.lblPlaceName.Text = database.getString(query);
                query = $"SELECT ReservationStatus FROM Reservation WHERE CustomerID = '{customerID}' AND PlaceID = '{placeID}';";
                string reservationStatus = database.getString(query);
                this.lblReservationStatus.Text = reservationStatus;
                if (reservationStatus == "IN_PROGRESS")
                {
                    //reservationStatusPBox.Image = Properties.Resources.inKitchenResized;
                }
                else if (reservationStatus == "APPROVED")
                {
                    //reservationStatusPBox.Image = Properties.Resources.approvedResized;
                }else if(reservationStatus == "DENIED")
                {
                    //reservationStatusPBox.Image = Properties.Resources.deniedResized;
                }
                else
                {
                    reservationStatusPBox.Image = Properties.Resources.errorImageSmaller;
                }
            }
            else if(reservationID == null || reservationID == "" || reservationID == " ")
            {
                this.lblReservationID.Text = "N/A";
                this.lblReservationID.Text = "N/A";
                this.lblPlaceID.Text = "N/A";
                this.lblReservationStatus.Text = "N/A";
            }
=======
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
>>>>>>> Huey-Shin

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

<<<<<<< HEAD
=======
        private void label10_Click(object sender, EventArgs e)
        {

        }

>>>>>>> Huey-Shin
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
<<<<<<< HEAD
            query = $"UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            database.insertOrUpdateValuesIntoDatabase(query);
            query = $"UPDATE Customer SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            database.insertOrUpdateValuesIntoDatabase(query);
=======
            query = $"UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = {userID}";
            database.insertValuesIntoDatabase(query);
            query = $"UPDATE Customer SET LoggedIn = 'FALSE' WHERE UserID = {userID}";
            database.insertValuesIntoDatabase(query);
>>>>>>> Huey-Shin

        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            customerProfilePage.Visible = true;
        }
    }
}

=======
<<<<<<<< HEAD:IOOP Assignment/CustomerCartPage.cs
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private decimal subtotalAmount;
        public decimal getSetSubtotalAmount { get { return subtotalAmount; } set { subtotalAmount = value; } }

        private decimal taxAmount;
        public decimal getSetTaxAmount { get { return taxAmount; } set { taxAmount = value; } }

        private decimal totalAmount;
        public decimal getSetTotalAmount { get { return totalAmount; } set { totalAmount = value; } }

        public CustomerCartPage()
========
        public CustomerHomePage()
>>>>>>>> Huey-Shin:IOOP Assignment/CustomerHomePage.cs
        {
            InitializeComponent();
            loadCartDetails();
        }
        private void payBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = "SELECT OrderID FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderID = database.getString(query);
            query = $"UPDATE Orders SET PaymentStatus = 'PAID' WHERE OrderID = '{orderID}';";
            database.insertOrUpdateValuesIntoDatabase(query);
            query = $"SELECT PaymentStatus FROM Orders WHERE OrderID = '{orderID}';";

            if (database.getString(query) == "PAID")
            {
                query = $"UPDATE Orders SET OrderStatus = 'MAKING' WHERE OrderID = '{orderID}';";
                database.insertOrUpdateValuesIntoDatabase(query);
                query = $"UPDATE Orders SET OrderStatus = 'IN_PROGRESS' WHERE OrderID = '{orderID}';";
                database.insertOrUpdateValuesIntoDatabase(query);
                query = $"SELECT OrderDetailsIDs FROM Orders where OrderID = '{orderID}';";
                List<String> orderDetailsIDsList = new List<String>(database.getString(query).Split(','));
                MessageBox.Show(orderDetailsIDsList.ToString());
                foreach (string orderIDInOrderIDsList in orderDetailsIDsList)
                {
                    if (orderIDInOrderIDsList == null || orderIDInOrderIDsList == "")
                    {
                        continue;
                    }
                    else
                    {
                        query = $"SELECT ProductID FROM OrderDetails WHERE OrderDetailsID = '{orderIDInOrderIDsList}';";
                        string productID = database.getString(query);
                        query = $"SELECT Name FROM OrderDetails WHERE OrderDetailsID = '{orderIDInOrderIDsList}';";
                        string productName = database.getString(query);
                        query = $"SELECT Quantity FROM OrderDetails WHERE OrderDetailsID = '{orderIDInOrderIDsList}';";
                        int productQuantity = database.getInt(query);
                        query = $"SELECT Price FROM OrderDetails WHERE OrderDetailsID = '{orderIDInOrderIDsList}';";
                        decimal productPrice = database.getDecimal(query);
                        decimal totalPrice = productPrice * productQuantity;
                        query = $"SELECT ReportID FROM SalesReport WHERE ReportStatus = 'IN_PROGRESS' AND ProductID = '{productID}';";
                        string reportID = database.getString(query);
                        if (reportID != null)
                        {
                            string reportDetailsID = database.GenerateUniqueID("RD", "ReportDetailsID", "ReportDetails");
                            query = $"INSERT INTO ReportDetails(ReportDetailsID, ProductID, Name, Quantity, IndividualPrice, TotalPrice, ReportID) VALUES ('{reportDetailsID}', '{productID}', '{productName}', '{productQuantity}', '{productPrice}', '{totalPrice}', '{reportID}');";
                            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                            {
                                MessageBox.Show("Added to Sales Report");
                            }
                            else
                            {
                                MessageBox.Show("Not added to Sales Report");
                            }
                        }
                        else
                        {
                            reportID = database.GenerateUniqueID("R", "ReportID", "SalesReport");
                            MessageBox.Show(reportID);
                            DateTime currentDateTime = DateTime.Now;
                            int currentMonth = currentDateTime.Month;
                            string currentMonthString = "";
                            switch (currentMonth)
                            {
                                case 1:
                                    currentMonthString = "JANUARY";
                                    break;
                                case 2:
                                    currentMonthString = "FEBRUARY";
                                    break;
                                case 3:
                                    currentMonthString = "MARCH";
                                    break;
                                case 4:
                                    currentMonthString = "APRIL";
                                    break;
                                case 5:
                                    currentMonthString = "MAY";
                                    break;
                                case 6:
                                    currentMonthString = "JUNE";
                                    break;
                                case 7:
                                    currentMonthString = "JULY";
                                    break;
                                case 8:
                                    currentMonthString = "AUGUST";
                                    break;
                                case 9:
                                    currentMonthString = "SEPTEMBER";
                                    break;
                                case 10:
                                    currentMonthString = "OCTOBER";
                                    break;
                                case 11:
                                    currentMonthString = "NOVEMBER";
                                    break;
                                case 12:
                                    currentMonthString = "DECEMBER";
                                    break;
                            }
                            int currentYear = currentDateTime.Year;
                            string currentDateTimeString = currentDateTime.ToString();
                            DateTime dateTime = DateTime.ParseExact(currentDateTimeString, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                            string formattedDateTimeString = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                            MessageBox.Show(formattedDateTimeString);
                            query = $"INSERT INTO SalesReport(ReportID, ReportDateTime, Month, Year, ProductID, ReportStatus) VALUES ('{reportID}', '{formattedDateTimeString}', '{currentMonthString}', '{currentYear}', '{productID}', 'IN_PROGRESS')";
                            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                            {
                                MessageBox.Show("Sales Report Created");
                            }
                            else
                            {
                                MessageBox.Show("Sales Report not Created");
                            }
                            string reportDetailsID = database.GenerateUniqueID("RD", "ReportDetailsID", "ReportDetails");
                            MessageBox.Show(reportDetailsID);
                            query = $"INSERT INTO ReportDetails(ReportDetailsID, ProductID, Name, Quantity, IndividualPrice, TotalPrice, ReportID) VALUES ('{reportDetailsID}', '{productID}', '{productName}', '{productQuantity}', '{productPrice}', '{totalPrice}', '{reportID}');";
                            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                            {
                                MessageBox.Show("Added to Sales Report");
                            }
                            else
                            {
                                MessageBox.Show("Not added to Sales Report");
                            }
                        }
                    }
                }
                this.Hide();
                CustomerSuccessfulPayment customerSuccessfulPayment = new CustomerSuccessfulPayment();
                customerSuccessfulPayment.Show();
            }
            else
            {
                MessageBox.Show("Order has not been paid. Please pay first");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOrderPage customerOrderPage = new CustomerOrderPage();
            customerOrderPage.Show();
        }

        private void loadCartDetails()
        {
            Database database = new Database(connectionString);
            string query = "SELECT OrderDetailsIDs FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderDetailsIDs = database.getString(query);

            if (!string.IsNullOrEmpty(orderDetailsIDs))
            {
                string[] orderDetailsIDArray = orderDetailsIDs.Split(',');
                decimal subtotalAmount = 0;

                foreach (string orderDetailsID in orderDetailsIDArray)
                {
                    query = $"SELECT ProductID, Name, Price, Quantity, SpecialInstructions FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}';";
                    DataTable cartDataTable = database.getDataTable(query);

                    foreach (DataRow row in cartDataTable.Rows)
                    {
                        string productID = row["ProductID"].ToString();
                        string productName = row["Name"].ToString();
                        string productPrice = row["Price"].ToString();
                        string productQuantity = row["Quantity"].ToString();
                        string productSpecialInstructions = row["SpecialInstructions"].ToString();

                        decimal intProductPrice = Convert.ToDecimal(productPrice);
                        int intProductQuantity = Convert.ToInt32(productQuantity);

                        decimal productSubtotalAmount = intProductPrice * intProductQuantity;
                        subtotalAmount += productSubtotalAmount;

                        query = $"SELECT ProductImage FROM Menu WHERE ProductID = '{productID}';";
                        Image productImage = database.getImage(query);

                        var cartProductButton = new cartProductButton(productName, productSpecialInstructions, productPrice, productQuantity, productImage, orderDetailsID);
                        cartProductShowFlowPnl.Controls.Add(cartProductButton);
                    }
                }
                lblSubtotalAmount.Text = subtotalAmount.ToString();

                decimal taxAmount = subtotalAmount * 0.06m;
                lblTaxAmount.Text = taxAmount.ToString();
                decimal totalAmount = subtotalAmount + taxAmount;
                lblTotalAmount.Text = totalAmount.ToString();

                getSetSubtotalAmount = subtotalAmount;
                getSetTaxAmount = taxAmount;
                getSetTotalAmount = totalAmount;
            }
            else
            {
                MessageBox.Show("The cart has no items");
            }
        }
    }
}
>>>>>>> Huey-Shin
