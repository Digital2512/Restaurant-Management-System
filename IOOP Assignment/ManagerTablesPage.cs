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
        private Manager manager;


        public ManagerTablesPage()
        {
            InitializeComponent();
            manager = new Manager();
            txtResvSearch.Text = "Search..."; // Set initial text
            txtResvSearch.Enter += txtResvSearch_Enter; // Handle Enter event
            txtResvSearch.Leave += txtResvSearch_Leave;
            btnVacant.Click += btnVacant_Click;
            btnReserved.Click += btnReserved_Click;

            // Associate click events for buttons
            btnT01.Click += btnT01_Click;
            btnT02.Click += btnT02_Click;
            btnT03.Click += btnT03_Click;
            btnT04.Click += btnT04_Click;
            btnT05.Click += btnT05_Click;
            btnT06.Click += btnT06_Click;
            btnT07.Click += btnT07_Click;
            btnT08.Click += btnT08_Click;
            btnT09.Click += btnT09_Click;
            btnT10.Click += btnT10_Click;
            btnVIP1.Click += btnVIP1_Click;
            btnVIP2.Click += btnVIP2_Click;


        }
        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";



        private ManagerTableInformationPage tableInformationPage;

        private void OpenManagerTableInformationPage(string placeID)
        {
            // Check if the form is already open
            if (tableInformationPage == null || tableInformationPage.IsDisposed)
            {
                // If not, create a new instance
                tableInformationPage = new ManagerTableInformationPage(placeID);
                tableInformationPage.FormClosed += TableInformationPage_FormClosed; // Handle the form closed event
                tableInformationPage.Show(); // Show the form
            }
            else
            {
                // If the form is already open, bring it to the front
                tableInformationPage.BringToFront();
            }
        }

        // Event handler for when the table information page form is closed
        private void TableInformationPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Set the reference to null when the form is closed
            tableInformationPage = null;
        }

        private void RefreshDataGridViewUpcoming()
        {
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUpcoming.DataSource = dt;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void ManagerTablesPage_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationID IS NOT NULL AND CustomerID IS NOT NULL ORDER BY ReservedDateTime", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUpcoming.DataSource = dt;

            /*SqlConnection con2 = new SqlConnection(connetionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Reservation WHERE ReservationStatus = 'Pending' ", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridViewPending.DataSource = dt2;*/

        }



        private void btnT01_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T01");

        }

        private void btnT02_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T02");

        }

        private void btnT03_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T03");

        }

        private void btnT04_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T04");

        }

        private void btnT05_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T05");

        }

        private void btnT06_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T06");
        }


        private void btnT07_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T07");
        }

        private void btnT08_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T08");

        }

        private void btnT09_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T09");
        }

        private void btnT10_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("T10");
        }

        private void btnVIP1_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("VIP01");
        }

        private void btnVIP2_Click(object sender, EventArgs e)
        {
            OpenManagerTableInformationPage("VIP02");
        }

        private void btnVacant_Click(object sender, EventArgs e)
        {

            manager.ShowVacantPlaces(picT01, btnT01);
            manager.ShowVacantPlaces(picT02, btnT02);
            manager.ShowVacantPlaces(picT03, btnT03);
            manager.ShowVacantPlaces(picT04, btnT04);
            manager.ShowVacantPlaces(picT05, btnT05);
            manager.ShowVacantPlaces(picT06, btnT06);
            manager.ShowVacantPlaces(picT07, btnT07);
            manager.ShowVacantPlaces(picT08, btnT08);
            manager.ShowVacantPlaces(picT09, btnT09);
            manager.ShowVacantPlaces(picT10, btnT10);
            manager.ShowVacantPlaces(picVIP01, btnVIP1);
            manager.ShowVacantPlaces(picVIP02, btnVIP2);

        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            manager.ShowReservedPlaces(picT01, btnT01);
            manager.ShowReservedPlaces(picT02, btnT02);
            manager.ShowReservedPlaces(picT03, btnT03);
            manager.ShowReservedPlaces(picT04, btnT04);
            manager.ShowReservedPlaces(picT05, btnT05);
            manager.ShowReservedPlaces(picT06, btnT06);
            manager.ShowReservedPlaces(picT07, btnT07);
            manager.ShowReservedPlaces(picT08, btnT08);
            manager.ShowReservedPlaces(picT09, btnT09);
            manager.ShowReservedPlaces(picT10, btnT10);
            manager.ShowReservedPlaces(picVIP01, btnVIP1);
            manager.ShowReservedPlaces(picVIP02, btnVIP2);
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
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchInput = txtResvSearch.Text.Trim();
                ManagerReservation managerReservation = new ManagerReservation();
                DataTable dt = ManagerReservation.SearchReservation(searchInput);
                if (dt != null)
                {
                    dataGridViewUpcoming.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;
            // Create an instance of ManagerReservation
            ManagerReservation managerReservation = new ManagerReservation();
            DataTable reservations = managerReservation.ReservationSearchDate(selectedDate); // Call the method on the instance
            dataGridViewUpcoming.DataSource = reservations;
        }

        private void dataGridViewUpcoming_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridViewUpcoming.CurrentRow;
            if (row != null)
            {
                // Extract the data from the selected row
                string reservationID = row.Cells["ReservationID"].Value.ToString();
                string customerID = row.Cells["CustomerID"].Value.ToString();
                string placeID = row.Cells["PlaceID"].Value.ToString();
                string placeName = row.Cells["PlaceName"].Value.ToString();
                string minOfPax = row.Cells["PlaceMinOfPax"].Value.ToString();
                string reservedDateTime = row.Cells["ReservedDateTime"].Value.ToString();
                string duration = row.Cells["Duration"].Value.ToString();

                // Open ManagerReservationSuccessfulPage with the extracted data
                ManagerReservationSuccessfulPage frmSuccess = new ManagerReservationSuccessfulPage();
                frmSuccess.ShowDialog();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewUpcoming.CurrentRow;
            if (row != null)
            {
                // Extract the data from the selected row
                if (dataGridViewUpcoming.SelectedRows.Count > 0)
                {
                    string reservationID = dataGridViewUpcoming.SelectedRows[0].Cells["ReservationID"].Value.ToString();
                    ManagerUpdateReservationPage updatePage = new ManagerUpdateReservationPage(reservationID);
                    updatePage.ShowDialog();
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridViewUpcoming.CurrentRow;
            if (row != null)
            {
                // Extract the reservation ID from the selected row
                string reservationID = row.Cells["ReservationID"].Value.ToString();
                ManagerReservation managerReservation = new ManagerReservation();
                managerReservation.DeleteReservation(reservationID);
                RefreshDataGridViewUpcoming();


            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManagerAddReservationPage addReservationPage = new ManagerAddReservationPage();
            addReservationPage.ShowDialog();
        }
    }

}

