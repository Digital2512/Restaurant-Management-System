using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefOrderDetailsForm : Form
    {
        private System.Timers.Timer timer;
        private string[] ButtonsToUpdate = { "VIP01", "VIP02", "T01", "T02", "T03", "T04", "T05", "T06", "T07", "T08", "T09", "T10" };
        private string userid;

        public ChefOrderDetailsForm(string userid)
        {
            InitializeComponent();
            this.userid = userid;
            this.Load += ChefOrderDetailsForm_Load;
            lblrealtime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");
            timer = new System.Timers.Timer(1000);
            timer.Elapsed += UpdateTimeLabel;
            timer.Start();
        }

        private void ChefOrderDetailsForm_Load(object sender, EventArgs e)
        {
            foreach (string buttonName in ButtonsToUpdate)
            {
                Button button = Controls.Find(buttonName, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    UpdateButtonColor(button);
                    button.Click += TableButton_Click;
                }
            }

            comboBoxOrderTable.SelectedIndexChanged += comboBoxOrderTable_SelectedIndexChanged;
            comboBoxChefReceived.SelectedIndexChanged += comboBoxChefReceived_SelectedIndexChanged;
            comboBoxProductID.SelectedIndexChanged += comboBoxProductID_SelectedIndexChanged;
            LoadChefOrders();
        }

        private void UpdateButtonColor(Button button)
        {
            string orderStatus = GetOrderStatusForTable(button.Name);

            this.BeginInvoke((MethodInvoker)delegate
            {
                if (orderStatus == "IN_PROGRESS")
                {
                    button.BackColor = Color.Red;
                }
                else if (orderStatus == "PENDING")
                {
                    button.BackColor = Color.Yellow;
                }
                else
                {
                    button.BackColor = Color.Green;
                }
            });
        }

        private string GetOrderStatusForTable(string tableNumber)
        {
            string query = $"SELECT TOP 1 OrderStatus FROM Orders WHERE PlaceNumber = @PlaceNumber ORDER BY OrderDateTime DESC";
            SqlParameter[] parameters = { new SqlParameter("@PlaceNumber", tableNumber) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["OrderStatus"].ToString();
            }

            return "Unknown";
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string tableNumber = clickedButton.Name;

            if (tableNumber != null)
            {
                MessageBox.Show($"Table {tableNumber} chosen. Please select the order ID from the combo box below.");
                comboBoxChefReceived.Enabled = false;

                // Clear previous selection and reset UI
                BtnOrderCancel_Click_1(sender, e);

                // Set table number in label
                LblTableSelectedShow.Text = tableNumber;

                string query = "SELECT OrderID FROM Orders WHERE PlaceNumber = @PlaceNumber AND (OrderStatus = 'PENDING' OR OrderStatus = 'IN_PROGRESS')";
                SqlParameter[] parameters = { new SqlParameter("@PlaceNumber", tableNumber) };

                DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

                comboBoxOrderTable.Items.Clear();
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBoxOrderTable.Items.Add(row["OrderID"].ToString());
                }
            }
        }

        private void comboBoxOrderTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrderTable.SelectedItem != null)
            {
                string orderID = comboBoxOrderTable.SelectedItem.ToString();
                LoadOrderDetails(orderID);
                comboBoxChefReceived.Enabled = false;
                BtnOrderCancel.Enabled = true;
            }
        }

        private void comboBoxChefReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChefReceived.SelectedItem != null)
            {
                string orderID = comboBoxChefReceived.SelectedItem.ToString();
                LoadOrderDetails(orderID);
                comboBoxOrderTable.Enabled = false;
            }
        }

        private void comboBoxProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProductID.SelectedItem != null)
            {
                string productID = comboBoxProductID.SelectedItem.ToString();
                if (comboBoxOrderTable.SelectedItem != null)
                {
                    string orderID = comboBoxOrderTable.SelectedItem.ToString();

                    string query = @"
                        SELECT 
                            od.ProductID,
                            od.Quantity,
                            od.Price,
                            m.Name AS ProductName
                        FROM 
                            OrderDetails od
                        JOIN
                            Menu m ON od.ProductID = m.ProductID
                        WHERE 
                            od.OrderID = @OrderID AND od.ProductID = @ProductID";
                    SqlParameter[] parameters = {
                        new SqlParameter("@OrderID", orderID),
                        new SqlParameter("@ProductID", productID)
                    };

                    DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        label6.Text = row["ProductName"].ToString();
                        label7.Text = row["Quantity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No details found for the selected product.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select an order from the order table combo box first.");
                }
            }
        }

        private void LoadOrderDetails(string orderID)
        {
            string query = @"
                SELECT 
                    o.OrderID,
                    od.ProductID,
                    od.Quantity,
                    od.Price,
                    o.OrderStatus,
                    o.ChefID,
                    o.PlaceNumber,
                    o.EstimatedTimeLeft,
                    m.Name AS ProductName
                FROM 
                    Orders o
                JOIN 
                    OrderDetails od ON o.OrderID = od.OrderID
                JOIN
                    Menu m ON od.ProductID = m.ProductID
                WHERE 
                    o.OrderID = @OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            comboBoxProductID.Items.Clear(); // Clear previous items

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    comboBoxProductID.Items.Add(row["ProductID"].ToString());
                }

                // Load the first product details by default
                DataRow firstRow = dataTable.Rows[0];
                LblChefIDShow.Text = firstRow["ChefID"].ToString();
                label6.Text = firstRow["ProductName"].ToString();
                label7.Text = firstRow["Quantity"].ToString();
                label8.Text = firstRow["Price"].ToString(); // Ensure this label is updated if it exists
                label9.Text = firstRow["OrderStatus"].ToString();
                LblTableSelectedShow.Text = firstRow["PlaceNumber"].ToString();
                label12.Text = firstRow["EstimatedTimeLeft"].ToString();

                comboBoxProductID.SelectedIndex = 0; // Select the first item by default

                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                LblTableSelectedShow.Visible = true;
                label12.Visible = true;
            }
        }

        private void BtnOrderUpdate_Click_1(object sender, EventArgs e)
        {
            if (comboBoxOrderTable.SelectedItem != null || comboBoxChefReceived.SelectedItem != null)
            {
                string orderID = comboBoxOrderTable.SelectedItem != null ? comboBoxOrderTable.SelectedItem.ToString() : comboBoxChefReceived.SelectedItem.ToString();
                string query = "SELECT OrderStatus FROM Orders WHERE OrderID = @OrderID";
                SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

                DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string status = row["OrderStatus"].ToString();

                    if (status == "PENDING")
                    {
                        int totalQuantity = CalculateTotalQuantity(orderID);
                        string productNames = GetProductNamesFromOrder(orderID);

                        // Calculate estimated time left (10 minutes per product)
                        int estimatedTimeLeft = totalQuantity * 10;

                        var result = MessageBox.Show($"Do you want to update the order status to 'IN_PROGRESS'?\n\nOrder ID: {orderID}\nProduct Names: {productNames}\nEstimated Time Left: {estimatedTimeLeft} minutes", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            string updateQuery = "UPDATE Orders SET OrderStatus = 'IN_PROGRESS', EstimatedTimeLeft = @EstimatedTimeLeft, ChefID = @ChefID WHERE OrderID = @OrderID";
                            SqlParameter[] updateParameters = {
                                new SqlParameter("@OrderID", orderID),
                                new SqlParameter("@EstimatedTimeLeft", estimatedTimeLeft),
                                new SqlParameter("@ChefID", this.userid)
                            };
                            Utility.ExecuteSqlCommand(updateQuery, updateParameters);
                            MessageBox.Show("Order status updated to In Progress.");
                            LoadOrderDetails(orderID); // Update the labels with the new details
                            LoadChefOrders();
                        }
                    }
                    else if (status == "IN_PROGRESS")
                    {
                        string productID = GetProductIDFromOrder(orderID);
                        int quantity = GetQuantityFromOrder(orderID);

                        var result = MessageBox.Show($"Do you want to update the order status to 'COMPLETED'?\n\nOrder ID: {orderID}\nProduct Name: {productID}", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            DeductInventory(productID, quantity);

                            string updateQuery = "UPDATE Orders SET OrderStatus = 'COMPLETED', EstimatedTimeLeft = '0' WHERE OrderID = @OrderID";
                            SqlParameter[] updateParameters = { new SqlParameter("@OrderID", orderID) };
                            Utility.ExecuteSqlCommand(updateQuery, updateParameters);
                            MessageBox.Show("Order status updated to Completed.");
                            LoadOrderDetails(orderID); // Update the labels with the new details
                            LoadChefOrders();
                            UpdateButtonColorAfterCompletion(orderID);
                        }
                    }
                    else if (status == "COMPLETED")
                    {
                        MessageBox.Show("Order is already completed.");
                    }
                }
            }
        }

        private int CalculateTotalQuantity(string orderID)
        {
            string query = "SELECT SUM(Quantity) AS TotalQuantity FROM OrderDetails WHERE OrderID = @OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                return Convert.ToInt32(dataTable.Rows[0]["TotalQuantity"]);
            }
            return 0;
        }

        private string GetProductNamesFromOrder(string orderID)
        {
            string query = "SELECT m.Name FROM OrderDetails od JOIN Menu m ON od.ProductID = m.ProductID WHERE od.OrderID = @OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
            string productNames = string.Join(", ", dataTable.Rows.Cast<DataRow>().Select(row => row["Name"].ToString()));
            return productNames;
        }

        private string GetProductIDFromOrder(string orderID)
        {
            string query = "SELECT TOP 1 ProductID FROM OrderDetails WHERE OrderID = @OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["ProductID"].ToString();
            }
            return string.Empty;
        }

        private int GetQuantityFromOrder(string orderID)
        {
            string query = "SELECT SUM(Quantity) AS TotalQuantity FROM OrderDetails WHERE OrderID = @OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                return Convert.ToInt32(dataTable.Rows[0]["TotalQuantity"]);
            }
            return 0;
        }

        private void UpdateButtonColorAfterCompletion(string orderID)
        {
            string query = "SELECT PlaceNumber FROM Orders WHERE OrderID = @OrderID";
            SqlParameter[] parameters = { new SqlParameter("@OrderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
            if (dataTable.Rows.Count > 0)
            {
                string tableNumber = dataTable.Rows[0]["PlaceNumber"].ToString();
                Button button = Controls.Find(tableNumber, true).FirstOrDefault() as Button;
                if (button != null)
                {
                    button.BackColor = Color.Green;
                }
            }
        }

        private void BtnOrderCancel_Click_1(object sender, EventArgs e)
        {
            // Clear the selected items in the combo boxes
            comboBoxOrderTable.SelectedItem = null;
            comboBoxChefReceived.SelectedItem = null;
            comboBoxProductID.SelectedItem = null;

            // Re-enable the combo boxes
            comboBoxOrderTable.Enabled = true;
            comboBoxChefReceived.Enabled = true;

            // Clear the product ID combo box items
            comboBoxProductID.Items.Clear();

            // Clear the labels
            LblTableSelectedShow.Text = string.Empty;
            LblChefIDShow.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = string.Empty;
            label9.Text = string.Empty;
            label12.Text = string.Empty;

            // Hide the labels
            label6.Visible = false;
            label7.Visible = false;
            label9.Visible = false;
            LblTableSelectedShow.Visible = false;
            label12.Visible = false;
        }

        private void LoadChefOrders()
        {
            comboBoxChefReceived.Items.Clear();
            string query = "SELECT OrderID FROM Orders WHERE ChefID = @ChefID AND (OrderStatus = 'PENDING' OR OrderStatus = 'IN_PROGRESS')";
            SqlParameter[] parameters = { new SqlParameter("@ChefID", this.userid) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    string orderId = row["OrderID"].ToString();
                    comboBoxChefReceived.Items.Add(orderId);
                }
            }
            else
            {
                MessageBox.Show("No orders found for the logged-in chef.");
            }
        }

        private void DeductInventory(string productID, int quantity)
        {
            string query = "SELECT StockQuantityUsed FROM RecipeStock WHERE ProductID = @ProductID";
            SqlParameter[] parameters = { new SqlParameter("@ProductID", productID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                string stockQuantityUsed = dataTable.Rows[0]["StockQuantityUsed"].ToString();
                var inventoryItems = stockQuantityUsed.Split(',');

                foreach (var item in inventoryItems)
                {
                    var parts = item.Split('*');
                    string inventoryID = parts[0].Trim();
                    int usedQuantity = Convert.ToInt32(parts[1]) * quantity;

                    UpdateInventory(inventoryID, usedQuantity);
                }
            }
        }

        private void UpdateInventory(string inventoryID, int usedQuantity)
        {
            string query = "UPDATE Inventory SET Quantity = Quantity - @UsedQuantity WHERE StockID = @StockID";
            SqlParameter[] parameters = {
                new SqlParameter("@UsedQuantity", usedQuantity),
                new SqlParameter("@StockID", inventoryID)
            };

            Utility.ExecuteSqlCommand(query, parameters);
        }

        private void UpdateTimeLabel(object sender, ElapsedEventArgs e)
        {
            Action updateLabel = () => lblrealtime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");
            if (lblrealtime.InvokeRequired)
            {
                lblrealtime.Invoke(updateLabel);
            }
            else
            {
                updateLabel();
            }
        }

        private void BbackH_Click(object sender, EventArgs e)
        {
            Utility.OpenForm(this, new ChefHomePage(userid));
        }

        private void T01_Click(object sender, EventArgs e)
        {

        }

        private void V01_Click(object sender, EventArgs e)
        {

        }
    }
}
