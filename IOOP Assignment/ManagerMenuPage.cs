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
    public partial class ManagerMenuPage : Form
    {
        private string imgLocation;

        public ManagerMenuPage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
        private Manager manager = new Manager();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void ManagerMenuPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ProductID, Name, Description, Price, Cuisine, ProductImage FROM Menu", con);
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

        private void txtSearchProduct_Enter(object sender, EventArgs e)
        {
            if (txtSearchProduct.Text == "Search...")
            {
                txtSearchProduct.Text = "";
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Menu WHERE ProductID LIKE @SearchInput OR Name LIKE @SearchInput OR Description LIKE @SearchInput OR Cuisine LIKE @SearchInput", con);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
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
                byte[] images = manager.LoadImage(imgLocation);
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Menu (ProductID, Name, Description, Price, Cuisine, ProductImage) VALUES (@ProductID, @Name, @Description, @Price, @Cuisine, @ProductImage)", con);
                cmd.Parameters.AddWithValue("@ProductID", productID);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
                cmd.Parameters.AddWithValue("@ProductImage", images);
                cmd.ExecuteNonQuery();

                RefreshDataGridView();


                con.Close();

                MessageBox.Show("Product Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMenu.SelectedRows.Count > 0)
                {
                    string productIdToDelete = dataGridViewMenu.SelectedRows[0].Cells["ProductID"].Value.ToString();

                    SqlConnection con = new SqlConnection(connetionString);
                    con.Open();
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

        private void dataGridViewMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];
                // Enable editing for Name, Description, Price, and Cuisine textboxes
                //txtProductID.Enabled = false;
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
    }
}
