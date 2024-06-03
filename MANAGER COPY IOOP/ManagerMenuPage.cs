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

namespace MANAGER_COPY_IOOP
{
    public partial class ManagerMenuPage : Form
    {
        public ManagerMenuPage()
        {
            InitializeComponent();
        }

        private string imgLocation;

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
        private Manager manager = new Manager();
        private void Menu_Load(object sender, EventArgs e)
        {
            lblProID.Visible = false;
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ProductID, Name, Description, Price, Cuisine, RecipeID, ProductImage FROM Menu", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMenu.DataSource = dt;

        }

        private void RefreshDataGridView()
        {
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Menu", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewMenu.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();

        }

        private void HideMenuForm()
        {
            lblProID.Visible = false;
            lblProDesc.Visible = false;
            lblCuisine.Visible = false;
            lblProPrice.Visible = false;
            lblName.Visible = false;
            picMenu.Visible = false;
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnUpload.Visible = false;
            txtProductDesc.Visible = false;
            txtProductPrice.Visible = false;
            txtProductName.Visible = false;
            cbbCuisine.Visible = false;

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
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Menu WHERE ProductID LIKE @SearchInput OR Name LIKE @SearchInput OR Description LIKE @SearchInput OR Cuisine LIKE @SearchInput OR RecipeID LIKE @SearchInput", con);
                cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewMenu.DataSource = dt;


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files( *. png)| *. png| jpg files( *. jpg)| *. jpg| All files( *.* )| *.* ";

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
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Menu WHERE Name = @ProductName", con);
                cmd.Parameters.AddWithValue("@ProductName", productName);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                lblProID.Visible = true;
                string productID = lblProID.Text.Replace("ProductID: ", "");
                byte[] images = manager.LoadImage(imgLocation);
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name=@Name, Description=@Description, Price=@Price, Cuisine=@Cuisine, ProductImage=@ProductImage WHERE ProductID=@ProductID", con);
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
                    //picMenu.Image = Properties.Resources.FoodIcon;

                    /*if (row.Cells["Image"].Value != DBNull.Value)
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


        private void btnAdd_Click(object sender, EventArgs e)
        {
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


                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                // Check if the RecipeID exists in the Recipe table
                SqlCommand checkRecipeCmd = new SqlCommand("SELECT COUNT(*) FROM Recipe WHERE RecipeID = @RecipeID", con);
                checkRecipeCmd.Parameters.AddWithValue("@RecipeID", recipeID);
                int recipeCount = (int)checkRecipeCmd.ExecuteScalar();

                // If the RecipeID does not exist, insert a new record into the Recipe table
                if (recipeCount == 0)
                {
                    SqlCommand insertRecipeCmd = new SqlCommand("INSERT INTO Recipe (RecipeID) VALUES (@RecipeID)", con);
                    insertRecipeCmd.Parameters.AddWithValue("@RecipeID", recipeID);
                    insertRecipeCmd.ExecuteNonQuery();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Menu (ProductID, Name, Description, Price, Cuisine, RecipeID, ProductImage) VALUES (@ProductID, @Name, @Description, @Price, @Cuisine, @RecipeID, @ProductImage)", con);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
                cmd.Parameters.AddWithValue("@RecipeID", recipeID);
                cmd.Parameters.AddWithValue("@ProductImage", images);
                cmd.ExecuteNonQuery();

                SqlCommand updateCmd = new SqlCommand("UPDATE Recipe SET ProductID = @ProductID, RecipeID = @RecipeID", con);
                updateCmd.Parameters.AddWithValue("@ProductID", productID);
                updateCmd.Parameters.AddWithValue("@RecipeID", recipeID);
                updateCmd.ExecuteNonQuery();

                RefreshDataGridView();


                con.Close();

                MessageBox.Show("Product Added Successfully!");
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
                    string recipeIdToDelete = dataGridViewMenu.SelectedRows[0].Cells["RecipeID"].Value.ToString();

                    SqlConnection con = new SqlConnection(connetionString);
                    con.Open();

                    SqlCommand updateCmd = new SqlCommand("DELETE FROM Recipe WHERE RecipeID = @RecipeID", con);
                    updateCmd.Parameters.AddWithValue("@RecipeID", recipeIdToDelete);
                    updateCmd.ExecuteNonQuery();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Menu WHERE ProductID = @ProductID", con);
                    cmd.Parameters.AddWithValue("@ProductID", productIdToDelete); // Use the retrieved value



                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Refresh the DataGridView
                        RefreshDataGridView();
                        // Clear other textboxes
                        lblProID.Text = "";
                        txtProductName.Text = "";
                        txtProductDesc.Text = "";
                        txtProductPrice.Text = "";
                        cbbCuisine.Text = "";
                        // Clear picMenu
                        picMenu.Image = null;
                        MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows were deleted. Please check the selected product ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name=@Name, Description=@Description, Price=@Price, Cuisine=@Cuisine, ProductImage=@ProductImage WHERE ProductID=@ProductID", con);
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

