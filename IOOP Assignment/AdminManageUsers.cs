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
    public partial class AdminManageUsers : Form
    {
        public AdminManageUsers()
        {
            InitializeComponent();
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            AdminAddManager am = new AdminAddManager();
            this.Close();
            am.ShowDialog();
        }

        private void btnUpdateDeleteManager_Click(object sender, EventArgs e)
        {
            AdminUpdateDeleteManager udm = new AdminUpdateDeleteManager();
            this.Close();
            udm.ShowDialog();
        }

        private void btnViewManager_Click(object sender, EventArgs e)
        {
            AdminViewManager vm = new AdminViewManager();
            this.Close();
            vm.ShowDialog();
        }

        private void btnAddChef_Click(object sender, EventArgs e)
        {
            AdminAddChef acf = new AdminAddChef();
            this.Close();
            acf.ShowDialog();
        }

        private void btnUpdateDeleteChef_Click(object sender, EventArgs e)
        {
            AdminUpdateDeleteChef udch = new AdminUpdateDeleteChef();
            this.Close();
            udch.ShowDialog();
        }

        private void btnViewChef_Click(object sender, EventArgs e)
        {
            AdminViewChef vch = new AdminViewChef();
            this.Close();
            vch.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AdminAddCustomer ac = new AdminAddCustomer();
            this.Close();
            ac.ShowDialog();
        }

        private void btnUpdateDeleteCustomer_Click(object sender, EventArgs e)
        {
            AdminUpdateDeleteCustomer udc = new AdminUpdateDeleteCustomer();
            this.Close();
            udc.ShowDialog();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            AdminViewCustomer vc = new AdminViewCustomer();
            this.Close();
            vc.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Close();
            hp.Show();
        }

        private void AdminManageUsers_Load_1(object sender, EventArgs e)
        {

        }
    }
}
