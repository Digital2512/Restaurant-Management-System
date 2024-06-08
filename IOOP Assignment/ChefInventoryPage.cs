using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefInventoryForm : Form
    {
        private enum ActionState
        {
            None,
            NewItem,
            UpdateItem,
            DeleteItem
        }

        private ActionState currentAction = ActionState.None;

        Timer timer = new Timer();
        public ChefInventoryForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            InitializeDataGridView();
            LoadInventoryData();
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            dataGridView1.SelectionChanged += new EventHandler(dataGridView1_SelectionChanged);

            ToggleTextBoxVisibility(false);
            BtnDone.Visible = false;
            BtnInventoryCancel.Visible = false;

            checkBoxAdequate.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBoxLack.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);
            checkBoxOut.CheckedChanged += new EventHandler(CheckBox_CheckedChanged);

            numericUpDownQuantity.Maximum = decimal.MaxValue;
            numericUpDownPrice.Maximum = decimal.MaxValue;
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear(); // Clear existing columns if any

            // Adding columns programmatically
            dataGridView1.Columns.Add("StockID", "StockID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Quantity", "Quantity");
            dataGridView1.Columns.Add("IndividualPrice", "Individual Price");
            dataGridView1.Columns.Add("Status", "Status");

            // Set DataPropertyName for each column
            dataGridView1.Columns["StockID"].DataPropertyName = "StockID";
            dataGridView1.Columns["Name"].DataPropertyName = "Name";
            dataGridView1.Columns["Quantity"].DataPropertyName = "Quantity";
            dataGridView1.Columns["IndividualPrice"].DataPropertyName = "IndividualPrice";
            dataGridView1.Columns["Status"].DataPropertyName = "Status";
        }

        private void LoadInventoryData()
        {
            string query = "SELECT StockID, Name, Quantity, IndividualPrice, Status FROM Inventory ORDER BY StockID ASC";

            DataTable dataTable = Utility.ExecuteSqlQuery(query, null);
            dataGridView1.DataSource = dataTable;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("MMMM d, yyyy\nh:mm:ss tt");
        }

        private void Btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                string status = e.Value as string;
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
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && currentAction == ActionState.None)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                LBLStockID.Text = selectedRow.Cells["StockID"].Value.ToString();
                LBLName.Text = selectedRow.Cells["Name"].Value.ToString();
                LBLQuantity.Text = selectedRow.Cells["Quantity"].Value.ToString();
                LBLPrice.Text = selectedRow.Cells["IndividualPrice"].Value.ToString();
                LBLStatus.Text = selectedRow.Cells["Status"].Value.ToString();

                numericUpDownQuantity.Value = Convert.ToDecimal(selectedRow.Cells["Quantity"].Value);
                numericUpDownPrice.Value = Convert.ToDecimal(selectedRow.Cells["IndividualPrice"].Value);
                ToggleCheckBox(selectedRow.Cells["Status"].Value.ToString());
            }
        }

        private bool ConfirmAction(string details)
        {
            return Utility.ShowConfirmationDialog(details);
        }

        private void ButtonAddNewInventory_Click(object sender, EventArgs e)
        {
            currentAction = ActionState.NewItem;
            ClearDetails();
            ToggleTextBoxVisibility(true);
            LBLStockID.Text = GenerateNewID();
            BtnDone.Visible = true;
            BtnInventoryCancel.Visible = true;
            DisableActionButtons();
        }

        private void BtnInventoryDelete_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LBLStockID.Text))
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }
            currentAction = ActionState.DeleteItem;
            ToggleTextBoxVisibility(false);
            BtnDone.Visible = true;
            BtnInventoryCancel.Visible = true;
            DisableActionButtons();
        }

        private void BtnInventoryAdd_Click(object sender, EventArgs e)
        //update inventory
        {
            if (string.IsNullOrEmpty(LBLStockID.Text))
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }
            currentAction = ActionState.UpdateItem;
            ToggleTextBoxVisibility(true);
            BtnDone.Visible = true;
            BtnInventoryCancel.Visible = true;
            DisableActionButtons();
        }

        private void BtnDone_Click_1(object sender, EventArgs e)
        {
            string id = LBLStockID.Text.Trim();
            string name = TBInventoryName.Text.Trim();
            int quantity = (int)numericUpDownQuantity.Value;
            decimal price = numericUpDownPrice.Value;
            string status = GetSelectedStatus();

            if (!ValidateStatus(status, quantity))
            {
                return;
            }

            if (currentAction == ActionState.NewItem)
            {
                if (InventoryExists(id))
                {
                    MessageBox.Show("An inventory item with this ID already exists.");
                    return;
                }

                string details = $"Are you sure you want to add a new inventory item?\nID: {id}\nName: {name}\nQuantity: {quantity}\nPrice: {price}\nStatus: {status}";
                if (ConfirmAction(details))
                {
                    AddNewInventory(id, name, quantity, price, status);
                }
            }
            else if (currentAction == ActionState.UpdateItem)
            {
                string details = "Are you sure you want to update the following fields?\n";
                if (name != LBLName.Text) details += $"Name: {LBLName.Text} -> {name}\n";
                if (quantity.ToString() != LBLQuantity.Text) details += $"Quantity: {LBLQuantity.Text} -> {quantity}\n";
                if (price.ToString() != LBLPrice.Text) details += $"Price: {LBLPrice.Text} -> {price}\n";
                if (status != LBLStatus.Text) details += $"Status: {LBLStatus.Text} -> {status}\n";

                if (ConfirmAction(details))
                {
                    EditInventory(id, name, quantity, price, status);
                }
            }
            else if (currentAction == ActionState.DeleteItem)
            {
                if (ConfirmAction($"Are you sure you want to delete Inventory ID: {id}?"))
                {
                    DeleteInventory(id);
                }
            }

            ClearDetails();
            ToggleTextBoxVisibility(false);
            BtnDone.Visible = false;
            BtnInventoryCancel.Visible = false;
            EnableActionButtons();
            currentAction = ActionState.None;
        }

        private void BtnInventoryCancel_Click_1(object sender, EventArgs e)
        {
            ClearDetails();
            ToggleTextBoxVisibility(false);
            BtnDone.Visible = false;
            BtnInventoryCancel.Visible = false;
            EnableActionButtons();
            currentAction = ActionState.None;
        }

        private void AddNewInventory(string id, string name, int quantity, decimal price, string status)
        {
            string query = "INSERT INTO Inventory (StockID, Name, Quantity, IndividualPrice, Status) VALUES (@StockID, @Name, @Quantity, @Price, @Status)";
            SqlParameter[] parameters = {
                new SqlParameter("@StockID", id),
                new SqlParameter("@Name", name),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Price", price),
                new SqlParameter("@Status", status)
            };

            int result = Utility.ExecuteSqlCommand(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("New inventory item added successfully.");
                LoadInventoryData();
            }
            else
            {
                MessageBox.Show("Failed to add new inventory item.");
            }
        }

        private void EditInventory(string id, string name, int quantity, decimal price, string status)
        {
            string query = "UPDATE Inventory SET Name = @Name, Quantity = @Quantity, IndividualPrice = @Price, Status = @Status WHERE StockID = @StockID";
            SqlParameter[] parameters = {
                new SqlParameter("@Name", name),
                new SqlParameter("@Quantity", quantity),
                new SqlParameter("@Price", price),
                new SqlParameter("@Status", status),
                new SqlParameter("@StockID", id)
            };

            int result = Utility.ExecuteSqlCommand(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Inventory updated successfully.");
                LoadInventoryData();
            }
            else
            {
                MessageBox.Show("No inventory updated.");
            }
        }

        private void DeleteInventory(string id)
        {
            string query = "DELETE FROM Inventory WHERE StockID = @StockID";
            SqlParameter[] parameters = { new SqlParameter("@StockID", id) };

            int result = Utility.ExecuteSqlCommand(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Inventory deleted successfully.");
                LoadInventoryData();
            }
            else
            {
                MessageBox.Show("No inventory deleted.");
            }
        }

        private bool InventoryExists(string id)
        {
            string query = "SELECT COUNT(*) FROM Inventory WHERE StockID = @StockID";
            SqlParameter[] parameters = { new SqlParameter("@StockID", id) };

            return (int)Utility.ExecuteSqlQuery(query, parameters).Rows[0][0] > 0;
        }

        private string GenerateNewID()
        {
            string query = "SELECT MAX(CAST(SUBSTRING(StockID, 4, LEN(StockID) - 3) AS INT)) FROM Inventory";
            DataTable dataTable = Utility.ExecuteSqlQuery(query, null);
            int maxID = 0;
            if (dataTable.Rows.Count > 0 && dataTable.Rows[0][0] != DBNull.Value)
            {
                maxID = Convert.ToInt32(dataTable.Rows[0][0]);
            }
            return "INV" + (maxID + 1).ToString("D3");
        }

        private bool ValidateStatus(string status, int quantity)
        {
            if (status == "Out of Stock" && quantity > 0)
            {
                MessageBox.Show("Cannot set status to 'Out of Stock' when there is a quantity.");
                return false;
            }
            return status == "Adequate" || status == "Lack of Stock" || status == "Out of Stock";
        }

        private void ToggleTextBoxVisibility(bool visible)
        {
            TBInventoryName.Visible = visible;
            numericUpDownQuantity.Visible = visible;
            numericUpDownPrice.Visible = visible;
            checkBoxAdequate.Visible = visible;
            checkBoxLack.Visible = visible;
            checkBoxOut.Visible = visible;

            LBLName.Visible = !visible;
            LBLQuantity.Visible = !visible;
            LBLPrice.Visible = !visible;
            LBLStatus.Visible = !visible;
        }

        private void ClearDetails()
        {
            LBLStockID.Text = string.Empty;
            LBLName.Text = string.Empty;
            LBLQuantity.Text = string.Empty;
            LBLPrice.Text = string.Empty;
            LBLStatus.Text = string.Empty;

            numericUpDownQuantity.Value = 0;
            numericUpDownPrice.Value = 0;
            UncheckAllCheckBoxes();
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox currentCheckBox && currentCheckBox.Checked)
            {
                foreach (CheckBox cb in new[] { checkBoxAdequate, checkBoxLack, checkBoxOut })
                {
                    if (cb != currentCheckBox)
                    {
                        cb.Checked = false;
                    }
                }
            }
        }

        private void ToggleCheckBox(string status)
        {
            UncheckAllCheckBoxes();
            if (status == "Adequate")
            {
                checkBoxAdequate.Checked = true;
            }
            else if (status == "Lack of Stock")
            {
                checkBoxLack.Checked = true;
            }
            else if (status == "Out of Stock")
            {
                checkBoxOut.Checked = true;
            }
        }

        private void UncheckAllCheckBoxes()
        {
            checkBoxAdequate.Checked = false;
            checkBoxLack.Checked = false;
            checkBoxOut.Checked = false;
        }

        private string GetSelectedStatus()
        {
            if (checkBoxAdequate.Checked) return "Adequate";
            if (checkBoxLack.Checked) return "Lack of Stock";
            if (checkBoxOut.Checked) return "Out of Stock";
            return string.Empty;
        }

        private void DisableActionButtons()
        {
            ButtonAddNewInventory.Enabled = false;
            BtnInventoryDelete.Enabled = false;
            BtnInventoryUpdate.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void EnableActionButtons()
        {
            ButtonAddNewInventory.Enabled = true;
            BtnInventoryDelete.Enabled = true;
            BtnInventoryUpdate.Enabled = true;
            dataGridView1.Enabled = true;
        }
    }
}
