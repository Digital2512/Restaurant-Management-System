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
            string placeID = database.getString(query);
            this.lblPlaceID.Text = placeID;
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
            
            query = $"SELECT PlaceTime FROM ReservationTimeTable WHERE PlaceID = '{placeID}' AND (TimeStatus = 'AVAILABLE' OR TimeStatus = 'PENDING');";
            startTimeCBox.Items.Clear();
            string placeTimeCBoxInput = null;
            DataTable placeTimeDataTable =  database.getDataTable(query);
            foreach(DataRow row in placeTimeDataTable.Rows)
            {
                int PlaceTime = int.Parse(row["PlaceTime"].ToString());
                if(PlaceTime == 1700)
                {
                    placeTimeCBoxInput = "17:00 (5:00 PM)";
                }else if (PlaceTime == 1800)
                {
                    placeTimeCBoxInput = "18:00 (6:00 PM)";
                }
                else if (PlaceTime == 1900)
                {
                    placeTimeCBoxInput = "19:00 (7:00 PM)";
                }
                else if (PlaceTime == 2000)
                {
                    placeTimeCBoxInput = "20:00 (8:00 PM)";
                }
                else if (PlaceTime == 2100)
                {
                    placeTimeCBoxInput = "21:00 (9:00 PM)";
                }
                else if (PlaceTime == 2200)
                {
                    placeTimeCBoxInput = "22:00 (10:00 PM)";
                }
                startTimeCBox.Items.Add(placeTimeCBoxInput);
            }

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
            int noOfPax = int.Parse(noOfPaxString);
            string customerID = database.getString(query);
            string reservationID = database.GenerateUniqueID("R", "ReservationID", "Reservation");
            string reservedDateTime = reservedDateTimePicker.Text;
            query = $"SELECT Name FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}'";
            string placeName = database.getString(query);
            string placeSpecialInstructions = specialInstructionsRTxtBox.Text;

            string duration = durationCBox.Text;
            int durationTime = 0;
            if(duration == "1 Hour")
            {
                durationTime = 60;
            }
            else if (duration == "1 Hour and 30 Minutes")
            {
                durationTime = 60;
            }
            else if (duration == "2 Hours")
            {
                durationTime = 120;
            }
            else if (duration == "2 Hours and 30 Minutes")
            {
                durationTime = 120;
            }
            else if (duration == "3 Hours")
            {
<<<<<<< HEAD
                durationTime = 150;
            }
            else if (duration == "3 Hours and 30 Minutes")
            {
                durationTime = 180;
            }
            else if (duration == "4 Hours")
            {
                durationTime = 210;
            }
            else if (duration == "")
            {
                durationTime = 240;
            }
            if(noOfPax != 0)
=======
                durationTime = 180;
            }

            string startTimeString = startTimeCBox.Text;
            int startTime = 0;
            if (startTimeString == "17:00 (5:00 PM)")
>>>>>>> Valerie
            {
                startTime = 1700;
            }else if (startTimeString == "18:00 (6:00 PM)")
            {
                startTime = 1800;
            }
            else if (startTimeString == "19:00 (7:00 PM)")
            {
                startTime = 1900;
            }
            else if (startTimeString == "20:00 (8:00 PM)")
            {
                startTime = 2000;
            }
            else if (startTimeString == "21:00 (9:00 PM)")
            {
                startTime = 2100;
            }
            else if (startTimeString == "22:00 (10:00 PM)")
            {
                startTime = 2200;
            }

            if (noOfPax != 0)
            {
                bool noOfPaxChanged = false;
                bool durationTimeChanged = false;
                bool startTimeChanged = false;
                if(noOfPax > minOfPax)
                {
                    noOfPaxChanged = true;
                }
                else
                {
                    lblMinOfPax.Text = "";
                    MessageBox.Show("Min of Pax not Acheived. Please reinput the No of Pax again");
                }

                if(durationTime > 0)
                {
                    durationTimeChanged = true;
                }
                else
                {
                    MessageBox.Show("Please input the Duration Time");
                }

                if (startTime > 0)
                {
                    startTimeChanged = true;
                }
                else
                {
                    MessageBox.Show("Please choose a starting time");
                }
                if (noOfPaxChanged == true && durationTimeChanged == true && startTimeChanged == true)
                {
                    bool reservationChanged = false;
                    bool dateReservationChanged = false;
                    query = $"INSERT INTO Reservation(ReservationID, CustomerID, PlaceName, PlaceCustomerPax, PlaceSpecialInstructions, ReservedDate, ReservationStatus, PlaceID, Duration, ReservedStartTime) VALUES ('{reservationID}', '{customerID}', '{placeName}', '{noOfPax}', '{placeSpecialInstructions}', '{reservedDateTime}', 'PENDING', '{PlaceID}', {durationTime}, '{startTime}')";
                    if(database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        reservationChanged = true;
                    }


                    int reservationTimeTimes = durationTime / 60;
                    int startTimeDatabase = startTime;
                    for(int i = 0; i < reservationTimeTimes; i++)
                    {
                        query = $"UPDATE ReservationTimeTable SET TimeStatus = 'PENDING' WHERE PlaceID = '{PlaceID}' AND PlaceTime = '{startTimeDatabase}';";
                        if (database.insertOrUpdateValuesIntoDatabase(query) == true)
                        {
                            startTimeDatabase = startTimeDatabase + 100;
                            dateReservationChanged = true;
                            continue;
                        }
                        else
                        {
                            dateReservationChanged = false;
                            break;
                        }
                    }

                    if (reservationChanged == true && dateReservationChanged == true)
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
                    MessageBox.Show("Please Fill in all the Required Field");
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
