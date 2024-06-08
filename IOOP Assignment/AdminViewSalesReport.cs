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
        private static readonly string[] Months =
         { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        private static readonly string[] Categories =
        { "Japanese", "Western", "Korean", "Beverages"};
        public AdminViewSalesReport()
        {
            InitializeComponent();
            lblTotalAmount.Text = "RM0.00";
            lblOrderCount.Text = "0";
            InitializeComboBoxes();
            LoadAllSalesReportData();
        }

        private void InitializeComboBoxes()
        {
            cmbMonth.Items.AddRange(Months);
            cmbCategory.Items.AddRange(Categories);
        }

        private void LoadChefIDs()
        {
            DataTable chefIDs = GetChefIDs();
            cmbChefID.DataSource = chefIDs;
            cmbChefID.DisplayMember = "ChefID";
            cmbChefID.ValueMember = "ChefID";
        }

        private DataTable GetChefIDs()
        {
            string connectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog=\"FINAL DATABASE\";Integrated Security=True";
            string query = "SELECT DISTINCT ChefID FROM Orders WHERE ChefID IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }

        private void LoadAllSalesReportData()
        {
            DataTable salesReportData = GetSalesReportData(null, null, null);
            dgvSalesReport.DataSource = salesReportData;
            UpdateChefIDComboBox(salesReportData);
        }

        private void UpdateChefIDComboBox(DataTable salesReportData)
        {
            var chefIDs = salesReportData.AsEnumerable()
                                         .Select(row => row.Field<string>("ChefID"))
                                         .Distinct()
                                         .ToList();

            cmbChefID.Items.Clear();
            cmbChefID.Items.AddRange(chefIDs.ToArray());

        }

        private void UpdateSummary(DataTable salesReportData)
        {
            int orderCount = salesReportData.Rows.Count;
            decimal totalAmount = salesReportData.AsEnumerable().Sum(row => row.Field<decimal>("TotalPrice"));

            lblOrderCount.Text = $"Order Count: {orderCount}";
            lblTotalAmount.Text = $"Total Amount: RM{totalAmount:N2}";
        }

        private void AdminViewSalesReport_Load(object sender, EventArgs e)
        {
            LoadAllSalesReportData();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int? selectedMonth = cmbMonth.SelectedIndex >= 0 ? cmbMonth.SelectedIndex + 1 : (int?)null;
            string selectedCategory = cmbCategory.SelectedItem as string;
            string selectedChefId = cmbChefID.SelectedValue as string;

            if (string.IsNullOrEmpty(selectedChefId))
            {
                MessageBox.Show("Please select a ChefID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine($"Selected Month: {selectedMonth}");
            Console.WriteLine($"Selected Category: {selectedCategory}");
            Console.WriteLine($"Selected ChefID: {selectedChefId}");

            DataTable salesReportData = GetSalesReportData(selectedMonth, selectedCategory, selectedChefId);
            dgvSalesReport.DataSource = salesReportData;
            UpdateSummary(salesReportData);
        }

        private DataTable GetSalesReportData(int? month, string category, string chefId)
        {
            string connectionString = "Data Source=DESKTOP-SHIU3PM;Initial Catalog=\"FINAL DATABASE\";Integrated Security=True";
            string query = @"
            SELECT 
                ProductID, 
                ProductName, 
                Quantity, 
                IndividualPrice, 
                TotalPrice, 
                OrderDateTime, 
                Cuisine, 
                ChefID 
            FROM 
                SalesReport
            WHERE 
                (@SelectedChefID IS NULL OR ChefID = @SelectedChefID) AND
                (@SelectedMonth IS NULL OR MONTH(OrderDateTime) = @SelectedMonth) AND
                (@SelectedCategory IS NULL OR Cuisine = @SelectedCategory)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SelectedMonth", (object)month ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SelectedCategory", (object)category ?? DBNull.Value);
                    command.Parameters.AddWithValue("@SelectedChefID", (object)chefId ?? DBNull.Value);

                    Console.WriteLine($"Executing Query: {command.CommandText}");
                    foreach (SqlParameter param in command.Parameters)
                    {
                        Console.WriteLine($"{param.ParameterName}: {param.Value}");
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    Console.WriteLine($"Rows returned: {dataTable.Rows.Count}");
                    foreach (DataRow row in dataTable.Rows)
                    {
                        Console.WriteLine($"ProductID: {row["ProductID"]}, ProductName: {row["ProductName"]}, ChefID: {row["ChefID"]}");
                    }

                    return dataTable;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage hp = new AdminHomePage();
            this.Close();
            hp.ShowDialog();
        }

        private void cmbChefID_DropDown(object sender, EventArgs e)
        {
            LoadChefIDs();
        }
    }
}
