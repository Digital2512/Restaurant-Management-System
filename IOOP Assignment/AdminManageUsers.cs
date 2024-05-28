using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IOOP_Assignment
{
    public partial class AdminManageUsers : Form
    {


        public static string name;
        public AdminManageUsers()
        {
            InitializeComponent();
        }
        public AdminManageUsers(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void AdminManageUsers_Load(object sender, EventArgs e)
        {

        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            AdminAddManager am = new AdminAddManager();
            am.ShowDialog();
        }

        private void btnViewManager_Click(object sender, EventArgs e)
        {
            AdminViewManager vm = new AdminViewManager();
            vm.ShowDialog();
        }

        private void btnUpdateDeleteManager_Click(object sender, EventArgs e)
        {
            AdminUpdateDeleteManager udm = new AdminUpdateDeleteManager();
            udm.ShowDialog();
        }

        private void btnAddChef_Click(object sender, EventArgs e)
        {
            AdminAddChef acf = new AdminAddChef();
            acf.ShowDialog();
        }

        private void btnUpdateDeleteChef_Click(object sender, EventArgs e)
        {
            AdminUpdateDeleteChef udch = new AdminUpdateDeleteChef();
            udch.ShowDialog();
        }

        private void btnViewChef_Click(object sender, EventArgs e)
        {
            AdminViewChef vch = new AdminViewChef();    
            vch.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AdminAddCustomer ac = new AdminAddCustomer();
            ac.ShowDialog();
        }

        private void btnUpdateDeleteCustomer_Click(object sender, EventArgs e)
        {
            AdminUpdateDeleteCustomer udc = new AdminUpdateDeleteCustomer();
            udc.ShowDialog();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            AdminViewCustomer vc = new AdminViewCustomer(); 
            vc.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Hide();
            hp.Show();
        }
    }
}
