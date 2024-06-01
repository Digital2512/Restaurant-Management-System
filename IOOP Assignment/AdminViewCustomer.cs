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

namespace trial_2
{
    public partial class AdminViewCustomer : Form
    {
        private Customer customer;
        private SqlConnection con;
        public AdminViewCustomer()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog=IOOPDatabase;Integrated Security=True";
            con = new SqlConnection(connectionString);
            customer = new Customer(connectionString);
        }


        private void FillData(string customerId = null)
        {
            con.Open();
            string query;

            if(string.IsNullOrEmpty(customerId))
            {
                query = "Select * from customers";
            }
            else
            {
                query = "Select * from customers where Id = @CustomerId";
            }

            SqlDataAdapter da = new SqlDataAdapter(query, con);

            if(!string.IsNullOrEmpty(customerId))
            {
                da.SelectCommand.Parameters.AddWithValue("@CustomerId",customerId);
            }

            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvViewCustomer.DataSource = dt;
            con.Close();
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
            string selectedCustomerId = cmbCustomerID.SelectedItem?.ToString(); 
            FillData(selectedCustomerId);
        }

        private void AdminViewCustomer_Load(object sender, EventArgs e)
        {
            FillData();
            FillComboSearchCode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminManageUsers mu = new AdminManageUsers();
            this.Hide();
            mu.Show();
        }
    }
}
