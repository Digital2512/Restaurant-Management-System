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

namespace IOOP_Assignment
{
    public partial class AdminAddCustomer : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public AdminAddCustomer()
        {
            InitializeComponent();
        }

        string gender = "";
        private bool CheckedGender()
        {
            if (rdbtnMale.Checked)
            {
                gender = "Male";
                return true;
            }
            else if (rdbtnFemale.Checked)
            {
                gender = "Female";
                return true;
            }
            else
            {
                return false;
            }
        }

        private string AutoNewId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select count(Id) from customers", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            string newId = "C" + (count + 1).ToString("D2");
            return newId;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!CheckedGender())
            {
                MessageBox.Show("Choose a gender");
                return;
            }

            string newId = AutoNewId();

            Customer obj1 = new Customer(newId, txtFullName.Text, dtpDob.Text, gender, txtphoneNumber.Text, txtEmail.Text);
            MessageBox.Show(obj1.addCustomer());
        }

        private void AdminAddCustomer_Load(object sender, EventArgs e)
        {
            lblCustomerID.Text = AutoNewId();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Hide();
            mu.Show();
        }
    }
}
