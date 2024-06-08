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
    public partial class ManagerAddPlace : Form
    {
        public ManagerAddPlace()
        {
            InitializeComponent();            
        }

        private string imgLocation;

        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private Manager manager = new Manager();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] images = manager.LoadImage(imgLocation);


                SqlConnection con = new SqlConnection(connectionString);
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO Menu (ProductID, Name, Description, Price, Cuisine, ProductImage) VALUES (@ProductID, @Name, @Description, @Price, @Cuisine, @ProductImage)", con);
                cmd.Parameters.AddWithValue("@ProductID", txtPlaceID.Text);
                cmd.Parameters.AddWithValue("@Name", txtPlaceName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
                cmd.Parameters.AddWithValue("@Price", txtPax.Text);
                cmd.Parameters.AddWithValue("@ProductImage", images);
                cmd.Parameters.AddWithValue("@Cuisine", eventTypeCBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Table Added Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files( *. png)| *. png| jpg files( *. jpg)| *. jpg| All files( *.* )| *.* ";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picPlace.ImageLocation = imgLocation;
            }
        }
    }
}

