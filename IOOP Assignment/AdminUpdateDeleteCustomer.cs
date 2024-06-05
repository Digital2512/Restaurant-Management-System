using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class AdminUpdateDeleteCustomer : Form
    {
        private Customer customer;
        public AdminUpdateDeleteCustomer()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog=IOOPDatabase1;Integrated Security=True";
            customer = new Customer(connectionString);
        }

        private void FillComboSearchCode()
        {
            cmbCustomerID.Items.Clear();
            DataTable dt = customer.GetCustomerId();

            foreach (DataRow dr in dt.Rows)
            {
                cmbCustomerID.Items.Add(dr["Id"].ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = customer.GetCustomerById(cmbCustomerID.Text);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtFullName.Text = row["fullName"].ToString();
                dtpDob.Value = DateTime.Parse(row["dateOfBirth"].ToString());

                string gender = row["Gender"].ToString();
                if (gender == "Male")
                {
                    rdbtnMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    rdbtnFemale.Checked = true;
                }
                txtphoneNumber.Text = row["phoneNumber"].ToString();
                txtEmail.Text = row["Email"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = customer.updateCustomer(
               cmbCustomerID.Text,
               txtFullName.Text,
               dtpDob.Text,
               grpboxGender.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text,
               txtphoneNumber.Text,
               txtEmail.Text);

            MessageBox.Show(status);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = cmbCustomerID.Text;
            string status = customer.deleteCustomer(id);
            MessageBox.Show(status);

            FillComboSearchCode();
            ClearForm();
        }

        private void ClearForm()
        {
            cmbCustomerID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            dtpDob.Text = string.Empty;
            rdbtnMale.Checked = false;
            rdbtnFemale.Checked = false;
            txtphoneNumber.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void AdminUpdateDeleteCustomer_Load(object sender, EventArgs e)
        {
            FillComboSearchCode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Close();
            mu.ShowDialog();
        }
    }
}
