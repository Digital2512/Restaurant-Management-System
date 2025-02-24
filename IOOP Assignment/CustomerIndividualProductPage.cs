﻿using System;
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
    public partial class CustomerIndividualProductPage : Form
    {
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string productID;
        public string UserID;
        public CustomerIndividualProductPage(string userID, string previousSpecialInstructions, int previousQuantity)
        {
            InitializeComponent();
            this.UserID = userID;
            Database database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            query = $"SELECT ProductID FROM Menu WHERE Chosen = 'TRUE';";
            this.productID = database.getString(query);
            query = $"SELECT Name FROM Menu WHERE Chosen = 'TRUE';";
            string productName = database.getString(query);
            query = $"SELECT Price FROM Menu WHERE Chosen = 'TRUE';";
            float productPrice = database.getDecimal(query);
            query = $"SELECT Description FROM Menu WHERE Chosen = 'TRUE';";
            string productDescription = database.getString(query);
            query = $"SELECT ProductImage FROM Menu WHERE Chosen = 'TRUE';";
            this.productImagePBox.Image = database.getImage(query);

            this.lblProductID.Text = productID;
            this.lblProductName.Text = productName;
            this.lblProductPrice.Text = $"RM {productPrice}";
            this.lblProductDescription.Text = productDescription;
            this.lblProductQuantity.Text = "1";
            this.specialInstructionsRTxtBox.Text = previousSpecialInstructions;
            this.lblProductQuantity.Text = previousQuantity.ToString();
        }

        private void addToCartBtn_Click(object sender, EventArgs e) 
        {
            Database database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            query = $"SELECT ProductID FROM Menu WHERE Chosen = 'TRUE';";
            string productID = database.getString(query);
            query = $"SELECT Name FROM Menu WHERE Chosen = 'TRUE';";
            string productName = database.getString(query);
            query = $"SELECT Price FROM Menu WHERE Chosen = 'TRUE';";
            float productPrice = database.getDecimal(query);
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
                DateTime orderDateTimeString = DateTime.ParseExact(orderDateTimeMade, "dd/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                string formattedOrderDateTimeString = orderDateTimeString.ToString("yyyy-MM-dd HH:mm:ss");
                query = $"INSERT INTO Orders(OrderID, OrderDateTime, CustomerID, OrderStatus, PaymentStatus) VALUES ('{orderID}', '{formattedOrderDateTimeString}', '{customerID}', 'ORDERING', 'NOT_PAID');";
                if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Order Created");
                }
                else if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                {
                    MessageBox.Show("Order Not Created");
                }
            }
            else
            {
                orderID = previousOrderID;
            }
            
            string orderDetailsID = database.GenerateUniqueID("OD", "OrderDetailsID", "OrderDetails");
            query = $"INSERT INTO OrderDetails(OrderID, OrderDetailsID, ProductID, Quantity, Price, OrderSpecialInstructions, Name) VALUES ('{orderID}', '{orderDetailsID}', '{productID}', {productQuantity}, {productPrice.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}, '{productSpecialInstructions}', '{productName}');";
            bool orderDetailsRecorded = database.insertOrUpdateValuesIntoDatabase(query);
            query = $"SELECT OrderDetailsIDs FROM Orders WHERE OrderStatus = 'ORDERING';";
            string previousOrderDetailsIDs = database.getString(query);
            string renewedOrderDetailsIDs = null;
            if(renewedOrderDetailsIDs == "")
            {
                renewedOrderDetailsIDs = $"{orderDetailsID},";
            }else  if(renewedOrderDetailsIDs != "")
            {
                renewedOrderDetailsIDs = $"{previousOrderDetailsIDs},{orderDetailsID}";
            }
            query = $"UPDATE Orders SET OrderDetailsIDs = '{renewedOrderDetailsIDs}' WHERE OrderStatus = 'ORDERING'";
            bool orderDetailsRecordedWithOrder = database.insertOrUpdateValuesIntoDatabase(query);
            if (orderDetailsRecorded && orderDetailsRecordedWithOrder == true)
            {
                MessageBox.Show("Order Details Successfully Added To Cart");
            }
            else if(orderDetailsRecorded && orderDetailsRecordedWithOrder != true)
            {
                MessageBox.Show("Order Details Not Added To Cart");
            }
            query = $"UPDATE Menu SET Chosen = 'FALSE' WHERE ProductID = '{productID}'";
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                CustomerOrderPage customerOrderPage = new CustomerOrderPage(UserID);
                this.Hide();
                customerOrderPage.Show();
            }else if(database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Order Details Reset Failed");
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productQuantity = int.Parse(this.lblProductQuantity.Text);
                int newProductQuantity = productQuantity + 1;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = $"SELECT StockQuantityUsed FROM RecipeStock WHERE ProductID = @ProductID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ProductID", productID);

                    string stockQuantityList = Convert.ToString(cmd.ExecuteScalar());
                    string[] stockQuantityParts = stockQuantityList.Trim().Split(',');

                    bool shouldDisableButton = false;

                    foreach (string part in stockQuantityParts)
                    {
                        string[] stockQuantityPart = part.Trim().Split('*');

                        if (stockQuantityPart.Length != 2 || !int.TryParse(stockQuantityPart[1], out int stockQuantityInt))
                        {
                            continue;
                        }

                        int quantityNeeded = stockQuantityInt * newProductQuantity;

                        query = $"SELECT Quantity FROM Inventory WHERE StockID = '{stockQuantityPart[0]}'";
                        cmd.CommandText = query;
                        cmd.Parameters.Clear();

                        int currentQuantity = Convert.ToInt32(cmd.ExecuteScalar());

                        if (quantityNeeded > currentQuantity)
                        {
                            shouldDisableButton = true;
                            break; 
                        }
                    }

                    if (shouldDisableButton)
                    {
                        this.addBtn.Enabled = false;
                    }
                    else
                    {
                        this.lblProductQuantity.Text = newProductQuantity.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            int productQuantity = int.Parse(this.lblProductQuantity.Text);
            int newProductQuantity = productQuantity - 1;
            if (newProductQuantity < 1)
            {
                minusBtn.Enabled = false;
            }
            else
            {
                this.lblProductQuantity.Text = newProductQuantity.ToString();
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            this.Hide();
            string query = $"UPDATE Menu SET Chosen = 'FALSE' WHERE Chosen = 'TRUE'";
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                CustomerOrderPage customerOrderPage = new CustomerOrderPage(UserID);
                this.Hide();
                customerOrderPage.Show();
            }
            else if (database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Order Details Reset Failed");
            }
        }

        private void productImagePBox_Click(object sender, EventArgs e)
        {

        }
    }
}
