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
    public partial class ManagerUpdateReservationPage : Form
    {
        
        
        private string reservationID;
        private ManagerReservation managerReservation;

        public ManagerUpdateReservationPage(string reservationID)
        {
            InitializeComponent();
            this.reservationID = reservationID;
            managerReservation = new ManagerReservation();
            PopulateTextBoxes();
        }
        private void PopulateTextBoxes()
        {
            ManagerReservation reservation = managerReservation.GetReservationDetails(reservationID);
            if (reservation != null)
            
            {   
                lblResvID.Text = reservation.ReservationID;
                cbbCustomerID.Text = reservation.CustomerID;
                cbbPax.Text = cbbPax.Text = reservation.CustomerPax.ToString(); // Assuming cbbPax is a ComboBox for selecting the number of customers
                cbbPlaceID.Text = reservation.PlaceID;
                dateTimePicker1.Value = reservation.ReservedDateTime.Date; // Assuming dateTimePicker1 is the first DateTimePicker for date
                dateTimePicker2.Value = reservation.ReservedTime; // Assuming dateTimePicker2 is the second DateTimePicker for time
                cbbDuration.Text = reservation.Duration.ToString();
            }
            else
            {
                MessageBox.Show("Failed to retrieve reservation details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Close the form if details cannot be retrieved
            }
        }
    }
}
