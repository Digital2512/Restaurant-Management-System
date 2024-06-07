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

        public string connetionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void ManagerReservationReportPage_Load(object sender, EventArgs e)
        {
            cbbMonth.SelectedIndex = 0;
            cbbEvent.SelectedIndex = 0;
            LoadReservationReport();
        }

        private void cbbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReservationReport();
        }

        private void cbbEvent_TextChanged(object sender, EventArgs e)
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

                    query.Append("SELECT ReservationID, PlaceID, CustomerID, CustomerPax, ReservedDate, ReservedStartTime, ReservedEndTime, EventType, ReservationStatus FROM Reservation WHERE 1=1");


                    // Add month filter if a specific month is selected
                    if (cbbMonth.SelectedIndex > 0)
                    {
                        query.Append(" AND MONTH(ReservedDate) = @SelectedMonth ");
                        cmd.Parameters.AddWithValue("@SelectedMonth", cbbMonth.SelectedIndex);
                    }

                    // Add event type filter if a specific event type is selected
                    if (cbbEvent.SelectedIndex > 0)
                    {
                        query.Append(" AND EventType = @SelectedEventType ");
                        cmd.Parameters.AddWithValue("@SelectedEventType", cbbEvent.SelectedItem.ToString());
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
                SqlCommand cmd = new SqlCommand("SELECT ReservationID, PlaceID, CustomerID, CustomerPax, ReservedDate, ReservedStartTime, ReservedEndTime, EventType, ReservationStatus FROM Reservation WHERE ReservationID LIKE @SearchInput OR PlaceID LIKE @SearchInput OR CustomerID LIKE @SearchInput OR CustomerPax LIKE @SearchInput OR ReservedDate LIKE @SearchInput OR ReservedStartTime LIKE @SearchInput OR ReservedEndTime LIKE @SearchInput OR EventType LIKE @SearchInput OR ReservationStatus LIKE @SearchInput", con);
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


