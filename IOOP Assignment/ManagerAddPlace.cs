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

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
        private Manager manager = new Manager();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                byte[] images = manager.LoadImage(imgLocation);


                SqlConnection con = new SqlConnection(connetionString);
                con.Open();


                SqlCommand cmd = new SqlCommand("INSERT INTO PlaceOfReservation (PlaceID, PlaceName, Description, EventType, MinOfPax, PlaceImage) VALUES (@PlaceID, @PlaceName, @Description, @EventType, @MinOfPax, @PlaceImage)", con);
                cmd.Parameters.AddWithValue("@PlaceID", txtPlaceID.Text);
                cmd.Parameters.AddWithValue("@PlaceName", txtPlaceName.Text);
                cmd.Parameters.AddWithValue("@Description", txtDesc.Text);
                cmd.Parameters.AddWithValue("@EventType", txtEventType.Text);
                cmd.Parameters.AddWithValue("@MinOfPax", txtPax.Text);
                cmd.Parameters.AddWithValue("@PlaceImage", images);
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

