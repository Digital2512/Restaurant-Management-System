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
        private void payBtn_Click(object sender, EventArgs e)
        {
            if(placeIDCBox.Text != "")
            {
                Database database = new Database(connectionString);
                string query = "SELECT OrderID FROM Orders WHERE OrderStatus = 'ORDERING';";
                string orderID = database.getString(query);
                query = $"UPDATE Orders SET PaymentStatus = 'PAID' WHERE OrderID = '{orderID}';";
                database.insertOrUpdateValuesIntoDatabase(query);
                string placeNumber = placeIDCBox.Text;
                query = $"UPDATE Orders SET PlaceNumber = '{placeNumber}' WHERE OrderID = '{orderID}';";
                database.insertOrUpdateValuesIntoDatabase(query);
                query = $"SELECT PaymentStatus FROM Orders WHERE OrderID = '{orderID}';";

                if (database.getString(query) == "PAID")
                {
                    query = $"UPDATE Orders SET OrderStatus = 'PENDING' WHERE OrderID = '{orderID}';";
                    if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        this.Hide();
                        CustomerSuccessfulPayment customerSuccessfulPayment = new CustomerSuccessfulPayment();
                        customerSuccessfulPayment.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Order has not been paid. Please pay first");
                }
            }
            else
            {
                MessageBox.Show("Please select a Place ID");
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
                    query = $"SELECT ProductID, Name, Price, Quantity, OrderSpecialInstructions FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}';";
                    DataTable cartDataTable = database.getDataTable(query);

                    foreach (DataRow row in cartDataTable.Rows)
                    {
                        string productID = row["ProductID"].ToString();
                        string productName = row["Name"].ToString();
                        MessageBox.Show(productName);
                        string productPrice = row["Price"].ToString();
                        string productQuantity = row["Quantity"].ToString();
                        string productSpecialInstructions = row["OrderSpecialInstructions"].ToString();

                        decimal intProductPrice = Convert.ToDecimal(productPrice);
                        int intProductQuantity = Convert.ToInt32(productQuantity);

                        decimal productSubtotalAmount = intProductPrice * intProductQuantity;
                        subtotalAmount += productSubtotalAmount;

                        query = $"SELECT ProductImage FROM Menu WHERE ProductID = '{productID}';";
                        Image productImage = database.getImage(query);

                        var cartProductButton = new cartProductButton(productID, productName, productSpecialInstructions, productPrice, productQuantity, productImage, orderDetailsID);
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
