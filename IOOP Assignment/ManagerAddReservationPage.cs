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
        public string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";

        private void ManagerAddReservationPage_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.ShowUpDown = true;

            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT CustomerID FROM Customer WHERE ReservationID IS NULL", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbbCustomerID.DataSource = dt;
                cbbCustomerID.DisplayMember = "CustomerID";

                SqlConnection con2 = new SqlConnection(connetionString);
                con2.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT PlaceID FROM PlaceOfReservation WHERE ReservationID IS NULL", con2);
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                cbbPlaceID.DataSource = dt2;
                cbbPlaceID.DisplayMember = "PlaceID";

                // Debugging: Check if data is correctly loaded
                foreach (DataRow row in dt2.Rows)
                {
                    Console.WriteLine("PlaceID: " + row["PlaceID"]);
                }

                con2.Close();
            }
            catch (SqlException ex)
            {
                // Log or handle the exception
                Console.WriteLine("SQL Error: " + ex.Message);
                // You can also display a message box to the user informing them of the error

            }
            

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string customerID = "C01";
            string placeID = cbbPlaceID.SelectedValue?.ToString();
            string placeName = "Table 1";
            int customerPax = 2;
            int duration = 2;
            DateTime reservedDate = dateTimePicker1.Value.Date;
            DateTime reservedTime = dateTimePicker2.Value;

            
            ManagerReservation.AddReservation(customerID, placeID, placeName, customerPax, reservedDate, reservedTime, duration);
            
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            Manager.CloseCurrentPage(this);
        }

    }
}
