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
    public partial class ManageUpdateProfilePage : Form
    {
        public ManageUpdateProfilePage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Users SET Name=@FullName, Password=@Password, Gender=@Gender, Birthday=@Birthday WHERE UserID=@UserID", con);

                cmd.Parameters.AddWithValue("@UserID", textBox1.Text);
                cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPsw.Text);
                cmd.Parameters.AddWithValue("@Gender", cbbGender.Text);
                cmd.Parameters.AddWithValue("@Birthday", pickerDOB.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Profile Updated Successfully");

                this.Close();
                ManagerViewProfilePage frmViewProfile = new ManagerViewProfilePage();
                frmViewProfile.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

