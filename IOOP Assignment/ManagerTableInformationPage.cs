using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{
    public partial class ManagerTableInformationPage : Form
    {
        private string placeID;
        private Manager manager;
        private ManagerReservation managerReservation;

        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public ManagerTableInformationPage(string placeID)
        {
            InitializeComponent();
            this.placeID = placeID;
            manager = new Manager();
            managerReservation = new ManagerReservation();
            LoadTableInformation();
        }

        private void LoadTableInformation()
        {

            string formattedPlaceID = "#" + placeID;
            lblPlaceID.Text = formattedPlaceID;

            DataTable vacantTableInfo = managerReservation.GetVacantTableInfo(placeID);
            DataTable reservedTableInfo = managerReservation.GetReservedTableInfo(placeID);

            if (vacantTableInfo.Rows.Count > 0)
            {
                // Display vacant table information
                DataRow row = vacantTableInfo.Rows[0];
                lblDescription.Text = row["Description"].ToString();
                lblMinOfPax.Text = "Min Of Pax: " + row["MinOfPax"].ToString();
                lblEventType.Text = "Event Type: " + row["EventType"].ToString();

                // Hide reserved table labels and button
                lblReservationID.Hide();
                lblCustomerID.Hide();
                lblPlaceName.Hide();
                lblReservedDateTime.Hide();
                lblDuration.Hide();
                
            }
            else if (reservedTableInfo.Rows.Count > 0)
            {
                // Display reserved table information
                DataRow row = reservedTableInfo.Rows[0];
                lblReservationID.Text = row["ReservationID"].ToString();
                lblCustomerID.Text = row["CustomerID"].ToString();
                lblPlaceName.Text = row["PlaceName"].ToString();
                lblReservedDateTime.Text = row["ReservedDateTime"].ToString();
                lblDuration.Text = row["Duration"].ToString();

                // Hide vacant table labels
                
                lblMinOfPax.Hide();
                lblEventType.Hide();
                btnReserve.Hide();
            }
            else
            {
                MessageBox.Show("No information available for this table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.CloseCurrentPage(this);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            Manager.CloseCurrentPage(this); 
            ManagerAddReservationPage addReservationPage = new ManagerAddReservationPage();
            addReservationPage.ShowDialog();
            

        }
    }
}
