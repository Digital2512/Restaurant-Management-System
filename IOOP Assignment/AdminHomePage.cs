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
<<<<<<< HEAD
=======

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Hide();
            mu.Show();
        }

        private void btnViewSalesReport_Click(object sender, EventArgs e)
        {
            AdminViewSalesReport vsr = new AdminViewSalesReport();
            this.Hide();
            vsr.Show();
        }

        private void btnViewFeedback_Click(object sender, EventArgs e)
        {
            AdminViewFeedback vf = new AdminViewFeedback();
            this.Hide();
            vf.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            AdminUpdateProfile up = new AdminUpdateProfile();
            this.Hide();
            up.Show();  
        }
>>>>>>> Huey-Shin
    }
}
