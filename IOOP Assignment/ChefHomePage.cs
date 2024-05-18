using System;
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
            ChefOrderDetailsForm OD = new ChefOrderDetailsForm();
            OD.ShowDialog();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now navigating to Inventory Function Page");
            ChefInventoryForm IS = new ChefInventoryForm();
            IS.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now navigating to Chef Profile Page");
            ChefProfileForm CP = new ChefProfileForm(username);
            CP.ShowDialog();
        }

        private void LoadChefInfo(string chefId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT FullName, Gender, Role FROM Users WHERE UserID = @ChefID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChefID", chefId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label1.Text = reader["FullName"].ToString();
                            label11.Text = reader["Gender"].ToString();
                            label7.Text = reader["Role"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No chef found with the provided ID.");
                        }
                    }
                }
            }
        }

        private void LoadOrderInfo(string chefID)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;"))
            {
                conn.Open();
                string queryCompleted = "SELECT COUNT(*) FROM Orders WHERE Status = 'Completed' AND ChefID = @chefID";
                string queryUncompleted = "SELECT COUNT(*) FROM Orders WHERE Status = 'Uncompleted' AND ChefID = @chefID";
                string queryPending = "SELECT COUNT(*) FROM Orders WHERE Status = 'Pending' AND ChefID = @chefID";

                using (SqlCommand cmdCompleted = new SqlCommand(queryCompleted, conn))
                {
                    cmdCompleted.Parameters.AddWithValue("@chefID", chefID);
                    label12.Text = cmdCompleted.ExecuteScalar().ToString();
                }

                using (SqlCommand cmdUncompleted = new SqlCommand(queryUncompleted, conn))
                {
                    cmdUncompleted.Parameters.AddWithValue("@chefID", chefID);
                    label13.Text = cmdUncompleted.ExecuteScalar().ToString();
                }

                using (SqlCommand cmdPending = new SqlCommand(queryPending, conn))
                {
                    cmdPending.Parameters.AddWithValue("@chefID", chefID);
                    label14.Text = cmdPending.ExecuteScalar().ToString();
                }
            }
        }
    }
}
