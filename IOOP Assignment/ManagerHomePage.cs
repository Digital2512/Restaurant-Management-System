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
    public partial class ManagerHomePage : Form
    {
        public ManagerHomePage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

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
            this.Visible = false;
            loginForm loginForm = new loginForm();
            loginForm.Visible = true;
            Database database = new Database(connetionString);
            string query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = database.getString(query);
            query = $"UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            database.insertOrUpdateValuesIntoDatabase(query);
            query = $"UPDATE Customer SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            database.insertOrUpdateValuesIntoDatabase(query);

        }
    }
}

