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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP
{
    public partial class ManagerHomePage : Form
    {
        public ManagerHomePage()
        {
            InitializeComponent();
        }
        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";

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
            /*SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand selectUserCmd = new SqlCommand("SELECT UserID FROM Users WHERE LoggedIn = 'TRUE')", con);
            selectUserCmd.Parameters.AddWithValue("@UserID", userID);
            selectUserCmd.ExecuteNonQuery();

            SqlCommand updateUserCmd = new SqlCommand("UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = (SELECT UserID FROM Users WHERE LoggedIn = 'TRUE')", con);
            updateUserCmd.Parameters.AddWithValue("@UserID", userID);
            updateUserCmd.ExecuteNonQuery();
            this.Hide();
            loginForm frmLogin = loginForm();
            frmLogin.ShowDialog();*/


            // Use 'using' to ensure the connection is properly disposed of
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                // Open the connection
                con.Open();

                // Create the SQL command to update the LoggedIn status
                string query = "UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = (SELECT UserID FROM Users WHERE LoggedIn = 'TRUE')";
                SqlCommand updateUserCmd = new SqlCommand(query, con);

                // Execute the command
                updateUserCmd.ExecuteNonQuery();
            }

            // Hide the current form
            this.Hide();

            // Show the login form
            //loginForm frmLogin = new loginForm();
           // frmLogin.ShowDialog();

        }
    }
}
