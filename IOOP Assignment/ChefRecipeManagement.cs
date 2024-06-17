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
        private Form parentForm;

        public ChefRecipeManagement(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
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

            RecipeDataView.Columns["StockQuantityUsed"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadRecipeDetails()
        {
            string query = "SELECT RecipeID, ProductID, StockQuantityUsed FROM RecipeStock";
            DataTable dataTable = Utility.ExecuteSqlQuery(query, null);
            RecipeDataView.DataSource = dataTable;
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

                BtnRecipeAdd.Enabled = true;
                BtnRecipeDone.Enabled = false;
                BtnRecipeCancel.Enabled = false;
                LBLQuantityRecipeShow.Visible = true;
                NumericQuantityUsed.Visible = false;
            }
        }

        private void LoadProductDetails(string productID)
        {
            string query = "SELECT Name, Description FROM Menu WHERE ProductID = @ProductID";
            SqlParameter[] parameters = { new SqlParameter("@ProductID", productID) };
            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string productName = $"Product Name: {row["Name"]} \n";
                string productDescription = $"Description: {row["Description"]}\n";
                InventoryRecipeBox.Items.Clear();
                InventoryRecipeBox.Items.Add(productName);
                InventoryRecipeBox.Items.Add(productDescription);
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
                        NumericQuantityUsed.Visible = false;
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
            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                string inventoryDetails = $"Inventory Name: {row["Name"]}\nQuantity: {row["Quantity"]}\nPrice: {row["IndividualPrice"]}\n";
                if (InventoryRecipeBox.Items.Count > 2)
                {
                    InventoryRecipeBox.Items.RemoveAt(2);  // Remove the existing inventory details
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
            DataTable dataTable = Utility.ExecuteSqlQuery(query, null);
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
                DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);
                DataRow row = dataTable.Rows[0];
                string inventoryDetails = $"Inventory Name: {row["Name"]}\nQuantity: {row["Quantity"]}\nPrice: {row["IndividualPrice"]}\n";
                if (InventoryRecipeBox.Items.Count > 2)
                {
                    InventoryRecipeBox.Items.RemoveAt(2);  // Remove the existing inventory details
                }
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

                string existingStockQuantityUsed = RecipeDataView.SelectedRows[0].Cells["StockQuantityUsed"].Value.ToString();


                if (existingStockQuantityUsed.Contains(selectedInventory))
                {
                    MessageBox.Show("The inventory ID already exists for the selected recipe. Please choose another inventory ID.");
                    return;
                }

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
                    Utility.ExecuteSqlCommand(query, parameters);
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
            parentForm.Show();
        }

        private void BtnRecipeAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
