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

namespace IOOP_Assignment
{
    public partial class ManagerViewProfilePage : Form
    {
        public ManagerViewProfilePage()
        {
            InitializeComponent();
        }

        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
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


                if (row["Birthday"] != DBNull.Value)
                {
                    DateTime birthday = Convert.ToDateTime(row["Birthday"]);
                    lblBirthday.Text = "Birthday: " + birthday.ToString("yyyy-MM-dd");
                }
                else
                {
                    lblBirthday.Text = "Birthday: ";
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

