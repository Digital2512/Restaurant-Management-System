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
    public partial class ManagerTablesPage : Form
    {
        public ManagerTablesPage()
        {
            InitializeComponent();
            dtPickerDate.Format = DateTimePickerFormat.Custom;
            dtPickerDate.CustomFormat = "dd/MM/yyyy";
        }

        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private Manager manager = new Manager();
        private string reservationID;

        private void ManagerTablesPage_Load(object sender, EventArgs e)
        {
            HideReservationForm();

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationStatus = 'APPROVED' ORDER BY ReservedDate, ReservedStartTime", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUpcoming.DataSource = dt;
            con.Close();

        }

        private void LoadCustomerIDs()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM [Customer] WHERE ReservationID IS NULL", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtCustomer = new DataTable();
                    da.Fill(dtCustomer);
                    cbbCustomerID.DataSource = dtCustomer;
                    cbbCustomerID.DisplayMember = "CustomerID";
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer IDs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HideReservationForm()
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnAdd.Visible = true;
            lblResv.Visible = false;
            lblCustomerID.Visible = false;
            cbbCustomerID.Visible = false;
            lblPax.Visible = false;
            txtPax.Visible = false;
            lblPlaceID.Visible = false;
            cbbPlaceID.Visible = false;
            lblDate.Visible = false;
            lblTime.Visible = false;
            dtPickerDate.Visible = false;
            cbbTime.Visible = false;
            lblDuration.Visible = false;
            cbbDuration.Visible = false;
            lblInstruction.Visible = false;
            richtxtInstruction.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            btnClear.Visible = true;
        }
        private void ShowReservationForm()
        {
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnAdd.Visible = false;
            lblCustomerID.Visible = true;
            lblPax.Visible = true;
            txtPax.Visible = true;
            lblPlaceID.Visible = true;
            cbbPlaceID.Visible = true;
            lblDate.Visible = true;
            lblTime.Visible = true;
            dtPickerDate.Visible = true;
            cbbTime.Visible = true;
            lblInstruction.Visible = true;
            richtxtInstruction.Visible = true;
            lblDuration.Visible = true;
            cbbDuration.Visible = true;
            btnClear.Visible = false;
            btnCancel.Visible = true;
        }


        private void RefreshDataGridView()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationStatus = 'APPROVED' ORDER BY ReservedDate, ReservedStartTime", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUpcoming.DataSource = dt;
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }




        private void txtResvSearch_Enter(object sender, EventArgs e)
        {
            if (txtResvSearch.Text == "Search..")
            {
                txtResvSearch.Text = "";
                RefreshDataGridView();
            }
        }

        private void txtResvSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResvSearch.Text))
            {
                txtResvSearch.Text = "Search...";
                RefreshDataGridView();

            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = txtResvSearch.Text.Trim();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE (ReservationID LIKE @SearchInput OR CustomerID LIKE @SearchInput OR PlaceID LIKE @SearchInput OR PlaceName LIKE @SearchInput OR ReservedDate LIKE @SearchInput OR Duration LIKE @SearchInput OR ReservedStartTime LIKE @SearchInput OR ReservedEndTime LIKE @SearchInput) AND ReservationStatus = 'APPROVED'", con);
                    cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridViewUpcoming.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No matching records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            cbbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPlaceID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDuration.DropDownStyle = ComboBoxStyle.DropDownList;

            lblCustomerID.Text = "CustomerID: ";
            cbbCustomerID.SelectedIndex = -1;
            txtPax.Text = ""; 
            cbbPlaceID.SelectedIndex = -1; 
            dtPickerDate.Value = DateTime.Today;
            cbbTime.SelectedIndex = -1;
            cbbDuration.SelectedIndex = -1;
            richtxtInstruction.Text = "";

            cbbCustomerID.Visible = true;
            btnSave.Visible = true;
            ShowReservationForm();
            LoadCustomerIDs();
        }

        private void dataGridViewUpcoming_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUpcoming.Rows[e.RowIndex];
                reservationID = row.Cells["ReservationID"].Value.ToString();
            }
        }

        private Dictionary<(int min, int max), List<string>> paxPlaceMapping = new Dictionary<(int min, int max), List<string>>
        {
            {(1, 2), new List<string>{"T01", "T02", "T03", "T04"}},
            {(3, 4), new List<string>{"T05", "T06", "T07", "T08"}},
            {(5, 8), new List<string>{"T09", "T10"}},
            {(9, 15), new List<string>{"VIP01", "VIP02"}}
        };


        private void txtPax_TextChanged(object sender, EventArgs e)
        {
            int customerPax;
            if (int.TryParse(txtPax.Text, out customerPax))
            {
                LoadAvailablePlaces(customerPax);
            }

        }

        private void LoadAvailablePlaces(int customerPax)
        {
            foreach (var kvp in paxPlaceMapping)
            {
                int min = kvp.Key.min;
                int max = kvp.Key.max;

                if (customerPax >= min && customerPax <= max)
                {
                    cbbPlaceID.DataSource = kvp.Value;
                    return; 
                }
            }

            cbbPlaceID.DataSource = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbbCustomerID.Visible = false;
            cbbPlaceID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbDuration.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                if (dataGridViewUpcoming.SelectedRows.Count > 0)
                {
                    cbbCustomerID.Visible = false;
                    lblResv.Visible = true;
                    btnUpdate.Visible = true;
                    DataGridViewRow selectedRow = dataGridViewUpcoming.SelectedRows[0];

                    lblResv.Text = "ReservationID: " + selectedRow.Cells["ReservationID"].Value.ToString();
                    lblCustomerID.Text = "CustomerID: " + selectedRow.Cells["CustomerID"].Value.ToString();
                    txtPax.Text = selectedRow.Cells["CustomerPax"].Value.ToString();
                    cbbPlaceID.Text = selectedRow.Cells["PlaceID"].Value.ToString();
                    dtPickerDate.Value = Convert.ToDateTime(selectedRow.Cells["ReservedDate"].Value);
                    cbbTime.Text = selectedRow.Cells["ReservedStartTime"].Value.ToString();
                    cbbDuration.Text = selectedRow.Cells["Duration"].Value.ToString();
                    richtxtInstruction.Text = selectedRow.Cells["PlaceSpecialInstructions"].Value.ToString();

                    ShowReservationForm();
                }
                else
                {
                    MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while editing the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewUpcoming.CurrentRow;
                if (row != null)
                {
                    string reservationIDToDelete = row.Cells["ReservationID"].Value.ToString();
                    string placeID = row.Cells["PlaceID"].Value.ToString();
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        SqlCommand updateCustomerCmd = new SqlCommand("UPDATE Customer SET ReservationID = NULL WHERE ReservationID = @ReservationID", con);
                        updateCustomerCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        updateCustomerCmd.ExecuteNonQuery();

                        Manager.DeleteReservationById(con, placeID, reservationIDToDelete);

                        SqlCommand deleteReservationCmd = new SqlCommand("DELETE FROM Reservation WHERE ReservationID = @ReservationID", con);
                        deleteReservationCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        int rowsAffected = deleteReservationCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation deleted successfully.");
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. The reservation might have already been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbbCustomerID.Text) ||
                    string.IsNullOrWhiteSpace(txtPax.Text) ||
                    string.IsNullOrWhiteSpace(cbbPlaceID.Text) ||
                    string.IsNullOrWhiteSpace(richtxtInstruction.Text) ||
                    dtPickerDate.Value == null ||
                    string.IsNullOrWhiteSpace(cbbTime.Text) ||
                    string.IsNullOrWhiteSpace(cbbDuration.Text))

                {
                    MessageBox.Show("Please fill in all data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string reservationID = manager.GenerateReservationID();
                string newReservationID = reservationID;
                string placeID = cbbPlaceID.Text.Trim();

                DateTime reservedDate = dtPickerDate.Value.Date;

                int startTime = int.Parse(cbbTime.Text);
                int duration = int.Parse(cbbDuration.Text);

                int endTime = startTime + (duration * 100);
                if (endTime > 2200)
                {
                    MessageBox.Show("The reservation end time exceeds the closing time of 2200.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmdCheckAvailability = new SqlCommand("SELECT COUNT(*) FROM Reservation WHERE PlaceID = @PlaceID AND ReservedDate = @ReservedDate AND (@ReservedStartTime < ReservedEndTime AND @ReservedEndTime > ReservedStartTime) AND ReservationStatus = 'APPROVED'", con);
                cmdCheckAvailability.Parameters.AddWithValue("@PlaceID", placeID);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedDate", reservedDate);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedStartTime", startTime);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedEndTime", endTime);

                int count = (int)cmdCheckAvailability.ExecuteScalar();

                if (count > 0)
                {
                    Manager.ShowReservedTimeSlots(placeID, reservedDate);
                    return;
                }

                SqlCommand cmdFetchPlaceName = new SqlCommand("SELECT PlaceName FROM PlacesOfReservation WHERE PlaceID = @PlaceID", con);
                cmdFetchPlaceName.Parameters.AddWithValue("@PlaceID", cbbPlaceID.SelectedItem.ToString());
                string placeName = (string)cmdFetchPlaceName.ExecuteScalar();

                SqlCommand cmdFetchEventType = new SqlCommand($"SELECT EventType FROM PlacesOfReservation WHERE PlaceID = '{placeID}'", con);
                string eventType = (string)cmdFetchEventType.ExecuteScalar();

                Manager.AddReservation(con, reservationID, cbbCustomerID.Text, txtPax.Text, placeID, placeName, reservedDate, startTime, endTime, duration, richtxtInstruction.Text, eventType);

                Manager.GetReservationIdByPlaceId(con, placeID, reservationID);

                RefreshDataGridView();

                HideReservationForm();
                MessageBox.Show("Reservation Added Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            HideReservationForm();

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                string reservationID = lblResv.Text.Replace("ReservationID: ", "").Trim();
                string customerID = lblCustomerID.Text.Replace("CustomerID: ", "").Trim();
                string placeID = cbbPlaceID.Text.Trim();

                DateTime reservedDate = dtPickerDate.Value.Date;

                int startTime = int.Parse(cbbTime.Text);
                int duration = int.Parse(cbbDuration.Text);

                int endTime = startTime + (duration * 100);
                if (endTime > 2200)
                {
                    MessageBox.Show("The reservation end time exceeds the closing time of 2200.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                SqlCommand cmdCheckAvailability = new SqlCommand("SELECT COUNT(*) FROM Reservation WHERE PlaceID = @PlaceID AND ReservedDate = @ReservedDate AND (@ReservedStartTime < ReservedEndTime AND @ReservedEndTime > ReservedStartTime) AND ReservationID != @ReservationID", con);
                cmdCheckAvailability.Parameters.AddWithValue("@PlaceID", placeID);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedDate", reservedDate);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedStartTime", startTime);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedEndTime", endTime);
                cmdCheckAvailability.Parameters.AddWithValue("ReservationID", reservationID);

                int count = (int)cmdCheckAvailability.ExecuteScalar();

                if (count > 0)
                {
                    Manager.ShowReservedTimeSlots(placeID, reservedDate);
                    return;
                }


                SqlCommand oldPlaceIDCommand = new SqlCommand("SELECT PlaceID FROM Reservation WHERE ReservationID = @ReservationID;", con);
                oldPlaceIDCommand.Parameters.AddWithValue("@ReservationID", reservationID);
                string oldPlaceID = (string)oldPlaceIDCommand.ExecuteScalar();

                SqlCommand cmdFetchPlaceName = new SqlCommand("SELECT PlaceName FROM PlacesOfReservation WHERE PlaceID = @PlaceID", con);
                cmdFetchPlaceName.Parameters.AddWithValue("@PlaceID", cbbPlaceID.SelectedItem.ToString());
                string placeName = (string)cmdFetchPlaceName.ExecuteScalar();

                SqlCommand cmdFetchEventType = new SqlCommand($"SELECT EventType FROM PlacesOfReservation WHERE PlaceID = '{placeID}'", con);
                string eventType = (string)cmdFetchEventType.ExecuteScalar();

                Manager.UpdateReservation(con, reservationID, txtPax.Text, placeID, placeName, reservedDate, startTime, endTime, duration, richtxtInstruction.Text, eventType);

                Manager.DeleteReservationById(con, oldPlaceID, reservationID);
                Manager.GetReservationIdByPlaceId(con, placeID, reservationID);

                RefreshDataGridView();
                HideReservationForm();
                MessageBox.Show("Reservation Updated Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewUpcoming.CurrentRow;
                if (row != null)
                {
                    string reservationIDToDelete = row.Cells["ReservationID"].Value.ToString();
                    string placeID = row.Cells["PlaceID"].Value.ToString();

                    manager.ClearReservation(reservationIDToDelete, placeID);
                    MessageBox.Show("Table cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("No row selected!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnPending_Click(object sender, EventArgs e)
        {
            ManagerPendingPage frmPending = new ManagerPendingPage();
            frmPending.ShowDialog();
        }

        private void btnT01_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T01");
        }
        private void btnT02_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T02");
        }
        private void btnT03_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T03");
        }

        private void btnT04_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T04");
        }

        private void btnT05_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T05");
        }
        private void btnT06_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T06");
        }

        private void btnT07_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T07");
        }
        private void btnT08_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T08");
        }

        private void btnT09_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T09");
        }

        private void btnT10_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("T10");
        }

        private void btnVIP1_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("VIP01");
        }

        private void btnVIP2_Click(object sender, EventArgs e)
        {
            Manager.DisplayTableInformation("VIP02");
        }
    }

}

