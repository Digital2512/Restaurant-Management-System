using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using System.Xml.Linq;
using System.IO;

namespace IOOP_Assignment
{
    public partial class ManagerMenuPage : Form
    {
        public ManagerMenuPage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";
       
        
        private void ManagerMenuPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ProductID, Name, Description, Price, Cuisine, Ratings, Image FROM Menu", con);
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);

            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Menu (ProductID, Name, Description, Price, Cuisine, Image) VALUES (@ProductID, @Name, @Description, @Price, @Cuisine, @Image)", con);
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
            cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
            cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
            cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
            cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
            cmd.Parameters.AddWithValue("@Image", images);
            cmd.ExecuteNonQuery();

            RefreshDataGridView();


            con.Close();

            MessageBox.Show("Product Added Successfully!");

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerHomePage frmMngHome = new ManagerHomePage();
            frmMngHome.ShowDialog();
        }

        private void dataGridViewMenu_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMenu.Rows[e.RowIndex];
                // Enable editing for Name, Description, Price, and Cuisine textboxes
                txtProductID.Enabled = false;
                txtProductName.Enabled = true;
                txtProductDesc.Enabled = true;
                txtProductPrice.Enabled = true;
                cbbCuisine.Enabled = true;
                picMenu.Enabled = true;

                if (string.IsNullOrEmpty(Convert.ToString(row.Cells["ProductID"].Value)))
                {
                    // Enable ProductID textbox if it's empty
                    txtProductID.Enabled = true;
                    txtProductID.Text = "";
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
                    txtProductID.Text = row.Cells["ProductID"].Value.ToString();
                    txtProductName.Text = row.Cells["Name"].Value.ToString();
                    txtProductDesc.Text = row.Cells["Description"].Value.ToString();
                    txtProductPrice.Text = row.Cells["Price"].Value.ToString();
                    cbbCuisine.Text = row.Cells["Cuisine"].Value.ToString();
                    picMenu.Image = Properties.Resources.FoodIcon;

                    if (row.Cells["Image"].Value != DBNull.Value)
                    {
                        byte[] imageData = (byte[])row.Cells["Image"].Value;
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            picMenu.Image = Image.FromStream(memoryStream);
                        }
                    }
                }


            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            images = br.ReadBytes((int)stream.Length);

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Menu SET Name=@Name, Description=@Description, Price=@Price, Cuisine=@Cuisine, Image=@Image WHERE ProductID=@ProductID", con);
                cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                cmd.Parameters.AddWithValue("@Name", txtProductName.Text.ToUpper());
                cmd.Parameters.AddWithValue("@Description", txtProductDesc.Text);
                cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtProductPrice.Text));
                cmd.Parameters.AddWithValue("@Cuisine", cbbCuisine.Text);
                cmd.Parameters.AddWithValue("@Image", images);
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

                // Disable editing for ProductID textbox after update
                txtProductID.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        string imgLocation = "";
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

       
       
    }
}
