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
    public partial class ManagerUpdateProfilePage : Form
    {
        public ManagerUpdateProfilePage()
        {
            InitializeComponent();
            pickerDOB.Format = DateTimePickerFormat.Custom;
            pickerDOB.CustomFormat = "dd-MM-yyyy";
        }

        public string connetionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private Manager manager = new Manager();
        private string imgLocation;

        private void ManagerUpdateProfilePage_Load(object sender, EventArgs e)
        {
            DataTable dt = manager.GetManagerProfile();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblUserID.Text = "User ID: " + row["UserID"].ToString();
                txtPsw.Text = row["Password"].ToString();
                lblRole.Text = "Role: " + row["Role"].ToString();
                txtName.Text = row["FullName"].ToString();
                cbbGender.Text = row["Gender"].ToString();

                // Retrieve the birthday as a DateTime and format it
                DateTime birthday = Convert.ToDateTime(row["Birthday"]);
                pickerDOB.Value = birthday;

                // Check if ProfileImage column contains data
                if (row["ProfileImage"] != DBNull.Value)
                {
                    // Convert byte array to image
                    byte[] imgData = (byte[])row["ProfileImage"];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        picManager.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Display a placeholder image or handle the absence of image
                    picManager.Image = null; // or assign a placeholder image
                }

            }
            else
            {
                MessageBox.Show("No data found.");
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " png files( *. png)| *. png| jpg files( *. jpg)| *. jpg| All files( *.* )| *.* ";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                picManager.ImageLocation = imgLocation;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;

                if (!string.IsNullOrEmpty(imgLocation))
                {
                    images = manager.LoadImage(imgLocation);
                }

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Password=@Password", con);

                    // Add other parameters
                    cmd.Parameters.AddWithValue("@Password", txtPsw.Text);

                    // Add FullName parameter if not null or empty
                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        cmd.CommandText += ", FullName=@FullName";
                        cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    }

                    // Add Gender parameter if not null or empty
                    if (!string.IsNullOrEmpty(cbbGender.Text))
                    {
                        cmd.CommandText += ", Gender=@Gender";
                        cmd.Parameters.AddWithValue("@Gender", cbbGender.Text);
                    }

                    // Add Birthday parameter
                    cmd.CommandText += ", Birthday=@Birthday";
                    cmd.Parameters.AddWithValue("@Birthday", pickerDOB.Value);

                    // Add ProfileImage parameter only if an image is selected
                    if (images != null)
                    {
                        cmd.CommandText += ", ProfileImage=@ProfileImage";
                        cmd.Parameters.AddWithValue("@ProfileImage", images);
                    }

                    // Add WHERE clause
                    cmd.CommandText += " WHERE Role = 'Manager' and Loggedin = 'TRUE'";

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ManagerViewProfilePage frmProfile = new ManagerViewProfilePage();
                        frmProfile.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerViewProfilePage frmProfile = new ManagerViewProfilePage();
            frmProfile.ShowDialog();
        }
    }
}