using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Close();
            mu.ShowDialog();
        }

        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            AdminViewSalesReport vsr = new AdminViewSalesReport();
            this.Close();
            vsr.ShowDialog();
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            AdminViewFeedback vf = new AdminViewFeedback();
            this.Close();
            vf.ShowDialog();
        }


        private void btnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            AdminUpdateProfile up = new AdminUpdateProfile();
            this.Hide();
            up.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm lg = new loginForm();
            this.Close();
            lg.ShowDialog();
        }
    }
}
