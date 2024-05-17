using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ChefHomePage : Form
    {
        bool sidebarExpand;
        public ChefHomePage()
        {
            InitializeComponent();
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
            MessageBox.Show($"Now navigating to Order Details Function Page");
            ChefOrderDetailsForm OD = new ChefOrderDetailsForm();
            OD.ShowDialog();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Now navigating to Inventory Function Page");
            ChefInventoryForm IS = new ChefInventoryForm ();
            IS.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Now navigating to Chef Profile Page");
            ChefProfileForm CP = new ChefProfileForm();
            CP.ShowDialog();
        }

        private void LoadChefInfo(int chefId)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;"))
            {
                conn.Open();
                string query = "SELECT Name, Age, Gender FROM Chef WHERE ChefID = @ChefID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ChefID", chefId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            label1.Text = reader["Name"].ToString();
                            label11.Text = reader["Age"].ToString();
                            label7.Text = reader["Gender"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No chef found with the provided ID.");
                        }
                    }
                }
            }
        }
        private void LoadOrderInfo()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-DJK50SEM;Initial Catalog=IOOPDatabase;Integrated Security=True;"))
            {
                conn.Open();
                string queryCompleted = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Completed'";
                string queryUncompleted = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'Uncompleted'";

                using (SqlCommand cmdCompleted = new SqlCommand(queryCompleted, conn))
                {
                    label12.Text = cmdCompleted.ExecuteScalar().ToString();
                }

                using (SqlCommand cmdUncompleted = new SqlCommand(queryUncompleted, conn))
                {
                    label13.Text = cmdUncompleted.ExecuteScalar().ToString();
                }
            }
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtChefID.Text, out int chefId))
            {
                LoadChefInfo(chefId);
            }
            else
            {
                MessageBox.Show("Please enter a valid ChefID.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    

    

}
