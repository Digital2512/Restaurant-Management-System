using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefRecipeManagement : Form
    {
        private string connectionString = "Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;";

        public ChefRecipeManagement()
        {
            InitializeComponent();
            this.Load += RecipeManagementForm_Load;
            RecipeDataView.SelectionChanged += dataGridViewRecipes_SelectionChanged;
            ListRecipeInventory.SelectedIndexChanged += ListRecipeInventory_SelectedIndexChanged;
            BtnRecipeAdd.Click += BtnRecipeAdd_Click;
            BtnRecipeDone.Click += BtnRecipeDone_Click;
            BtnRecipeCancel.Click += BtnRecipeCancel_Click;
            InitializeDataGridView();
            NumericQuantityUsed.Visible = false;
        }

        private void RecipeManagementForm_Load(object sender, EventArgs e)
        {
            LoadRecipeDetails();
        }

        private void InitializeDataGridView()
        {
            RecipeDataView.Columns.Clear();

            RecipeDataView.Columns.Add("RecipeID", "RecipeID");
            RecipeDataView.Columns.Add("ProductID", "ProductID");
            RecipeDataView.Columns.Add("StockQuantityUsed", "Stock Quantity Used");

            RecipeDataView.Columns["RecipeID"].DataPropertyName = "RecipeID";
            RecipeDataView.Columns["ProductID"].DataPropertyName = "ProductID";
            RecipeDataView.Columns["StockQuantityUsed"].DataPropertyName = "StockQuantityUsed";
        }

        private void LoadRecipeDetails()
        {
            string query = "SELECT RecipeID, ProductID, StockQuantityUsed FROM RecipeStock";
            DataTable dataTable = ExecuteSqlQuery(query, null);
            RecipeDataView.DataSource = dataTable;
        }

        private DataTable ExecuteSqlQuery(string query, SqlParameter[] parameters)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        private void ExecuteSqlCommand(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    command.ExecuteNonQuery();
                }
            }
        }

        private void dataGridViewRecipes_SelectionChanged(object sender, EventArgs e)
        {
            if (RecipeDataView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = RecipeDataView.SelectedRows[0];
                string RecipeID = selectedRow.Cells["RecipeID"].Value.ToString();
                LBLRecipeIDShow.Text = RecipeID;
                LblProductIDShow.Text = selectedRow.Cells["ProductID"].Value.ToString();
                string stockQuantityUsed = selectedRow.Cells["StockQuantityUsed"].Value.ToString();
                LoadProductDetails(selectedRow.Cells["ProductID"].Value.ToString());
                LoadInventoryList(stockQuantityUsed);

                // Enable or disable Add Inventory button based on whether stockQuantityUsed is empty
                BtnRecipeAdd.Enabled = true;
                BtnRecipeDone.Enabled = false;
                BtnRecipeCancel.Enabled = false;
            }
        }

        private void LoadProductDetails(string productID)
        {
            string query = "SELECT Name, Description FROM Menu WHERE ProductID = @ProductID";
            SqlParameter[] parameters = { new SqlParameter("@ProductID", productID) };
            DataTable dataTable = ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string productDetails = $"Product Name: {row["Name"]}\nDescription: {row["Description"]}\n";
                InventoryRecipeBox.Items.Clear();
                InventoryRecipeBox.Items.Add(productDetails);
            }
        }

        private void LoadInventoryList(string stockQuantityUsed)
        {
            ListRecipeInventory.Items.Clear();
            if (!string.IsNullOrEmpty(stockQuantityUsed))
            {
                var inventoryItems = stockQuantityUsed.Split(',')
                                                      .Select(item => item.Split('*')[0].Trim())
                                                      .ToArray();
                ListRecipeInventory.Items.AddRange(inventoryItems);
            }
        }

        private void ListRecipeInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListRecipeInventory.SelectedItem != null)
            {
                string selectedInventory = ListRecipeInventory.SelectedItem.ToString();
                string stockQuantityUsed = RecipeDataView.SelectedRows[0].Cells["StockQuantityUsed"].Value.ToString();
                var inventoryItems = stockQuantityUsed.Split(',');

                foreach (var item in inventoryItems)
                {
                    var parts = item.Split('*');
                    if (parts[0].Trim() == selectedInventory)
                    {
                        LBLQuantityRecipeShow.Text = parts[1];
                        LBLQuantityRecipeShow.Visible = true;
                        LoadInventoryDetails(selectedInventory);
                        return;
                    }
                }
            }
            else
            {
                LBLQuantityRecipeShow.Visible = false;
                InventoryRecipeBox.Items.Clear();
            }
        }

        private void LoadInventoryDetails(string inventoryID)
        {
            string query = "SELECT * FROM Inventory WHERE StockID = @StockID";
            SqlParameter[] parameters = { new SqlParameter("@StockID", inventoryID) };
            DataTable dataTable = ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string inventoryDetails = $"Inventory Name: {row["Name"]}\nQuantity: {row["Quantity"]}\nPrice: {row["IndividualPrice"]}\n";
                if (InventoryRecipeBox.Items.Count > 1)
                {
                    InventoryRecipeBox.Items.RemoveAt(1);  // Remove the existing inventory details
                }
                InventoryRecipeBox.Items.Add(inventoryDetails);
            }
        }

        private void BtnRecipeAdd_Click(object sender, EventArgs e)
        {
            LoadAllInventory();
            BtnRecipeAdd.Enabled = false;
            BtnRecipeDone.Enabled = true;
            BtnRecipeCancel.Enabled = true;
            LBLQuantityRecipeShow.Visible = false;
            NumericQuantityUsed.Visible = true;
            ListRecipeInventory.SelectedIndexChanged -= ListRecipeInventory_SelectedIndexChanged;
            ListRecipeInventory.SelectedIndexChanged += ListRecipeInventory_SelectedIndexChangedForAdd;
        }

        private void LoadAllInventory()
        {
            string query = "SELECT StockID FROM Inventory";
            DataTable dataTable = ExecuteSqlQuery(query, null);
            ListRecipeInventory.Items.Clear();
            foreach (DataRow row in dataTable.Rows)
            {
                ListRecipeInventory.Items.Add(row["StockID"].ToString());
            }
        }

        private void ListRecipeInventory_SelectedIndexChangedForAdd(object sender, EventArgs e)
        {
            if (ListRecipeInventory.SelectedItem != null)
            {
                string selectedInventory = ListRecipeInventory.SelectedItem.ToString();
                string query = "SELECT * FROM Inventory WHERE StockID = @StockID";
                SqlParameter[] parameters = { new SqlParameter("@StockID", selectedInventory) };
                DataTable dataTable = ExecuteSqlQuery(query, parameters);
                DataRow row = dataTable.Rows[0];
                string inventoryDetails = $"Inventory Name: {row["Name"]}\nQuantity: {row["Quantity"]}\nPrice: {row["IndividualPrice"]}\n";
                InventoryRecipeBox.Items.Add(inventoryDetails);
                NumericQuantityUsed.Visible = true;
                NumericQuantityUsed.Value = 1;
            }
            else
            {
                InventoryRecipeBox.Items.Clear();
                NumericQuantityUsed.Visible = false;
            }
        }

        private void BtnRecipeDone_Click(object sender, EventArgs e)
        {
            if (ListRecipeInventory.SelectedItem != null && NumericQuantityUsed.Value > 0)
            {
                string selectedInventory = ListRecipeInventory.SelectedItem.ToString();
                int quantityUsed = (int)NumericQuantityUsed.Value;
                string stockQuantityUsed = $"{selectedInventory}*{quantityUsed}";

                string recipeID = LBLRecipeIDShow.Text;
                string productID = LblProductIDShow.Text;

                // Get existing StockQuantityUsed and append the new entry
                string existingStockQuantityUsed = RecipeDataView.SelectedRows[0].Cells["StockQuantityUsed"].Value.ToString();
                string newStockQuantityUsed = string.IsNullOrEmpty(existingStockQuantityUsed) ? stockQuantityUsed : $"{existingStockQuantityUsed}, {stockQuantityUsed}";

                string query = "UPDATE RecipeStock SET StockQuantityUsed = @StockQuantityUsed WHERE RecipeID = @RecipeID AND ProductID = @ProductID";
                SqlParameter[] parameters = {
                    new SqlParameter("@StockQuantityUsed", newStockQuantityUsed),
                    new SqlParameter("@RecipeID", recipeID),
                    new SqlParameter("@ProductID", productID)
                };

                // Confirmation message
                var confirmation = MessageBox.Show($"Add Inventory:\nInventory ID: {selectedInventory}\nQuantity: {quantityUsed}", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    ExecuteSqlCommand(query, parameters);
                    LoadRecipeDetails();
                    ClearAddInventoryForm();
                }
            }
            else
            {
                MessageBox.Show("Please select an inventory and enter a valid quantity.");
            }
        }

        private void BtnRecipeCancel_Click(object sender, EventArgs e)
        {
            ClearAddInventoryForm();
        }

        private void ClearAddInventoryForm()
        {
            BtnRecipeAdd.Enabled = true;
            BtnRecipeDone.Enabled = false;
            BtnRecipeCancel.Enabled = false;
            ListRecipeInventory.Items.Clear();
            InventoryRecipeBox.Items.Clear();
            NumericQuantityUsed.Visible = false;
            ListRecipeInventory.SelectedIndexChanged -= ListRecipeInventory_SelectedIndexChangedForAdd;
            ListRecipeInventory.SelectedIndexChanged += ListRecipeInventory_SelectedIndexChanged;
        }

        private void BtnRecipeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListRecipeInventory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
