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
        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private void RefreshDataGridView()
        {
            SqlConnection con = new SqlConnection(connetionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PlaceOfReservation", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.OpenManagerHomePage();
        }

        private void ManagerTablesPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM PlaceOfReservation WHERE ReservationID IS NULL AND CustomerID IS NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            

            SqlConnection con2 = new SqlConnection(connetionString);
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Reservation WHERE ReservationID IS NOT NULL AND CustomerID IS NOT NULL ORDER BY ReservedDateTime", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridViewUpcoming.DataSource = dt2;

        }

      

        private void btnT01_Click(object sender, EventArgs e)
        {
            string placeID = "T01"; // Example place ID
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }

        private void btnT02_Click(object sender, EventArgs e)
        {
            string placeID = "T02";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }

        private void btnT03_Click(object sender, EventArgs e)
        {
            string placeID = "T03";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }

        private void btnT04_Click(object sender, EventArgs e)
        {
            string placeID = "T04";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }

        private void btnT05_Click(object sender, EventArgs e)
        {
            string placeID = "T05";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }

        private void btnT06_Click(object sender, EventArgs e)
        {
            string placeID = "T06";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }
        
            
        

        
            
        private void btnT07_Click(object sender, EventArgs e)
        {
            string placeID = "T07";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();
        }
    

    

        

        private void btnT08_Click(object sender, EventArgs e)
        {
            string placeID = "T08";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();

        }

        private void btnT09_Click(object sender, EventArgs e)
        {
            string placeID = "T09";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();
        }

        private void btnT10_Click(object sender, EventArgs e)
        {
            string placeID = "T10";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();
        }

        private void btnVIP1_Click_1(object sender, EventArgs e)
        {
            string placeID = "VIP01";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();
        }

        private void btnVIP1_Click(object sender, EventArgs e)
        {
            string placeID = "VIP01";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();
        }

        private void btnVIP2_Click(object sender, EventArgs e)
        {
            string placeID = "VIP02";
            ManagerTableInformationPage frmTableInfo = new ManagerTableInformationPage(placeID);
            frmTableInfo.ShowDialog();
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
                DataTable dt = Manager.SearchReservation(searchInput);
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
    }

}

