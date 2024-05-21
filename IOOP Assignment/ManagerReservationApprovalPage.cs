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
            string reservationID = "R001";
            string customerID = "C01";
            string placeID = "T001";
            string placeName = "Table 1";
            int customerPax = 2;
            int duration = 2;
            DateTime reservedDate = datetimepicker1.Value.Date;
            DateTime reservedTime = datetimepicker2.Value;

            ManagerReservation.AddReservation(customerID, placeID, placeName, customerPax, reservedDate, reservedTime, duration);
            
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
