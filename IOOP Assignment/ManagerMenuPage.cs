using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ManagerMenuPage : Form
    {
        public ManagerMenuPage()
        {
            InitializeComponent();
        }

        private string imgLocation;

        public string connetionString = "";
        private Manager manager = new Manager();
        private void Menu_Load(object sender, EventArgs e)
        {
            lblProID.Visible = false;
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ProductID, Name, Description, Price, Cuisine, Chosen, ProductImage FROM Menu", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewMenu.DataSource = dt;
                    }
                }
            }
        }

        private void RefreshDataGridView()
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewMenu.DataSource = dt;
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void ShowMenuForm()
        {
            lblProID.Visible = true;
            lblProDesc.Visible = true;
            lblCuisine.Visible = true;
            lblProPrice.Visible = true;
            lblName.Visible = true;
            picMenu.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            btnUpload.Visible = true;
            txtProductDesc.Visible = true;
            txtProductPrice.Visible = true;
            txtProductName.Visible = true;
            cbbCuisine.Visible = true;
        }

        private void ClearSearchAndRefreshDataGridView()
        {
            txtSearchProduct.Text = ""; // Clear the search textbox
            RefreshDataGridView(); // Refresh the DataGridView to show all records
        }

        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "Search...")
            {
                txtSearchProduct.Text = "";
                ClearSearchAndRefreshDataGridView();
            }
        }

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchProduct.Text))
            {
                txtSearchProduct.Text = "Search...";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = txtSearchProduct.Text.Trim();
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Menu WHERE ProductID LIKE @SearchInput OR Name LIKE @SearchInput OR Description LIKE @SearchInput OR Cuisine LIKE @SearchInput OR Chosen LIKE @SearchInput", con))
                    {
                        cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewMenu.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picMenu.ImageLocation = imgLocation;
            }
        }

        private bool IsProductNameExists(string productName)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Menu WHERE Name = @ProductName", con))
                {
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                lblProID.Visible = true;
                string productID = lblProID.Text.Replace("ProductID: ", "");
                byte[] images = manager.LoadImage(imgLocation);
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name=@Name, Description=@Description, Price=@Price, Cuisine=@Cuisine, ProductImage=@ProductImage WHERE ProductID=@ProductID", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                        cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
                        cmd.Parameters.AddWithValue("@ProductImage", images);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Refresh the DataGridView
                            RefreshDataGridView();

                            MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check the selected product ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowMenuForm();
                DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];
                // Enable editing for Name, Description, Price, and Cuisine textboxes
                txtProductName.Enabled = true;
                txtProductDesc.Enabled = true;
                txtProductPrice.Enabled = true;
                cbbCuisine.Enabled = true;
                picMenu.Enabled = true;

                if (string.IsNullOrEmpty(Convert.ToString(row.Cells["ProductID"].Value)))
                {
                    lblProID.Text = "";
                    // Clear other textboxes
                    txtProductName.Text = "";
                    txtProductDesc.Text = "";
                    txtProductPrice.Text = "";
                    cbbCuisine.Text = "";
                    // Clear picMenu
                    picMenu.Image = null;
                }
                else
                {
                    lblProID.Text = "ProductID: " + row.Cells["ProductID"].Value.ToString();
                    txtProductName.Text = row.Cells["Name"].Value.ToString();
                    txtProductDesc.Text = row.Cells["Description"].Value.ToString();
                    txtProductPrice.Text = row.Cells["Price"].Value.ToString();
                    cbbCuisine.Text = row.Cells["Cuisine"].Value.ToString();
                    /*picMenu.Image = Properties.Resources.FoodIcon;

                    if (row.Cells["Image"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])row.Cells["Image"].Value;
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            picMenu.Image = Image.FromStream(memoryStream);
                        }
                    }*/
                }
            }
        }

        private bool TestDatabaseConnection()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection test failed: {ex.Message}", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TestDatabaseConnection())
            {
                return; // Exit if the connection test fails
            }
            try
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtProductDesc.Text) ||
                    string.IsNullOrWhiteSpace(txtProductPrice.Text) ||
                    string.IsNullOrWhiteSpace(cbbCuisine.Text))
                {
                    MessageBox.Show("Please fill in all data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the product name already exists
                if (IsProductNameExists(txtProductName.Text.ToUpper()))
                {
                    MessageBox.Show("Product name already exists. Please choose a different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string productID = manager.GenerateProductID();
                string recipeID = manager.GenerateRecipeID();
                byte[] images = manager.LoadImage(imgLocation);

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();

                    // Check if the RecipeID exists in the Recipe table
                    SqlCommand checkRecipeCmd = new SqlCommand("SELECT COUNT(*) FROM RecipeStock WHERE RecipeID = @RecipeID", con);
                    checkRecipeCmd.Parameters.AddWithValue("@RecipeID", recipeID);
                    int recipeCount = (int)checkRecipeCmd.ExecuteScalar();

                    if (recipeCount == 0)
                    {
                        SqlCommand insertRecipeCmd = new SqlCommand("INSERT INTO RecipeStock (RecipeID) VALUES (@RecipeID)", con);
                        insertRecipeCmd.Parameters.AddWithValue("@RecipeID", recipeID);
                        insertRecipeCmd.Parameters.AddWithValue("@ProductID", productID);
                        insertRecipeCmd.ExecuteNonQuery();
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Menu (ProductID, Name, Description, Price, Cuisine, ProductImage) VALUES (@ProductID, @Name, @Description, @Price, @Cuisine, @ProductImage)", con);
                    cmd.Parameters.AddWithValue("@ProductID", productID);
                    cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                    cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
                    cmd.Parameters.AddWithValue("@ProductImage", images);
                    cmd.ExecuteNonQuery();

                    SqlCommand updateCmd = new SqlCommand("UPDATE RecipeStock SET ProductID = @ProductID WHERE RecipeID = @RecipeID", con);
                    updateCmd.Parameters.AddWithValue("@ProductID", productID);
                    updateCmd.Parameters.AddWithValue("@RecipeID", recipeID);
                    updateCmd.ExecuteNonQuery();
                }

                RefreshDataGridView();
                MessageBox.Show("Product Added Successfully!");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"A SQL error occurred: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMenu.SelectedRows.Count > 0)
                {
                    string productIdToDelete = dataGridViewMenu.SelectedRows[0].Cells["ProductID"].Value.ToString();

                    using (SqlConnection con = new SqlConnection(connetionString))
                    {
                        con.Open();

                        using (SqlCommand deleteRecipeCmd = new SqlCommand("DELETE FROM RecipeStock WHERE ProductID = @ProductID", con))
                        {
                            deleteRecipeCmd.Parameters.AddWithValue("@ProductID", productIdToDelete);
                            deleteRecipeCmd.ExecuteNonQuery();
                        }

                        using (SqlCommand deleteProductCmd = new SqlCommand("DELETE FROM Menu WHERE ProductID = @ProductID", con))
                        {
                            deleteProductCmd.Parameters.AddWithValue("@ProductID", productIdToDelete);

                            int rowsAffected = deleteProductCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Refresh the DataGridView to reflect the changes
                                RefreshDataGridView();

                                // Clear the textboxes and other UI elements
                                lblProID.Text = "";
                                txtProductName.Text = "";
                                txtProductDesc.Text = "";
                                txtProductPrice.Text = "";
                                cbbCuisine.Text = "";
                                picMenu.Image = null;

                                MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"{productIdToDelete}");
                                MessageBox.Show("No rows were deleted. Please check the selected product ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                lblProID.Visible = true;
                string productID = lblProID.Text.Replace("ProductID: ", "");
                byte[] images = manager.LoadImage(imgLocation);
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name=@Name, Description=@Description, Price=@Price, Cuisine=@Cuisine, ProductImage=@ProductImage WHERE ProductID=@ProductID", con))
                    {
                        cmd.Parameters.AddWithValue("@ProductID", productID);
                        cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
                        cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
                        cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                        cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
                        cmd.Parameters.AddWithValue("@ProductImage", images);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Refresh the DataGridView
                            RefreshDataGridView();

                            MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblProID.Text = "";
                            txtProductName.Text = "";
                            txtProductDesc.Text = "";
                            txtProductPrice.Text = "";
                            cbbCuisine.Text = "";
                            picMenu.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please check the selected product ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
