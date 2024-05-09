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

        public CustomerCartPage()
        {
            InitializeComponent();
            Database database = new Database(connectionString);
            string query = "SELECT OrderDetailsIDs FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderDetailsIDs = database.getString(query);

            if (orderDetailsIDs != null)
            {
                string[] orderDetailsIDArray = orderDetailsIDs.Split(',');

                foreach (string orderDetailsID in orderDetailsIDArray)
                {
                    query = $"SELECT Name, Price, Quantity, SpecialInstructions FROM OrderDetails WHERE OrderDetailsID = '{orderDetailsID}';";
                    DataTable cartDataTable = database.getDataTable(query);


                    int subtotalAmount = 0;
                    foreach (DataRow row in cartDataTable.Rows)
                    {
                        string productName = row["Name"].ToString();
                        string productPrice = row["Price"].ToString();
                        string productQuantity = row["Quantity"].ToString();
                        string productSpecialInstructions = row["SpecialInstructions"].ToString();
                        int productPriceSubtotal = Convert.ToInt32(row["Price"]);

                        subtotalAmount += productPriceSubtotal;
                        var cartProductButton = new cartProductButton(productName, productSpecialInstructions, productPrice, productQuantity);
                        cartProductShowFlowPnl.Controls.Add(cartProductButton);
                    }

                    lblSubtotalAmount.Text = subtotalAmount.ToString();
                    int taxAmount = subtotalAmount * (6 / 100);
                    lblTaxAmount.Text = taxAmount.ToString();
                    int totalAmount = subtotalAmount + taxAmount;
                    lblTotalAmount.Text = totalAmount.ToString();
                }
            }
            else
            {
                MessageBox.Show("The cart has no items");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void payBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = "SELECT OrderID FROM Orders WHERE OrderStatus = 'ORDERING';";
            string orderID = database.getString(query);
            query = $"UPDATE Order SET PaymentStatus = 'PAID' WHERE OrderID = '{orderID}';";
            database.insertOrUpdateValuesIntoDatabase(query);
            query = $"SELECT PaymentStatus FROM Orders WHERE OrderID = '{orderID}';";

            if (database.getString(query) == "PAID")
            {
                query = $"UPDATE Order SET OrderStatus = 'MAKING' WHERE OrderID = '{orderID}';";
                database.insertOrUpdateValuesIntoDatabase(query);
                this.Hide();
                CustomerSuccessfulPayment customerSuccessfulPayment = new CustomerSuccessfulPayment();
                customerSuccessfulPayment.Show();
            }
            else
            {
                MessageBox.Show("Order has not been paid. Please pay first");
            }
        }
    }
}
