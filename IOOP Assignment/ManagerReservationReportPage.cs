using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ManagerReservationReportPage : Form
    {
        public ManagerReservationReportPage()
        {
            InitializeComponent();
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void ManagerReservationReportPage_Load(object sender, EventArgs e)
        {
            cbbMonth.SelectedIndex = 0;
            LoadReservationReport();
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReservationReport();
        }

        private void LoadReservationReport()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    StringBuilder query = new StringBuilder();

                    query.Append("SELECT R.ReservationID, R.PlaceID, R.CustomerID, R.CustomerPax, R.ReservedDate, R.ReservedStartTime, R.ReservedEndTime, POR.EventType ");
                    query.Append("FROM Reservation AS R ");
                    query.Append("JOIN PlaceOfReservation AS POR ON R.PlaceID = POR.PlaceID ");
                    query.Append("WHERE R.ReservationStatus = 'COMPLETED' ");

                    // Add month filter if a specific month is selected
                    if (cbbMonth.SelectedIndex > 0)
                    {
                        query.Append("AND MONTH(R.ReservedDate) = @SelectedMonth ");
                        cmd.Parameters.AddWithValue("@SelectedMonth", cbbMonth.SelectedIndex);
                    }

                    cmd.CommandText = query.ToString();
                    cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridViewResvReport.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = txtSearch.Text.Trim();
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT R.ReservationID, R.PlaceID, R.CustomerID, R.CustomerPax, R.ReservedDate, R.ReservedStartTime, R.ReservedEndTime, POR.EventType FROM Reservation AS R JOIN PlaceOfReservation AS POR ON R.PlaceID = POR.PlaceID " +
                            "WHERE R.ReservationID LIKE @SearchInput OR R.PlaceID LIKE @SearchInput OR R.CustomerID LIKE @SearchInput OR R.CustomerPax LIKE @SearchInput OR R.ReservedDate LIKE @SearchInput OR R.ReservedStartTime LIKE @SearchInput OR R.ReservedEndTime LIKE @SearchInput OR POR.EventType LIKE @SearchInput", con);
                cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewResvReport.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

