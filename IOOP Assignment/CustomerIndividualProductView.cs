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
    public partial class CustomerIndividualProductView : Form
    {
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerIndividualProductView()
        {
            InitializeComponent();
            Database database = new Database(connectionString);
            string query = "SELECT ProductID FROM Menu WHERE Chosen = 'TRUE';";
            string productID = database.getString(query);
            query = "SELECT Name FROM Menu WHERE Chosen = 'TRUE';";
            string productName = database.getString(query);
            query = "SELECT Price FROM Menu WHERE Chosen = 'TRUE';";
            int productPrice = database.getInt(query);
            query = "SELECT Description FROM Menu WHERE Chosen = 'TRUE';";
            string productDescription = database.getString(query);
            query = "SELECT ImageDescription FROM Menu WHERE Chosen = 'TRUE';";
            string productImageDescription = database.getString(query);
            Image productImage = null;
            if (productImageDescription != null)
            {
                switch (productImageDescription) {
                    case "Burgers":
                        productImage = Properties.Resources.burgerImage;
                        break;
                    case "Pizza":
                        productImage = Properties.Resources.pizzaImage;
                        break;
                    case "Pasta":
                        productImage = Properties.Resources.pastaImage;
                        break;
                    case "Salad":
                        productImage = Properties.Resources.saladImage;
                        break;
                    case "Smoothie":
                        productImage = Properties.Resources.smoothieImage;
                        break;
                }
            }
            this.productImagePBox.Image = productImage;
            this.lblProductID.Text = productID;
            this.lblProductName.Text = productName;
            this.lblProductPrice.Text = $"RM {productPrice}";
            this.lblProductDescription.Text = productDescription;
            this.lblProductQuantity.Text = "1";
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = "SELECT ProductID FROM Menu WHERE Chosen = 'TRUE';";
            string productID = database.getString(query);
            query = "SELECT Price FROM Menu WHERE Chosen = 'TRUE';";
            int productPrice = database.getInt(query);
            int productQuantity = int.Parse(this.lblProductQuantity.Text);
            string productSpecialInstructions = this.specialInstructionsRTxtBox.Text;
            query = "SELECT OrderID FROM Orders WHERE OrderStatus = 'ORDERING'";
            string previousOrderID = database.getString(query);

            string orderID;
            if (previousOrderID == null || previousOrderID == "")
            {
                orderID = database.GenerateUniqueID("ORDER", "OrderID", "Orders");
                DateTime now = DateTime.Now;
                string orderDateTimeMade = now.ToString();
                query = "SELECT CustomerID FROM Customer WHERE LoggedIn= 'TRUE';";
                string customerID = database.getString(query);
                query = $"INSERT INTO Orders(OrderID, OrderDateTime, CustomerID, OrderStatus) VALUES ('{orderID}', '{orderDateTimeMade}', '{customerID}', 'ORDERING');";
                if (database.insertValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Order Created");
                }
                else if (database.insertValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Order Not Created");
                }
            }
            else
            {
                orderID = previousOrderID;
            }
            string orderDetailsID = database.GenerateUniqueID("OD", "OrderDetailsID", "OrderDetails");
            query = $"INSERT INTO OrderDetails(OrderID, OrderDetailsID, ProductID, Quantity, Price, specialInstructions) VALUES ('{orderID}', '{orderDetailsID}', '{productID}', '{productQuantity}', '{productPrice}', '{productSpecialInstructions}')";
            bool orderDetailsRecorded = database.insertValuesIntoDatabase(query);
            query = $"SELECT OrderDetailsID FROM Orders WHERE OrderStatus = 'ORDERING';";
            string previousOrderDetailsIDs = database.getString(query);
            string renewedOrderDetailsIDs = null;
            if(renewedOrderDetailsIDs == "")
            {
                renewedOrderDetailsIDs = $"{previousOrderDetailsIDs}{orderDetailsID},";
            }else  if(renewedOrderDetailsIDs != "")
            {
                renewedOrderDetailsIDs = $"{previousOrderDetailsIDs}, {orderDetailsID}";
            }
            query = $"UPDATE Orders SET OrderDetailsID = '{renewedOrderDetailsIDs}' WHERE OrderStatus = 'ORDERING'";
            bool orderDetailsRecordedWithOrder = database.insertValuesIntoDatabase(query);
            if (orderDetailsRecorded && orderDetailsRecordedWithOrder == true)
            {
                MessageBox.Show("Order Details Successfully Added To Cart");
            }
            else if(orderDetailsRecorded && orderDetailsRecordedWithOrder != true)
            {
                MessageBox.Show("Order Details Not Added To Cart");
            }
            query = $"UPDATE Menu SET Chosen = 'FALSE' WHERE ProductID = '{productID}'";
            if (database.insertValuesIntoDatabase(query) == true)
            {
                CustomerIndividualProductView customerIndividualProductView = new CustomerIndividualProductView();
                customerIndividualProductView.Hide();
                customerIndividualProductView.Visible = false;
                CustomerOrderPage customerOrderPage = new CustomerOrderPage();
                customerOrderPage.Show();
            }else if(database.insertValuesIntoDatabase(query) == true)
            {
                MessageBox.Show("Order Details Reset Failed");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int productQuantity = int.Parse(this.lblProductQuantity.Text);
            int newProductQuantity = productQuantity + 1;
            this.lblProductQuantity.Text = newProductQuantity.ToString();
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            int productQuantity = int.Parse(this.lblProductQuantity.Text);
            if (productQuantity <= 1)
            {
                minusBtn.Enabled = false;
            }
            else
            {
                int newProductQuantity = productQuantity - 1;
                this.lblProductQuantity.Text = newProductQuantity.ToString();
            }
        }
    }
}
