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
    public partial class ManagerAddReservationPage : Form
    {
        private Manager manager;
        private ManagerReservation managerReservation;
        private DateTimePicker datetimepicker1 = new DateTimePicker();
        private DateTimePicker datetimepicker2 = new DateTimePicker();
        public ManagerAddReservationPage()
        {
            InitializeComponent();
            managerReservation = new ManagerReservation();
        }
        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";

        private void ManagerAddReservationPage_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;

            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Description FROM PlaceOfReservation WHERE ReservationID IS NULL AND CustomerID IS NULL", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbbPlaceID.DataSource = dt;
            cbbPlaceID.DisplayMember = "Description";

            SqlConnection con2 = new SqlConnection(connetionString);
            SqlCommand cmd2 = new SqlCommand("SELECT CustomerID FROM Customer WHERE ReservationID IS NULL AND OrderID IS NULL", con2);
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cbbCustomerID.DataSource = dt2;
            cbbCustomerID.DisplayMember = "CustomerID";

        }

        private void btnSave_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Manager.CloseCurrentPage(this);
        }
    }
}
