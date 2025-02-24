﻿using System;
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
            loginForm loginForm = new loginForm();
            this.Visible = false;
            loginForm.Show();
            string query = "SELECT UserID FROM Users WHERE LoggedIn = 'TRUE';";
            string userID = Utility.ExecuteSqlQuery(query, new SqlParameter[0]).Rows[0][0].ToString();
            query = $"UPDATE Users SET LoggedIn = 'FALSE' WHERE UserID = '{userID}'";
            Utility.ExecuteSqlCommand(query, new SqlParameter[0]);
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

        private void ButtonHome_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Now navigating to Recipe Management Page");
            Utility.OpenForm(this, new ChefRecipeManagement(this));
        }

        private void LoadChefInfo(string chefId)
        {
            string query = "SELECT FullName, Gender, Role FROM Users WHERE UserID = @ChefID";
            SqlParameter[] parameters = { new SqlParameter("@ChefID", chefId) };

            DataTable dataTable = Utility.ExecuteSqlQuery(query, parameters);

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                LblHomeName.Text = row["FullName"].ToString();
                LblHomeGender.Text = row["Gender"].ToString();
                LblHomeRole.Text = row["Role"].ToString();
            }
            else
            {
                MessageBox.Show("No chef found with the provided ID.");
            }
        }

        private void LoadOrderInfo(string chefID)
        {
            string queryCompleted = "SELECT count(*) FROM Orders WHERE OrderStatus IN ('COMPLETED', 'COMPLETED_ORDER') AND ChefID = @chefID";
            string queryUncompleted = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'IN_PROGRESS' AND ChefID = @chefID";
            string queryPending = "SELECT COUNT(*) FROM Orders WHERE OrderStatus = 'PENDING'";

            SqlParameter[] parameters = { new SqlParameter("@chefID", chefID) };

            LblHomeOrderComplete.Text = Utility.ExecuteSqlQuery(queryCompleted, parameters).Rows[0][0].ToString();
            LblHomeOrderProgress.Text = Utility.ExecuteSqlQuery(queryUncompleted, parameters).Rows[0][0].ToString();
            LblHomeOrderPending.Text = Utility.ExecuteSqlQuery(queryPending, parameters).Rows[0][0].ToString();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
