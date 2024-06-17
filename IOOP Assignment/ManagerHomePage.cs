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
using System.IO;

namespace IOOP_Assignment
{
    public partial class ManagerHomePage : Form
    {
        public ManagerHomePage()
        {
            InitializeComponent();
            Manager manager = new Manager();  
            byte[] profileImage = manager.GetManagerProfileImage();

            if (profileImage != null)
            {
                using (MemoryStream memoryStream = new MemoryStream(profileImage))
                {
                    picManager.Image = Image.FromStream(memoryStream);
                }
            }
            else
            {
                picManager.Image = Properties.Resources.userIcon; 
            }
        }

        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";


        private void picManager_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerViewProfilePage profilePage = new ManagerViewProfilePage();
            profilePage.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMenuPage frmMenu = new ManagerMenuPage();
            frmMenu.ShowDialog();
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerTablesPage frmTables = new ManagerTablesPage();
            frmTables.ShowDialog();
        }

        private void btnResvReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerReservationReportPage frmReport = new ManagerReservationReportPage();
            frmReport.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            string userID;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT UserID FROM Users WHERE Role = 'MANAGER' AND LoggedIn = 'TRUE'";
                SqlCommand selectCmd = new SqlCommand(selectQuery, con);
                userID = (string)selectCmd.ExecuteScalar();

                if (userID != null)
                {
                    string updateQuery = "UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = @UserID";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@UserID", userID);

                    updateCmd.ExecuteNonQuery();
                }
            }
            this.Hide();

            loginForm frmLogin = new loginForm();
            frmLogin.ShowDialog();
        }
    }
}

