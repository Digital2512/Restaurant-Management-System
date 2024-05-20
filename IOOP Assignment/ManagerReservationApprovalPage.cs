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
    public partial class ManagerReservationApprovalPage : Form
    {
        private Manager manager;
        private ManagerReservation managerReservation;
        private DateTimePicker datetimepicker1 = new DateTimePicker();
        private DateTimePicker datetimepicker2 = new DateTimePicker();
        public ManagerReservationApprovalPage()
        {
            InitializeComponent();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            string reservationID = "123456";
            string customerID = "789";
            string placeID = "ABC";
            string placeName = "Place Name";
            int placeMinOfPax = 2;
            int duration = 2;

            ManagerReservation.AddReservation(reservationID, customerID, placeID, placeName, placeMinOfPax, datetimepicker1.Value, datetimepicker2.Value, duration);
            MessageBox.Show("Reservation added successfully.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Manager.CloseCurrentPage(this);
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            string customerID = "your_customer_id_here"; // Provide the actual customer ID
            ManagerReservation managerReservation = new ManagerReservation(); // Instantiate the ManagerReservation class
            managerReservation.RejectReservation(customerID); 
            
        }
    }
}
