using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGER_COPY_IOOP
{
    public partial class ManagerViewProfilePage : Form
    {
        public ManagerViewProfilePage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
        private Manager manager = new Manager();
        private string imgLocation;

        private void ManagerViewProfilePage_Load(object sender, EventArgs e)
        {
            DataTable dt = manager.GetManagerProfile();

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lblUserID.Text = "User ID: " + row["UserID"].ToString();
                lblPsw.Text = "Password: " + row["Password"].ToString();
                lblRole.Text = "Role: " + row["Role"].ToString();
                lblName.Text = "Name: " + row["FullName"].ToString();
                lblGender.Text = "Gender: " + row["Gender"].ToString();

                // Retrieve the birthday as a DateTime and format it
                DateTime birthday = Convert.ToDateTime(row["Birthday"]);
                lblBirthday.Text = "Birthday: " + birthday.ToString("yyyy-MM-dd");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerUpdateProfilePage frmUpdatePro = new ManagerUpdateProfilePage();
            frmUpdatePro.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }
    }
}

