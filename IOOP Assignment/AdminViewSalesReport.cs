using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trial_2
{
    public partial class AdminViewSalesReport : Form
    {
        string conectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog=IOOPDatabase;Integrated Security=True";
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
                string query = @"
                    Select
                        NewID() AS ReportID, 
                        O.OrderID,
                        M.Cuisine,
                        U.UserID As ChefID, 
                        O.OrderDateTime,
                        OD.Price,
                        OD.Quantity,
                        (OD.Price* OD.Quantity) As TotalAmount
                    from 
                        Orders O
                    Inner join
                        OrderDetails OD on O.OrderID = OD.OrderID
                    Inner Join
                        Menu M on OD.ProductID = M.ProductID
                    Inner Join
                        Users U on O.CustomerID = U.UserID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(salesData);

                }

            }
        }

        private void FilterData()
        {
            cmbMonth.Items.Clear();
            cmbMonth.Items.AddRange(new string[]
            {
                "January","February","March","April","May","June", "July","August","September","October","November","Dcemeber"
            });

            cmbMonth.Items.Clear();
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

            cmbMonth.Items.Clear();
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



        private void LoadSalesData(int month, string cuisines, string chefID)
        {
            DataTable salesData = new DataTable();

            using (SqlConnection con = new SqlConnection(conectionString))
            {
                string query = @"
                    Select
                        NewID() As ReportID,
                        O.OrderID,
                        M.Cuisine,
                        U.UserID As ChefID,
                        O.OrderDateTime,
                        OD.Price,
                        OD.Quantity,
                        (OD.Price*OD.Quantity) As TotalAmount
                    From
                        Orders O
                    Inner Join
                        OrderDetails OD on O.OrderID = OD.OrderID
                    Inner Join
                        Menu M on OD.ProductID = M.ProductID
                    Inner Join
                        Users U on O.CustomerID = U.UserID
                    Where
                        Month(O.orderDateTime) = @month
                        And M.Cuisine = @cuisine
                        And U.UserID = @chefID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@cuisine", cuisines);
                    cmd.Parameters.AddWithValue("@chefID", chefID);

                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        salesData.Load(reader);
                    }
                }

            }
            dgvSalesReport.DataSource = salesData;

            decimal totalAmount = 0;
            int orderCount = 0;
            foreach (DataRow row in salesData.Rows)
            {
                totalAmount += Convert.ToDecimal(row["TotalAmount"]);
                orderCount++;
            }

            lblTotalAmount.Text = $"RM{totalAmount:F2}";
            lblOrderCount.Text = $"{orderCount}";

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            int month = cmbMonth.SelectedIndex + 1; //Month is 1 -based
            string category = cmbCategory.SelectedItem?.ToString();
            string chefID = cmbChefID.SelectedItem?.ToString();

            LoadSalesData(month, category, chefID);


        }

        private void AdminViewSalesReport_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Hide();
            hp.Show();
        }
    }
}
