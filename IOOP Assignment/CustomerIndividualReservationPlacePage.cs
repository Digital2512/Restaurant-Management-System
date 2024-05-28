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
            string MinOfPax = database.getInt(query).ToString();
            this.lblPlaceMinOfPax.Text = $"{MinOfPax} People";
            query = $"SELECT EventType FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceEventType.Text = database.getString(query);
            query = $"SELECT PlaceImage FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.placeImagePBox.Image = database.getImage(query);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = $"SELECT PlaceID FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            string PlaceID = database.getString(query);
            query = $"SELECT MinOfPax FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}';";
            int minOfPax = database.getInt(query);
            query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            string noOfPaxString = noOfPaxTxtBox.Text;
            int noOfPax;
            if (noOfPaxString == "")
            {
                noOfPax = 0;
            }
            else
            {
                noOfPax = int.Parse(noOfPaxString);
            }
            string customerID = database.getString(query);
            string reservationID = database.GenerateUniqueID("R", "ReservationID", "Reservation");
            string reservedDateTime = reservedDateTimePicker.Text;
            query = $"SELECT Name FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}'";
            string placeName = database.getString(query);
            string placeSpecialInstructions = specialInstructionsRTxtBox.Text;

            string duration = durationCBox.Text;
            int durationTime = 0;
            if(duration == "30 Minutes")
            {
                durationTime = 30;
            }
            else if (duration == "2 Hours")
            {
                durationTime = 90;
            }
            else if (duration == "3 Hours")
            {
                durationTime = 150;
            }
            else if (duration == "")
            {
                durationTime = 240;
            }

            if(noOfPax != 0)
            {
                if (noOfPax > minOfPax)
                {
                    query = $"INSERT INTO Reservation(ReservationID, CustomerID, PlaceName, PlaceCustomerPax, PlaceSpecialInstructions, ReservedDateTime, ReservationStatus, PlaceID, Duration) VALUES ('{reservationID}', '{customerID}', '{placeName}', '{noOfPax}', '{placeSpecialInstructions}', '{reservedDateTime}', 'PENDING', '{PlaceID}', {durationTime})";
                    if (database.insertOrUpdateValuesIntoDatabase(query) == true)
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
                else
                {
                    MessageBox.Show("The min of pax has not been achieved. Please reinput the min of pax again");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number of pax");
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
