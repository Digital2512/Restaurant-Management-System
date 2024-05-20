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
    public partial class CustomerCartPage : Form
    {
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private decimal subtotalAmount;
        public decimal getSetSubtotalAmount { get { return subtotalAmount; } set { subtotalAmount = value; } }

        private decimal taxAmount;
        public decimal getSetTaxAmount { get { return taxAmount; } set { taxAmount = value; } }

        private decimal totalAmount;
        public decimal getSetTotalAmount { get { return totalAmount; } set { totalAmount = value; } }

        public CustomerCartPage()
        {
            InitializeComponent();
            loadCartDetails();
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
