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
            InitializeComponent();
            // Set custom format for the DateTimePicker control
            dtPickerResvDateTime.Format = DateTimePickerFormat.Custom;
            dtPickerResvDateTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            // Set the DateTimePicker to show at 5:00 PM
            dtPickerResvDateTime.MinDate = DateTime.Today;
            dtPickerResvDateTime.Value = DateTime.Today.AddHours(17);
        }

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
        private Manager manager = new Manager();
        private string reservationID;

        private void ManagerTablesPage_Load(object sender, EventArgs e)
        {
            HideReservationForm();

            //datagridviewupcoming
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration FROM Reservation WHERE ReservationStatus = 'APPROVED' ORDER BY ReservedDateTime", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUpcoming.DataSource = dt;
        }

        private void LoadCustomerIDs()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM [Customer] WHERE ReservationID IS NULL", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dtCustomer = new DataTable();
                    da.Fill(dtCustomer);
                    cbbCustomerID.DataSource = dtCustomer;
                    cbbCustomerID.DisplayMember = "CustomerID";
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
            lblResvDateTime.Visible = false;
            dtPickerResvDateTime.Visible = false;
            lblDuration.Visible = false;
            cbbDuration.Visible = false;
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
            lblResvDateTime.Visible = true;
            dtPickerResvDateTime.Visible = true;
            lblDuration.Visible = true;
            cbbDuration.Visible = true;
            btnClear.Visible = false;
            btnCancel.Visible = true;
        }

        private void ClearSearchAndRefreshDataGridView()
        {
            txtResvSearch.Text = ""; // Clear the search textbox
            RefreshDataGridView(); // Refresh the DataGridView to show all records
        }
        private void RefreshDataGridView()
        {
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("SELECT ReservationID, PlaceID, CustomerID, PlaceName, CustomerPax, ReservedDateTime, Duration FROM Reservation WHERE ReservationStatus = 'APPROVED'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUpcoming.DataSource = dt;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void dtPickerResvDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDateTime = dtPickerResvDateTime.Value;
            DateTime openingTime = selectedDateTime.Date.AddHours(17); // 5 PM
            DateTime closingTime = selectedDateTime.Date.AddHours(21); // last reservation at 9 PM

            // If the selected date and time is in the past or before 5 PM today, reset it to 5 PM today
            if (dtPickerResvDateTime.Value < openingTime)
            {
                MessageBox.Show("Reservation time cannot be before 5 PM.");
                dtPickerResvDateTime.Value = openingTime;
            }
            // If the selected date and time is after 9 PM today, reset it to 9 PM
            else if (dtPickerResvDateTime.Value > closingTime)
            {
                MessageBox.Show("Reservation time cannot be after 9 PM.");
                dtPickerResvDateTime.Value = closingTime;
            }
        }

        private void txtResvSearch_Enter(object sender, EventArgs e)
        {
            if (txtResvSearch.Text == "Search...")
            {
                txtResvSearch.Text = "";
            }
        }

        private void txtResvSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtResvSearch.Text))
            {
                txtResvSearch.Text = "Search...";
                ClearSearchAndRefreshDataGridView();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = txtResvSearch.Text.Trim();
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationID LIKE @SearchInput OR CustomerID LIKE @SearchInput OR PlaceID LIKE @SearchInput OR PlaceName LIKE @SearchInput OR ReservedDateTime LIKE @SearchInput OR Duration LIKE @SearchInput", con);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Clear ComboBox and TextBox
            cbbCustomerID.SelectedIndex = -1;
            txtPax.Text = ""; // Clear text
            cbbPlaceID.SelectedIndex = -1; // Clear selection
            dtPickerResvDateTime.Value = DateTime.Today.AddHours(17);
            cbbDuration.SelectedIndex = -1;

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
            {(9, 10), new List<string>{"VIP01", "VIP02"}}
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
                    // Load available places from the list
                    cbbPlaceID.DataSource = kvp.Value;
                    return; // Exit the method once places are loaded
                }
            }

            // If no matching range is found, clear the ComboBox
            cbbPlaceID.DataSource = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dataGridViewUpcoming.SelectedRows.Count > 0)
                {
                    cbbCustomerID.Visible = false;
                    lblResv.Visible = true;
                    btnUpdate.Visible = true;
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridViewUpcoming.SelectedRows[0];

                    // Populate the controls with data from the selected row
                    lblResv.Text = "ReservationID: " + selectedRow.Cells["ReservationID"].Value.ToString();
                    lblCustomerID.Text = "CustomerID: " + selectedRow.Cells["CustomerID"].Value.ToString();
                    txtPax.Text = selectedRow.Cells["CustomerPax"].Value.ToString();
                    cbbPlaceID.Text = selectedRow.Cells["PlaceID"].Value.ToString();
                    dtPickerResvDateTime.Value = (DateTime)selectedRow.Cells["ReservedDateTime"].Value;
                    cbbDuration.Text = selectedRow.Cells["Duration"].Value.ToString();

                    // Show the form for editing
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
                    using (SqlConnection con = new SqlConnection(connetionString))
                    {
                        con.Open();
                        SqlCommand updateCustomerCmd = new SqlCommand("UPDATE Customer SET ReservationID = NULL WHERE ReservationID = @ReservationID", con);
                        updateCustomerCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        updateCustomerCmd.ExecuteNonQuery();

                        /*SqlCommand updatePlaceCmd = new SqlCommand("UPDATE PlaceOfReservation SET ReservationID = NULL WHERE ReservationID = @ReservationID", con);
                        updatePlaceCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        updatePlaceCmd.ExecuteNonQuery();*/

                        Manager.DeleteReservationById(con, placeID, reservationIDToDelete);

                        SqlCommand deleteReservationCmd = new SqlCommand("DELETE FROM Reservation WHERE ReservationID = @ReservationID", con);
                        deleteReservationCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        int rowsAffected = deleteReservationCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. The reservation might have already been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDateTime = DateTime.Now;
                DataGridViewRow row = dataGridViewUpcoming.CurrentRow;
                if (row != null)
                {
                    string reservationIDToDelete = row.Cells["ReservationID"].Value.ToString();
                    string placeID = row.Cells["PlaceID"].Value.ToString();
                    using (SqlConnection con = new SqlConnection(connetionString))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT ReservedDateTime FROM Reservation WHERE ReservationID = @ReservationID", con);
                        cmd.Parameters.AddWithValue("@ReservationID", reservationIDToDelete);
                        DateTime reservationDateTime = (DateTime)cmd.ExecuteScalar();

                        if (reservationDateTime <= currentDateTime)
                        {

                            // Reservation time is in the past or at the current date and time, proceed with clearing the table
                            using (SqlCommand updateReservationCmd = new SqlCommand("UPDATE Reservation SET ReservationStatus = 'COMPLETED' WHERE ReservationID = @ReservationID", con))
                            using (SqlCommand updateCustomerCmd = new SqlCommand("UPDATE Customer SET ReservationID = NULL WHERE ReservationID = @ReservationID", con))
                            {

                                updateReservationCmd.Parameters.AddWithValue("@ReservationID", reservationIDToDelete);
                                updateCustomerCmd.Parameters.AddWithValue("@ReservationID", reservationIDToDelete);
                                int rowsAffected = updateCustomerCmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    Manager.DeleteReservationById(con, placeID, reservationIDToDelete);
                                    MessageBox.Show("Table cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    RefreshDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("No table cleared. The reservation might have already been cleared.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Reservation is yet to come!"); // Debugging statement
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No row selected!"); // Debugging statement
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while clearing the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if all required fields are filled
                if (string.IsNullOrWhiteSpace(cbbCustomerID.Text) ||
                    string.IsNullOrWhiteSpace(txtPax.Text) ||
                    string.IsNullOrWhiteSpace(cbbPlaceID.Text) ||
                    dtPickerResvDateTime.Value == null ||
                    string.IsNullOrWhiteSpace(cbbDuration.Text))
                {
                    MessageBox.Show("Please fill in all data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generate a reservation ID
                string reservationID = manager.GenerateReservationID();
                string newReservationID = reservationID;
                string placeID = cbbPlaceID.Text.Trim();


                // Fetch the PlaceName corresponding to the selected PlaceID
                string placeName;

                int duration = int.Parse(cbbDuration.Text);
                DateTime endTime = dtPickerResvDateTime.Value.AddHours(duration);

                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();

                    // Fetch the place name
                    SqlCommand cmdFetchPlaceName = new SqlCommand("SELECT PlaceName FROM PlaceOfReservation WHERE PlaceID = @PlaceID", con);
                    cmdFetchPlaceName.Parameters.AddWithValue("@PlaceID", cbbPlaceID.SelectedItem.ToString());
                    placeName = (string)cmdFetchPlaceName.ExecuteScalar();

                    // Check if selected date and time are available for the chosen PlaceID considering duration
                    SqlCommand cmdCheckAvailability = new SqlCommand(
                        "SELECT COUNT(*) FROM Reservation " +
                        "WHERE PlaceID = @PlaceID " +
                        "AND (ReservedDateTime < @EndTime) AND (DATEADD(hour, Duration, ReservedDateTime) > @ReservedDateTime)", con);
                    cmdCheckAvailability.Parameters.AddWithValue("@PlaceID", cbbPlaceID.Text);
                    cmdCheckAvailability.Parameters.AddWithValue("@ReservedDateTime", dtPickerResvDateTime.Value);
                    cmdCheckAvailability.Parameters.AddWithValue("@EndTime", endTime);

                    int existingReservations = (int)cmdCheckAvailability.ExecuteScalar();
                    if (existingReservations > 0)
                    {
                        MessageBox.Show("The selected time slot is not available. Please choose another time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ShowAvailableTimeSlots();
                        return;
                    }

                    // Insert the reservation into the database
                    SqlCommand cmd = new SqlCommand("INSERT INTO Reservation (ReservationID, CustomerID, CustomerPax, PlaceID, PlaceName, ReservedDateTime, Duration) VALUES (@ReservationID, @CustomerID, @CustomerPax, @PlaceID, @PlaceName, @ReservedDateTime, @Duration)", con);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@CustomerID", cbbCustomerID.Text); // Assuming CustomerID is selected from ComboBox
                    cmd.Parameters.AddWithValue("@CustomerPax", txtPax.Text);
                    cmd.Parameters.AddWithValue("@PlaceID", cbbPlaceID.Text);
                    cmd.Parameters.AddWithValue("@PlaceName", placeName);
                    cmd.Parameters.AddWithValue("@ReservedDateTime", dtPickerResvDateTime.Value);
                    cmd.Parameters.AddWithValue("@Duration", cbbDuration.Text);
                    cmd.ExecuteNonQuery();

                    // Update ReservationStatus
                    SqlCommand updateCmd = new SqlCommand("UPDATE Reservation SET ReservationStatus = 'APPROVED' WHERE ReservationID = @ReservationID", con);
                    updateCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    updateCmd.ExecuteNonQuery();

                    // Update Customer ReservationID
                    SqlCommand updateCustomerCmd = new SqlCommand("UPDATE Customer SET ReservationID = @ReservationID WHERE CustomerID = @CustomerID", con);
                    updateCustomerCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    updateCustomerCmd.Parameters.AddWithValue("@CustomerID", cbbCustomerID.Text);
                    updateCustomerCmd.ExecuteNonQuery();

                    // Update PlaceOfReservation Reservation
                    Manager.GetReservationIdByPlaceId(con, placeID, newReservationID);

                    /*SqlCommand updatePlaceCmd = new SqlCommand("UPDATE PlaceOfReservation SET ReservationID = @ReservationID WHERE PlaceID = @PlaceID", con);
                    updatePlaceCmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    updatePlaceCmd.Parameters.AddWithValue("@PlaceID", cbbPlaceID.Text);
                    updatePlaceCmd.ExecuteNonQuery();*/




                    // Refresh DataGridView
                    RefreshDataGridView();
                }
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

        private void ShowAvailableTimeSlots()
        {
            // Get the selected date and time
            DateTime selectedDateTime = dtPickerResvDateTime.Value;

            // Define the opening and closing times
            DateTime openingTime = selectedDateTime.Date.AddHours(17); // 5 PM
            DateTime closingTime = selectedDateTime.Date.AddHours(22); // 10 PM

            // Display available time slots
            StringBuilder messageBuilder = new StringBuilder();
            messageBuilder.AppendLine("Available Time Slots:");
            for (DateTime time = openingTime; time < closingTime; time = time.AddHours(1))
            {
                // Check if the time slot is available
                bool isAvailable = IsTimeSlotAvailable(time);

                // If the time slot is available, add it to the message
                if (isAvailable)
                {
                    messageBuilder.AppendLine(time.ToString("hh:mm tt"));
                }
            }

            // Show the available time slots to the user
            MessageBox.Show(messageBuilder.ToString(), "Available Time Slots", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsTimeSlotAvailable(DateTime time)
        {
            // Implement the logic to check if the given time slot is available
            // You can perform a database query to check if there are any reservations for the given time slot
            // For simplicity, I'll return true for all time slots in this example
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cbbCustomerID.Enabled = false;
                cbbCustomerID.DropDownStyle = ComboBoxStyle.DropDownList;
                // Fetch the PlaceName corresponding to the selected PlaceID
                string placeName;
                // Extract the actual ReservationID from lblResv.Text
                // Extract the actual ReservationID from lblResv.Text
                string reservationID = lblResv.Text.Replace("ReservationID: ", "").Trim();
                string customerID = lblCustomerID.Text.Replace("CustomerID: ", "").Trim();
                string placeID = cbbPlaceID.Text.Trim();


                int duration = int.Parse(cbbDuration.Text);
                DateTime endTime = dtPickerResvDateTime.Value.AddHours(duration);

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();

                // Fetch the place name
                SqlCommand cmdFetchPlaceName = new SqlCommand("SELECT PlaceName FROM PlaceOfReservation WHERE PlaceID = @PlaceID", con);
                cmdFetchPlaceName.Parameters.AddWithValue("@PlaceID", cbbPlaceID.SelectedItem.ToString());
                placeName = (string)cmdFetchPlaceName.ExecuteScalar();


                // Check if selected date and time are available for the chosen PlaceID considering duration
                SqlCommand cmdCheckAvailability = new SqlCommand(
                    "SELECT COUNT(*) FROM Reservation WHERE PlaceID = @PlaceID " +
                    "AND ReservationID <> @ReservationID " + // Exclude current reservation
                    "AND (ReservedDateTime < @EndTime) AND (DATEADD(hour, Duration, ReservedDateTime) > @ReservedDateTime)", con);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservationID", reservationID); // Exclude current reservation
                cmdCheckAvailability.Parameters.AddWithValue("@PlaceID", cbbPlaceID.Text);
                cmdCheckAvailability.Parameters.AddWithValue("@ReservedDateTime", dtPickerResvDateTime.Value);
                cmdCheckAvailability.Parameters.AddWithValue("@EndTime", endTime);

                int existingReservations = (int)cmdCheckAvailability.ExecuteScalar();
                if (existingReservations > 0)
                {
                    MessageBox.Show("The selected time slot is not available. Please choose another time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    ShowAvailableTimeSlots();
                    return;
                }


                // Insert the reservation into the database
                SqlCommand cmd = new SqlCommand("UPDATE Reservation SET CustomerPax=@CustomerPax, PlaceID=@PlaceID, PlaceName=@PlaceName, ReservedDateTime=@ReservedDateTime, Duration=@Duration WHERE ReservationID=@ReservationID", con);
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                cmd.Parameters.AddWithValue("@CustomerPax", txtPax.Text);
                cmd.Parameters.AddWithValue("@PlaceID", cbbPlaceID.Text);
                cmd.Parameters.AddWithValue("@PlaceName", placeName);
                cmd.Parameters.AddWithValue("@ReservedDateTime", dtPickerResvDateTime.Value);
                cmd.Parameters.AddWithValue("@Duration", cbbDuration.Text);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    RefreshDataGridView();

                    // Assuming GetReservationIdByPlaceId and DeleteReservationById should update the PlaceOfReservation table
                    string newReservationID = Manager.GetReservationIdByPlaceId(con, placeID, reservationID);
                    Manager.DeleteReservationById(con, placeID, reservationID);

                    MessageBox.Show("Reservation Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("No changes made to the reservation.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            
        }
    }
}
