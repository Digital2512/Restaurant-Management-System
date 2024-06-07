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

        public string connetionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private Manager manager = new Manager();
        private void Menu_Load(object sender, EventArgs e)
        {
            lblProID.Visible = false;
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductID, Name, Description, Price, Cuisine, Chosen, ProductImage FROM Menu", con);
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridViewMenu.DataSource = dt;
                    }
                }
                con.Close();
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



        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "Search...")
            {
                txtSearchProduct.Text = "";
                RefreshDataGridView();
            }
        }

        private void txtSearchProduct_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchProduct.Text))
            {
                txtSearchProduct.Text = "Search...";
                RefreshDataGridView();
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
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Menu WHERE ProductID LIKE @SearchInput OR Name LIKE @SearchInput OR Description LIKE @SearchInput OR Cuisine LIKE @SearchInput OR Chosen LIKE @SearchInput", con);
                    {
                        cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dataGridViewMenu.DataSource = dt;
                        }
                    }
                    con.Close();
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
                    picMenu.Image = Properties.Resources.FoodIcon;
                }
                else
                {
                    lblProID.Text = "ProductID: " + row.Cells["ProductID"].Value.ToString();
                    txtProductName.Text = row.Cells["Name"].Value.ToString();
                    txtProductDesc.Text = row.Cells["Description"].Value.ToString();
                    txtProductPrice.Text = row.Cells["Price"].Value.ToString();
                    cbbCuisine.Text = row.Cells["Cuisine"].Value.ToString();
                    picMenu.Image = Properties.Resources.FoodIcon;

                    if (row.Cells["ProductImage"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])row.Cells["ProductImage"].Value;
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            picMenu.Image = Image.FromStream(memoryStream);
                        }
                    }
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

                manager.AddProduct(productID, txtProductName.Text, txtProductDesc.Text, decimal.Parse(txtProductPrice.Text), cbbCuisine.Text, images, recipeID);

                RefreshDataGridView();

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

                    manager.DeleteProduct(productIdToDelete);

                    // Refresh the DataGridView to reflect the changes
                    RefreshDataGridView();

                    // Clear the textboxes and other UI elements
                    lblProID.Text = "";
                    txtProductName.Text = "";
                    txtProductDesc.Text = "";
                    txtProductPrice.Text = "";
                    cbbCuisine.Text = "";
                    picMenu.Image = Properties.Resources.FoodIcon;

                    MessageBox.Show("Product Deleted Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


                manager.UpdateProduct(productID, txtProductName.Text, txtProductDesc.Text, decimal.Parse(txtProductPrice.Text), cbbCuisine.Text, images);
                // Refresh the DataGridView
                RefreshDataGridView();
                HideMenuForm();
                MessageBox.Show("Product Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
