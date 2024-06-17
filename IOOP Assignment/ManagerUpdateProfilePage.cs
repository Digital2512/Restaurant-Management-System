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

        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
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

                if (row["Birthday"] != DBNull.Value)
                {
                    DateTime birthday = Convert.ToDateTime(row["Birthday"]);
                    pickerDOB.Value = birthday;
                }
                else
                {
                    pickerDOB.Value = DateTime.Today;
                }

                if (row["ProfileImage"] != DBNull.Value)
                {
                    byte[] imgData = (byte[])row["ProfileImage"];
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        picManager.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picManager.Image = null; 
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

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Users SET Password=@Password", con);

                    cmd.Parameters.AddWithValue("@Password", txtPsw.Text);

                    if (!string.IsNullOrEmpty(txtName.Text))
                    {
                        cmd.CommandText += ", FullName=@FullName";
                        cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    }

                    if (!string.IsNullOrEmpty(cbbGender.Text))
                    {
                        cmd.CommandText += ", Gender=@Gender";
                        cmd.Parameters.AddWithValue("@Gender", cbbGender.Text);
                    }

                    cmd.CommandText += ", Birthday=@Birthday";
                    cmd.Parameters.AddWithValue("@Birthday", pickerDOB.Value);

                    if (images != null)
                    {
                        cmd.CommandText += ", ProfileImage=@ProfileImage";
                        cmd.Parameters.AddWithValue("@ProfileImage", images);
                    }

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