using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class AdminUpdateProfile : Form
    {
        private string connectionString;
        public AdminUpdateProfile()
        {
            InitializeComponent();
            connectionString = "";
            Database database = new Database(connectionString);
            string query = "Select UserID from Users where LoggedIn = 'True';";
            string userID = database.getString(query);
            lblUserID.Text = userID;

            query = $"Select fullName From Users where UserID = '{userID} ';";
            txtFullName.Text = database.getString(query);

            query = $"Select Password from Users where UserID = '{userID} ';";
            txtPassword.Text = database.getString(query);

            query = $"Select Birthday from Users where UserID = '{userID}';";
            dtpBirthday.Text = database.getDateTime(query).ToString();

            query = $"Select Gender from Users where UserID = '{userID}';";
            string gender = database.getString(query);
            if (gender == "Male")
            {
                rdbMale.Checked = true;
            }
            else if (gender == "Female")
            {
                rdbFemale.Checked = true;
            }
            else
            {
                rdbMale.Checked = false;
                rdbFemale.Checked = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query;
            Database database = new Database(connectionString);
            query = "Select UserID from Users where LoggedIn = 'True';";
            string userID = database.getString(query);
            string FullName = txtFullName.Text;
            string Password = txtPassword.Text;
            string Birthday = dtpBirthday.Text;
            string Gender = rdbMale.Checked ? "Male" : rdbFemale.Checked ? "Female" : "";

            byte[] Image = null;
            if (pboxAdmin.Image != null)
            {
                Image = ConvertImageToByteArray(pboxAdmin.Image);
            }

            query = $"Update Users Set fullName= @fn, Password = @pw, Birthday = @birthday, Gender = @gender, Image= @profile where UserID =@userID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fn", FullName);
                cmd.Parameters.AddWithValue("@pw", Password);
                cmd.Parameters.AddWithValue("@birthday", Birthday);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@profile", Image);
                cmd.Parameters.AddWithValue("@userID", userID);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Admin Profile Update Successfully.");

                }
                else
                {
                    MessageBox.Show("Failed to Update Admin Profile.");
                }

            }
        }
        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pboxAdmin.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Hide();
            hp.Show();
        }
    }
}
