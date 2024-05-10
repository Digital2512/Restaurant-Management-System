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
    public partial class CustomerIndividualReservationPlacePage : Form
    {
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerIndividualReservationPlacePage()
        {
            InitializeComponent();
            Database database = new Database(connectionString);
            string query = $"SELECT PlaceID FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceID.Text = database.getString(query);
            query = $"SELECT Name FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceName.Text = database.getString(query);
            query = $"SELECT Description FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceDescription.Text = database.getString(query);
            query = $"SELECT MinOfPax FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblMinOfPax.Text = database.getInt(query).ToString();
            query = $"SELECT EventType FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceEventType.Text = database.getString(query);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = $"SELECT PlaceID FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            string PlaceID = database.getString(query);
            query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string customerID = database.getString(query);
            string reservationID = database.GenerateUniqueID("R", "ReservationID", "Reservation");
            string reservedDateTime = reservedDateTimePicker.Text;
            query = $"SELECT Name FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}'";
            string placeName = database.getString(query);
            query = $"SELECT MinOfPax FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}'";
            int placeMinOfPax = database.getInt(query);
            string placeSpecialInstructions = specialInstructionsRTxtBox.Text;
            query = $"INSERT INTO Reservation(ReservationID, CustomerID, PlaceName, PlaceMinOfPax, PlaceSpecialInstructions, ReservedDateTime, ReservationStatus, PlaceID) VALUES ('{reservationID}', '{customerID}', '{placeName}', '{placeMinOfPax}', '{placeSpecialInstructions}', '{reservedDateTime}', 'PENDING', '{PlaceID}')";
            if(database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                MessageBox.Show("Reservation Request Sent");
                query = $"UPDATE PlacesOfReservation SET Chosen = 'FALSE' WHERE PlaceID = '{PlaceID}';";
                this.Hide();
                CustomerHomePage customerHomePage = new CustomerHomePage();
                customerHomePage.Show();
            }
            else if (database.insertOrUpdateValuesIntoDatabase(query) != true)
            {
                MessageBox.Show("Error: Reservation Request Not Sent");
            }
            else
            {
                MessageBox.Show("An error occured");
            }
            
        }

        private void lblEventType_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerReservationPage customerReservationPage = new CustomerReservationPage();
            customerReservationPage.Show();
        }
    }
}
