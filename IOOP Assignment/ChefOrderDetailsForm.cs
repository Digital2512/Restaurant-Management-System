using System;
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
        private string[] ButtonsToUpdate = { "V01", "V02", "V03", "T01", "T02", "T03", "T04", "T05", "T06", "T07", "T08" };

        public ChefOrderDetailsForm()
        {
            InitializeComponent();
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

        private void UpdateButtonColor(Button button)
        {
            string orderStatus = GetOrderStatusForTable(button.Name); // Substring to skip prefix and get the table number

            this.BeginInvoke((MethodInvoker)delegate {
                if (orderStatus == "In Progress")
                {
                    button.BackColor = Color.Yellow;
                }
                else if (orderStatus == "Completed")
                {
                    button.BackColor = Color.Green; // Changed from Black for better visibility
                }
                else
                {
                    button.BackColor = SystemColors.Control; // Default color if status is unknown
                }
            });
        }


        private string GetOrderStatusForTable(string tableNumber)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = $"SELECT TOP 1 Status FROM Orders WHERE TableNumber = '{tableNumber}' ORDER BY OrderDateTime DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            return reader["Status"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving order status for table {tableNumber}: {ex.Message}");
                }
            }
            return "Unknown"; // Default status if not found or error occurs
        }

        private void TableButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string tableNumber = clickedButton.Name;  // Adjusted to remove Substring if not necessary

            if (tableNumber != null)
            {
                using (SqlConnection connection = new SqlConnection("Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = $"SELECT TOP 1 ProductID, Quantity, OrderDateTime, TableNumber, Status FROM Orders WHERE TableNumber = @TableNumber ORDER BY OrderDateTime DESC";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TableNumber", tableNumber);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            string productID = reader["ProductID"].ToString();
                            int quantity = Convert.ToInt32(reader["Quantity"]);
                            DateTime orderDateTime = Convert.ToDateTime(reader["OrderDateTime"]);
                            string status = reader["Status"].ToString();

                            string message = $"Product ID: {productID}\nQuantity: {quantity}\nOrder Date Time: {orderDateTime}\nTable Number: {tableNumber}\nStatus: {status}";
                            string caption = "Order Details";

                            var result = MessageBox.Show(message + "\n\nChange status?", caption, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (result == DialogResult.Yes)
                            {
                                // Toggle the status
                                status = status == "In Progress" ? "Completed" : "In Progress";

                                // Update the database
                                reader.Close(); // Important: Close the reader before executing another command
                                string updateQuery = $"UPDATE Orders SET Status = @Status WHERE TableNumber = @TableNumber AND ProductID = @ProductID";
                                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@Status", status);
                                    updateCommand.Parameters.AddWithValue("@TableNumber", tableNumber);
                                    updateCommand.Parameters.AddWithValue("@ProductID", productID);
                                    updateCommand.ExecuteNonQuery();
                                }

                                // Update button color after status update
                                UpdateButtonColor(clickedButton);

                                MessageBox.Show("Status updated to: " + status, "Update Successful");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No order found for this table.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid button clicked.");
            }
        }

        private void V01_Click(object sender, EventArgs e)
        {

        }
    }
}
