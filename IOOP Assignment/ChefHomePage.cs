using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefHomePage : Form
    {
        bool sidebarExpand;
        private string username;

        public ChefHomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadChefInfo(username);
            LoadOrderInfo(username);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonViewOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now navigating to Order Details Function Page");
            Utility.OpenForm(this, new ChefOrderDetailsForm(username));
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now navigating to Inventory Function Page");
            Utility.OpenForm(this, new ChefInventoryForm());
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now navigating to Chef Profile Page");
            Utility.OpenForm(this, new ChefProfileForm(username));
        }

        private void LoadChefInfo(string chefId)
        {
            string query = "SELECT FullName, Gender, Role FROM Users WHERE UserID = @ChefID";
            SqlParameter[] parameters = { new SqlParameter("@ChefID", chefId) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                label1.Text = row["FullName"].ToString();
                label11.Text = row["Gender"].ToString();
                label7.Text = row["Role"].ToString();
            }
            else
            {
                MessageBox.Show("No chef found with the provided ID.");
            }
        }

        private void LoadOrderInfo(string chefID)
        {
            string queryCompleted = "SELECT count(*) FROM Orders WHERE Status = 'Completed' AND ChefID = @chefID";
            string queryUncompleted = "SELECT COUNT(*) FROM Orders WHERE Status = 'In Progress' AND ChefID = @chefID";
            string queryPending = "SELECT COUNT(*) FROM Orders WHERE Status = 'Pending'";

            SqlParameter[] parameters = { new SqlParameter("@chefID", chefID) };

            label12.Text = Utility.ExecuteSqlQuery(queryCompleted, parameters).Rows[0][0].ToString();
            label13.Text = Utility.ExecuteSqlQuery(queryUncompleted, parameters).Rows[0][0].ToString();
            label14.Text = Utility.ExecuteSqlQuery(queryPending, parameters).Rows[0][0].ToString();
        }
    }
}
