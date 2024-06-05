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


        private void AdminHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            AdminUpdateProfile up = new AdminUpdateProfile();
            this.Close();
            up.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            this.Close();
            lf.ShowDialog();
        }
    }
}
