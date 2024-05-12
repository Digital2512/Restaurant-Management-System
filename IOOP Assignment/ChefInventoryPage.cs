using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefInventoryForm : Form
    {
        Timer timer = new Timer();
        public ChefInventoryForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            LoadInventoryData();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
        }

        private void LoadInventoryData()
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "SELECT StockID, Name, Quantity, IndividualPrice, Status FROM Inventory ORDER BY StockID ASC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChefInventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iOOPDatabaseDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.iOOPDatabaseDataSet.Inventory);

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Console.WriteLine("CellFormatting called");  // Debug output

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value as string;
                Console.WriteLine($"Status: {status}");  // More detailed debug output

                if (status == "Out of Stock")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
                else if (status == "Lack of Stock")
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;  // Ensuring other statuses are clear
                }
            }
        }

        private bool ConfirmAction(string details)
        {
            return MessageBox.Show(details, "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private void BtnInventoryAdd_Click_1(object sender, EventArgs e)
        {
            string id = TBInventoryID.Text.Trim();
            if (string.IsNullOrEmpty(id) || !int.TryParse(TBInventoryQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid Inventory ID and Quantity.");
                return;
            }

            if (ConfirmAction($"Are you sure you want to add {quantity} int0 Inventory ID: {id}?"))
            {
                AddInventory(id, quantity);
            }

        }

        private void AddInventory(string id, int quantity)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "UPDATE Inventory SET Quantity += @Quantity WHERE StockID = @StockID";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@StockID", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Inventory updated successfully.");
                    else
                        MessageBox.Show("No inventory updated.");
                }
                LoadInventoryData();
            }
        }

        private void BtnInventoryDelete_Click_1(object sender, EventArgs e)
        {
            string id = TBInventoryID.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter an Inventory ID.");
                return;
            }

            if (ConfirmAction($"Are you sure you want to delete Inventory ID: {id}?"))
            {
                DeleteInventory(id);
            }
        }


        private void DeleteInventory(string id)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "DELETE FROM Inventory WHERE StockID = @StockID";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Inventory deleted successfully.");
                    else
                        MessageBox.Show("No inventory deleted.");
                }
                LoadInventoryData();
            }
        }

        private void BtnInventoryEdit_Click_1(object sender, EventArgs e)
        {
            string id = TBInventoryID.Text.Trim();
            if (string.IsNullOrEmpty(id) || !int.TryParse(TBInventoryQuantity.Text, out int quantity) || !decimal.TryParse(TbInventoryPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid Inventory ID, Quantity, and Price.");
                return;
            }

            if (ConfirmAction($"Are you sure you want to update Inventory ID: {id} with Quantity: {quantity} and Price: {price}?"))
            {
                EditInventory(id, quantity, price);
            }
        }

        private void EditInventory(string id, int quantity, decimal price)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "UPDATE Inventory SET Quantity = @Quantity, IndividualPrice = @Price WHERE StockID = @StockID";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    command.Parameters.AddWithValue("@StockID", id);
                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                        MessageBox.Show("Inventory updated successfully.");
                    else
                        MessageBox.Show("No inventory updated.");
                }
                LoadInventoryData();
            }
        }

        private bool InventoryExists(string id)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM Inventory WHERE StockID = @StockID";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", id);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        private void ButtonAddNewInventory_Click(object sender, EventArgs e)
        {
            string id = TBInventoryID.Text.Trim();
            if (string.IsNullOrEmpty(id) || !int.TryParse(TBInventoryQuantity.Text, out int quantity) || !decimal.TryParse(TbInventoryPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter valid Inventory ID, Quantity, and Price.");
                return;
            }

            if (InventoryExists(id))
            {
                MessageBox.Show("An inventory item with this ID already exists.");
                return;
            }

            string details = $"Are you sure you want to add a new inventory item?\nID: {id}\nQuantity: {quantity}\nPrice: {price}";
            if (ConfirmAction(details))
            {
                AddNewInventory(id, quantity, price);
            }
        }

        private void AddNewInventory(string id, int quantity, decimal price)
        {
            string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";
            string query = "INSERT INTO Inventory (StockID, Name, Quantity, IndividualPrice, Status) VALUES (@StockID, @Name, @Quantity, @Price, 'Adequate')";

            using (var connection = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@StockID", id);
                    command.Parameters.AddWithValue("@Name", "New Item");  // Assuming a default name, this should ideally be input by the user
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Price", price);
                    connection.Open();
                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("New inventory item added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to add new inventory item.");
                    }
                    LoadInventoryData();  // Refresh data grid
                }
            }
        }
    }
}
