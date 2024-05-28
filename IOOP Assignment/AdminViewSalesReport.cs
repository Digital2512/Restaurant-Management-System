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
    public partial class AdminViewSalesReport : Form
    {
        string conectionString = "";
        private DataTable salesData = new DataTable();
        public AdminViewSalesReport()
        {
            InitializeComponent();
            LoadSalesData();
            dgvSalesReport.DataSource = salesData;
            FilterData();
        }

        private void LoadSalesData()
        {
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = "Select * From SalesReport";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(salesData);
            }
        }
        private void FilterData()
        {
            cmbMonth.Items.AddRange(new string[]
            {
                "January","February","March","April","May","June", "July","August","September","October","November","Dcemeber"
            });


            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = "Select Distinct Cuisine from Menu";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCategory.Items.Add(reader["Cuisines"].ToString());
                        }
                    }
                }
            }
            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = "Select distinct UserID from Users where UserID like 'CH%'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbChefID.Items.Add(reader["UserID"].ToString());
                        }
                    }
                }
            }
        }

        private void AdminViewSalesReport_Load(object sender, EventArgs e)
        {

        }

        private void LoadSalesData(int month, string Cuisines, string chefID)
        {
            DataTable salesData = new DataTable();

            using (SqlConnection con = new SqlConnection(conectionString))
            {

                string query = @"Select ReportID,ProductID, Cuisines,ChefID,OrderDateTime,Price,Quantity,(Price*Quantity) As TotalAmount From SalesReport where Month(OrderDateTime) = @month and Cuisines = @cuisines and ChefID = @chefID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@cuisines", Cuisines);
                cmd.Parameters.AddWithValue("@chefID", chefID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSalesReport.DataSource = dt;

                decimal totalAmount = 0;
                int orderCount = 0;
                foreach (DataGridViewRow row in dgvSalesReport.Rows)
                {
                    if (row.Cells["TotalAmount"].Value != null)
                    {
                        totalAmount += Convert.ToDecimal(row.Cells["TotalAmount"].Value);
                    }
                    orderCount++;
                }

                lblTotalAmount.Text = $"Total Amount: {totalAmount:C}";
                lblOrderCount.Text = $"Order Count: {orderCount}";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int month = cmbMonth.SelectedIndex + 1; //Month is 1 -based
            string category = cmbCategory.SelectedItem?.ToString();
            string chefID = cmbChefID.SelectedItem?.ToString();

            LoadSalesData(month, category, chefID);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Hide();
            hp.Show();
        }
    }
}
