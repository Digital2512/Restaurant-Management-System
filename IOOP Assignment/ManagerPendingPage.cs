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
    public partial class ManagerPendingPage : Form
    {
        public ManagerPendingPage()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private void ManagerPendingPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationStatus = 'PENDING'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPending.DataSource = dt;

            lblCustomerID.Visible = false;
            lblDuration.Visible = false;
            lblPax.Visible = false;
            lblPlaceID.Visible = false;
            lblResv.Visible = false;
            lblResvID.Visible = false;
            lblTime.Visible = false;
            btnApprove.Visible = false;
            btnDeny.Visible = false;

        }

        private void ShowApprovalForm()
        {
            lblCustomerID.Visible = true;
            lblDuration.Visible = true;
            lblPax.Visible = true;
            lblPlaceID.Visible = true;
            lblResv.Visible = true;
            lblResvID.Visible = true;
            lblTime.Visible = true;
            btnApprove.Visible = true;
            btnDeny.Visible = true;
        }

        private void HideApprovalForm()
        {
            lblCustomerID.Visible = false;
            lblDuration.Visible = false;
            lblPax.Visible = false;
            lblPlaceID.Visible = false;
            lblResv.Visible = false;
            lblResvID.Visible = false;
            lblTime.Visible = false;
            btnApprove.Visible = false;
            btnDeny.Visible = false;
        }

        private void RefreshDataGridView()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationStatus = 'PENDING'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewPending.DataSource = dt;
        }


        private void dataGridViewPending_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPending.Rows[e.RowIndex];

                if (string.IsNullOrEmpty(Convert.ToString(row.Cells["ReservationID"].Value)))
                {
                    // Clear other textboxes
                    lblCustomerID.Text = "";
                    lblDuration.Text = "";
                    lblPax.Text = "";
                    lblPlaceID.Text = "";
                    lblResv.Text = "";
                    lblResvID.Text = "";
                    lblTime.Text = "";
                }
                else
                {
                    ShowApprovalForm();

                    lblCustomerID.Text = "CustomerID: " + row.Cells["CustomerID"].Value.ToString();
                    lblDuration.Text = "Duration: " + row.Cells["Duration"].Value.ToString();
                    lblPax.Text = "Customer Pax: " + row.Cells["CustomerPax"].Value.ToString();
                    lblPlaceID.Text = "PlaceID: " + row.Cells["PlaceID"].Value.ToString();
                    lblResv.Text = "ReservationDate: " + ((DateTime)row.Cells["ReservedDate"].Value).ToString("yyyy-MM-dd");
                    lblResvID.Text = "ReservationID: " + row.Cells["ReservationID"].Value.ToString();

                    string startTime = row.Cells["ReservedStartTime"].Value.ToString();
                    string endTime = row.Cells["ReservedEndTime"].Value.ToString();
                    lblTime.Text = $"Reservation Time: {startTime} pm-{endTime} pm";
                }
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPending.SelectedRows.Count > 0)
                {
                    // Get the ReservationID and PlaceID from the selected row
                    string reservationID = dataGridViewPending.SelectedRows[0].Cells["ReservationID"].Value.ToString();
                    string placeID = dataGridViewPending.SelectedRows[0].Cells["PlaceID"].Value.ToString();
                    string newReservationId = reservationID;

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Update reservation status to 'APPROVED'
                        Manager.GetReservationIdByPlaceId(con, placeID, reservationID);
                        SqlCommand cmd = new SqlCommand("UPDATE Reservation SET ReservationStatus = 'APPROVED' WHERE ReservationID=@ReservationID", con);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            RefreshDataGridView();
                            HideApprovalForm();
                            MessageBox.Show("Reservation Approved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to approve reservation. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a reservation to approve.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while approving the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewPending.SelectedRows.Count > 0)
                {
                    // Get the ReservationID from the selected row
                    string reservationID = dataGridViewPending.SelectedRows[0].Cells["ReservationID"].Value.ToString();
                    string placeID = dataGridViewPending.SelectedRows[0].Cells["PlaceID"].Value.ToString();

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        using (SqlCommand cmd = new SqlCommand("UPDATE Reservation SET ReservationStatus = 'DENIED' WHERE ReservationID=@ReservationID", con))
                        {
                            cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                RefreshDataGridView();
                                HideApprovalForm();
                                MessageBox.Show("Reservation Denied!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to deny reservation. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a reservation to deny.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while denying the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
