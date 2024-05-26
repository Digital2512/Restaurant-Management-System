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
        private string[] ButtonsToUpdate = { "V01", "V02", "T01", "T02", "T03", "T04", "T05", "T06", "T07", "T08", "T09", "T10" };
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

            OrderReceived.SelectedIndexChanged += OrderReceived_SelectedIndexChanged;
        }

        private void UpdateButtonColor(Button button)
        {
            string orderStatus = GetOrderStatusForTable(button.Name);

            this.BeginInvoke((MethodInvoker)delegate
            {
                if (orderStatus == "In Progress")
                {
                    button.BackColor = Color.Yellow;
                }
                else if (orderStatus == "Completed")
                {
                    button.BackColor = Color.Green;
                }
                else if (orderStatus == "Pending")
                {
                    button.BackColor = Color.DarkGray;
                }
                else
                {
                    button.BackColor = SystemColors.Control;
                }
            });
        }

        private string GetOrderStatusForTable(string tableNumber)
        {
            string query = $"SELECT TOP 1 Status FROM Orders WHERE TableNumber = @TableNumber AND ChefID IS NULL ORDER BY OrderDateTime ASC";
            SqlParameter[] parameters = { new SqlParameter("@TableNumber", tableNumber) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0]["Status"].ToString();
            }
            else
            {
                query = $"SELECT TOP 1 Status FROM Orders WHERE TableNumber = @TableNumber ORDER BY OrderDateTime DESC";
                dataTable = Utility.ExecuteSqlQuery(query, parameters);
                if (dataTable.Rows.Count > 0)
                {
                    return dataTable.Rows[0]["Status"].ToString();
                }
            }

            return "Unknown";
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string tableNumber = clickedButton.Name;

            if (tableNumber != null)
            {
                string query = @"
                        SELECT TOP 1 
                            o.OrderID, 
                            od.ProductID, 
                            od.Quantity, 
                            o.OrderDateTime, 
                            o.TableNumber, 
                            o.Status, 
                            o.EstimatedTimeLeft, 
                            od.OrderSpecialInstructions, 
                            od.Price
                        FROM Orders o
                        JOIN OrderDetails od ON o.OrderID = od.OrderID
                        WHERE o.TableNumber = @TableNumber AND o.ChefID IS NULL
                        ORDER BY o.OrderDateTime ASC";
                SqlParameter[] parameters = { new SqlParameter("@TableNumber", tableNumber) };

                DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    string orderID = row["OrderID"].ToString();
                    string productID = row["ProductID"].ToString();
                    int quantity = Convert.ToInt32(row["Quantity"]);
                    DateTime orderDateTime = Convert.ToDateTime(row["OrderDateTime"]);
                    string status = row["Status"].ToString();
                    string estimatedTimeLeft = row["EstimatedTimeLeft"].ToString();
                    string specialInstructions = row["OrderSpecialInstructions"].ToString();
                    string price = row["Price"].ToString();

                    string message = $"Order ID: {orderID}\nProduct ID: {productID}\nQuantity: {quantity}\nOrder Date Time: {orderDateTime}\nTable Number: {tableNumber}\nStatus: {status}\nEstimated Time Left: {estimatedTimeLeft}\nSpecial Instructions: {specialInstructions}\nPrice: {price}";
                    string caption = "Order Details";

                    var result = MessageBox.Show(message + "\n\nReceive this order?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        string updateQuery = $"UPDATE Orders SET ChefID = @ChefID, Status = 'In Progress' WHERE OrderID = @OrderID";
                        SqlParameter[] updateParameters = {
                            new SqlParameter("@ChefID", this.userid),
                            new SqlParameter("@OrderID", orderID)
                        };
                        Utility.ExecuteSqlCommand(updateQuery, updateParameters);

                        OrderReceived.Items.Add(orderID);
                        UpdateButtonColor(clickedButton);
                    }
                }
                else
                {
                    MessageBox.Show("No order found for this table.");
                }
            }
            else
            {
                MessageBox.Show("Invalid button clicked.");
            }
        }

        private void OrderReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderReceived.SelectedItem != null)
            {
                string orderID = OrderReceived.SelectedItem.ToString();
                LoadOrderDetails(orderID);
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
                    od.OrderSpecialInstructions,
                    o.Status,
                    o.TableNumber,
                    o.EstimatedTimeLeft
                FROM 
                    Orders o
                JOIN 
                    OrderDetails od ON o.OrderID = od.OrderID
                WHERE 
                    o.OrderID = @orderID;";
            SqlParameter[] parameters = { new SqlParameter("@orderID", orderID) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                label6.Text = row["ProductID"].ToString();
                label7.Text = row["Quantity"].ToString();
                label8.Text = row["Price"].ToString();
                label9.Text = row["Status"].ToString();
                label10.Text = row["TableNumber"].ToString();
                label12.Text = row["EstimatedTimeLeft"].ToString();
            }
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
            this.Close();
        }
    }
}
