using System;
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
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string productID;
        public CustomerIndividualProductPage()
        {
            InitializeComponent();
            Database database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            query = $"SELECT ProductID FROM Menu WHERE Chosen = 'TRUE';";
            this.productID = database.getString(query);
            query = $"SELECT Name FROM Menu WHERE Chosen = 'TRUE';";
            string productName = database.getString(query);
            query = $"SELECT Price FROM Menu WHERE Chosen = 'TRUE';";
            int productPrice = database.getDecimal(query);
            query = $"SELECT Description FROM Menu WHERE Chosen = 'TRUE';";
            string productDescription = database.getString(query);
            query = $"SELECT ProductImage FROM Menu WHERE Chosen = 'TRUE';";
            this.productImagePBox.Image = database.getImage(query);

            this.lblProductID.Text = productID;
            this.lblProductName.Text = productName;
            this.lblProductPrice.Text = $"RM {productPrice}";
            this.lblProductDescription.Text = productDescription;
            this.lblProductQuantity.Text = "1";
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            query = $"SELECT ProductID FROM Menu WHERE Chosen = 'TRUE';";
            string productID = database.getString(query);
            query = $"SELECT Price FROM Menu WHERE Chosen = 'TRUE';";
            int productPrice = database.getDecimal(query);
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
            query = $"INSERT INTO OrderDetails(OrderID, OrderDetailsID, ProductID, Quantity, Price, specialInstructions) VALUES ('{orderID}', '{orderDetailsID}', '{productID}', '{productQuantity}', '{productPrice}', '{productSpecialInstructions}')";
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
                CustomerOrderPage customerOrderPage = new CustomerOrderPage();
                this.Hide();
                customerOrderPage.Show();
            }else if(database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Order Details Reset Failed");
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int productQuantity = int.Parse(this.lblProductQuantity.Text);
            int newProductQuantity = productQuantity + 1;
            this.lblProductQuantity.Text = newProductQuantity.ToString();
            /*
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
                    string[] stockQuantityParts = stockQuantityList.Split(',');

                    bool shouldDisableButton = false;

                    foreach (string part in stockQuantityParts)
                    {
                        string[] stockQuantityPart = part.Split('*');

                        if (stockQuantityPart.Length != 2 || !int.TryParse(stockQuantityPart[1], out int stockQuantityInt))
                        {
                            continue;
                        }

                        int quantityNeeded = stockQuantityInt * newProductQuantity;

                        query = $"SELECT Quantity FROM Inventory WHERE StockID = @StockID";
                        cmd.CommandText = query;
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@StockID", stockQuantityPart[0]);

                        int currentQuantity = Convert.ToInt32(cmd.ExecuteScalar());

                        if (quantityNeeded > currentQuantity)
                        {
                            shouldDisableButton = true;
                            break; // No need to continue if one stock is not enough
                        }
                    }

                    if (shouldDisableButton)
                    {
                        this.addButton.Enabled = false;
                    }
                    else
                    {
                        this.lblProductQuantity.Text = newProductQuantity.ToString();
                    }
                }
=======
            Database database = new Database(connectionString);
            // Parse current product quantity and calculate new quantity
            int productQuantity = int.Parse(this.lblProductQuantity.Text);
            int newProductQuantity = productQuantity + 1;

            bool shouldDisableButton = false;

            // Initialize database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get stock quantity used for the product from the recipe
                string query = $"SELECT StockQuantityUsed FROM RecipeStock WHERE ProductID = '{productID}';";
                string stockQuantityList = database.getString(query);
                string[] stockQuantityParts = stockQuantityList.Split(',');

                // Iterate over each stock quantity part
                foreach (string part in stockQuantityParts)
                {
                    string[] stockQuantityPart = part.Split('*');

                    // Check if the stock quantity part format is valid
                    if (stockQuantityPart.Length != 2)
                    {
                        MessageBox.Show("Invalid stock quantity part format.");
                        continue;
                    }

                    string stockID = stockQuantityPart[0];
                    string stockQuantityString = stockQuantityPart[1];

                    // Check if the stock quantity value is a valid integer
                    if (!int.TryParse(stockQuantityString, out int stockQuantityInt))
                    {
                        MessageBox.Show("Invalid stock quantity value.");
                        continue;
                    }

                    int quantityNeeded = stockQuantityInt * newProductQuantity;

                    // Get current quantity from the inventory for the current stock ID
                    string quantityQuery = $"SELECT Quantity FROM Inventory WHERE StockID = '{stockID}';";
                    MessageBox.Show($"Executing query: {quantityQuery}"); // Log the query for debugging
                    int currentQuantity = 0;

                    using (SqlCommand cmd = new SqlCommand(quantityQuery, connection))
                    {
                        try
                        {
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    if (reader.Read())
                                    {
                                        currentQuantity = reader.GetInt32(0);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error executing query: {ex.Message}");
                        }
                    }

                    MessageBox.Show($"Retrieved current quantity: {currentQuantity}"); // Log the retrieved quantity for debugging

                    if (quantityNeeded > currentQuantity)
                    {
                        shouldDisableButton = true;
                    }

                    // Debug information (optional)
                    MessageBox.Show($"StockID: {stockID}");
                    MessageBox.Show($"Quantity needed: {quantityNeeded}");
                    MessageBox.Show($"Current inventory quantity: {currentQuantity}");
                }

                connection.Close();
>>>>>>> Valerie
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            */
        }

<<<<<<< HEAD


=======
>>>>>>> Valerie
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            this.Hide();
            string query = $"UPDATE Menu SET Chosen = 'FALSE' WHERE Chosen = 'TRUE'";
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                CustomerOrderPage customerOrderPage = new CustomerOrderPage();
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
