using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IOOP_Assignment
{
    public partial class CustomerIndividualReservationPlacePage : Form
    {
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string placeID;
        public string eventType;
        public string UserID;
        public CustomerIndividualReservationPlacePage(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            startTimeCBox.Enabled = false;
            endTimeCBox.Enabled = false;

            Database database = new Database(connectionString);
            string query = $"SELECT PlaceID FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            placeID = database.getString(query);
            this.lblPlaceID.Text = placeID;
            query = $"SELECT PlaceName FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceName.Text = database.getString(query);
            query = $"SELECT Description FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.lblPlaceDescription.Text = database.getString(query);
            query = $"SELECT MinOfPax FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            string MinOfPax = database.getInt(query).ToString();
            this.lblPlaceMinOfPax.Text = $"{MinOfPax} People";
            query = $"SELECT EventType FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            string eventTypeFromDatabase = database.getString(query);
            this.eventType = eventTypeFromDatabase;
            this.lblPlaceEventType.Text = eventType;
            query = $"SELECT PlaceImage FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            this.placeImagePBox.Image = database.getImage(query);
            
            /*query = $"SELECT PlaceTime FROM ReservationTimeTable TimeStatus = 'AVAILABLE';";
            startTimeCBox.Items.Clear();
            string placeStartTimeCBoxInput = null;
            DataTable placeStartTimeDataTable =  database.getDataTable(query);
            foreach(DataRow row in placeStartTimeDataTable.Rows)
            {
                int PlaceTime = int.Parse(row["PlaceTime"].ToString());
                if(PlaceTime == 1700)
                {
                    placeStartTimeCBoxInput = "17:00 (5:00 PM)";
                }else if (PlaceTime == 1800)
                {
                    placeStartTimeCBoxInput = "18:00 (6:00 PM)";
                }
                else if (PlaceTime == 1900)
                {
                    placeStartTimeCBoxInput = "19:00 (7:00 PM)";
                }
                else if (PlaceTime == 2000)
                {
                    placeStartTimeCBoxInput = "20:00 (8:00 PM)";
                }
                else if (PlaceTime == 2100)
                {
                    placeStartTimeCBoxInput = "21:00 (9:00 PM)";
                }
                else if (PlaceTime == 2200)
                {
                    placeStartTimeCBoxInput = "22:00 (10:00 PM)";
                }
                startTimeCBox.Items.Add(placeStartTimeCBoxInput);
            }*/
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = $"SELECT PlaceID FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            string PlaceID = database.getString(query);
            query = $"SELECT MinOfPax FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}';";
            int minOfPax = database.getInt(query);
            query = $"SELECT CustomerID FROM Customer WHERE LoggedIn = 'TRUE';";
            int noOfPax = 0;
            string noOfPaxString = noOfPaxTxtBox.Text;
            noOfPax = int.Parse(noOfPaxString);
            string customerID = database.getString(query);
            string reservationID = database.GenerateUniqueID("RSV", "ReservationID", "Reservation");
            DateTime reservedDateTime = reservedDateTimePicker.Value;
            string reservedDate = reservedDateTime.ToString("yyyy-MM-dd");
            query = $"SELECT PlaceName FROM PlacesOfReservation WHERE PlaceID = '{PlaceID}'";
            string placeName = database.getString(query);
            string placeSpecialInstructions = specialInstructionsRTxtBox.Text;

            string startTimeString = startTimeCBox.Text;
            int startTime = 0;
            if (startTimeString == "17:00 (5:00 PM)")
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

            string endTimeString = endTimeCBox.Text;
            int endTime = 0;
            if (endTimeString == "17:00 (5:00 PM)")
            {
                endTime = 1700;
            }
            else if (endTimeString == "18:00 (6:00 PM)")
            {
                endTime = 1800;
            }
            else if (endTimeString == "19:00 (7:00 PM)")
            {
                endTime = 1900;
            }
            else if (endTimeString == "20:00 (8:00 PM)")
            {
                endTime = 2000;
            }
            else if (endTimeString == "21:00 (9:00 PM)")
            {
                endTime = 2100;
            }
            else if (endTimeString == "22:00 (10:00 PM)")
            {
                endTime = 2200;
            }

            int durationInt = endTime - startTime;
            int durationTime = 0;
            if (durationInt == 100)
            {
                durationTime = 60;
            }
            else if (durationInt == 200)
            {
                durationTime = 120;
            }
            else if (durationInt == 300)
            {
                durationTime = 180;
            }
            else if (durationInt == 400)
            {
                durationTime = 240;
            }
            else if (durationInt == 500)
            {
                durationTime = 300;
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
                    query = $"INSERT INTO Reservation(ReservationID, CustomerID, PlaceName, CustomerPax, PlaceSpecialInstructions, ReservedDate, ReservationStatus, PlaceID, Duration, ReservedStartTime, ReservedEndTime, EventType) VALUES ('{reservationID}', '{customerID}', '{placeName}', '{noOfPax}', '{placeSpecialInstructions}', '{reservedDate}', 'PENDING', '{PlaceID}', {durationTime}, '{startTime}', '{endTime}', '{eventType}')";
                    if(database.insertOrUpdateValuesIntoDatabase(query) == true)
                    {
                        reservationChanged = true;
                    }

                    if (reservationChanged == true)
                    {
                        MessageBox.Show("Reservation Request Sent");
                        query = $"UPDATE PlacesOfReservation SET Chosen = 'FALSE' WHERE PlaceID = '{PlaceID}';";
                        if (database.insertOrUpdateValuesIntoDatabase(query) == true) {
                            this.Hide();
                            CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
                            customerHomePage.Show();
                        }
                        else if(database.insertOrUpdateValuesIntoDatabase(query) == true)
                        {
                            MessageBox.Show("Loading failed");
                        }
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
            Database database = new Database(connectionString);
            string query = $"UPDATE PlacesOfReservation SET Chosen = 'FALSE' WHERE PlaceID = '{placeID}';";
            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                this.Hide();
                CustomerReservationPage customerReservationPage = new CustomerReservationPage(UserID);
                customerReservationPage.Show();
            }
            else if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                MessageBox.Show("Loading failed");
            }
        }

        private void startTimeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            endTimeCBox.Enabled = true;

            string startTimeString = startTimeCBox.Text;
            int startTime = 0;
            if (startTimeString == "17:00 (5:00 PM)")
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

            Database database = new Database(connectionString);

            string query = $"SELECT PlaceID FROM PlacesOfReservation WHERE Chosen = 'TRUE';";
            string placeID = database.getString(query);

            query = $"SELECT PlaceTime FROM ReservationTimeTable WHERE PlaceTime > {startTime} AND TimeStatus = 'AVAILABLE';";
            endTimeCBox.Items.Clear();
            string placeEndTimeCBoxInput = null;
            DataTable placeEndTimeDataTable = database.getDataTable(query);

            int previousPlaceTime = 0;

            bool jumpDetected = false;

            foreach (DataRow row in placeEndTimeDataTable.Rows)
            {
                if (jumpDetected)
                {
                    break;
                }
                else
                {
                    int placeTime = int.Parse(row["PlaceTime"].ToString());

                    if (previousPlaceTime != 0 && placeTime - previousPlaceTime > 100)
                    {
                        jumpDetected = true;
                    }
                    else
                    {
                        if (placeTime == 1700)
                        {
                            placeEndTimeCBoxInput = "17:00 (5:00 PM)";
                        }
                        else if (placeTime == 1800)
                        {
                            placeEndTimeCBoxInput = "18:00 (6:00 PM)";
                        }
                        else if (placeTime == 1900)
                        {
                            placeEndTimeCBoxInput = "19:00 (7:00 PM)";
                        }
                        else if (placeTime == 2000)
                        {
                            placeEndTimeCBoxInput = "20:00 (8:00 PM)";
                        }
                        else if (placeTime == 2100)
                        {
                            placeEndTimeCBoxInput = "21:00 (9:00 PM)";
                        }
                        else if (placeTime == 2200)
                        {
                            placeEndTimeCBoxInput = "22:00 (10:00 PM)";
                        }
                        endTimeCBox.Items.Add(placeEndTimeCBoxInput);
                    }

                    previousPlaceTime = placeTime;
                }
            }
        }

        private void reservedDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            startTimeCBox.Enabled = true;

            Database database = new Database(connectionString);

            string query = $"UPDATE ReservationTimeTable SET TimeStatus = 'AVAILABLE';";

            if (database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                DateTime currentReservedDateTime = reservedDateTimePicker.Value;
                string currentReservedDateString = currentReservedDateTime.ToString("yyyy-MM-dd");
                MessageBox.Show(currentReservedDateString);
                query = $"SELECT * FROM Reservation WHERE ReservedDate = '{currentReservedDateString}' AND PlaceID = '{placeID}' AND ReservationStatus = 'APPROVED';";

                DataTable reservationDataTable = database.getDataTable(query);
                foreach (DataRow row in reservationDataTable.Rows)
                {
                    string reservedStartTime = row["ReservedStartTime"].ToString();
                    string reservedEndTime = row["ReservedEndTime"].ToString();
                    string duration = row["Duration"].ToString();
                    int durationInt = int.Parse(duration);

                    int reservationTimeTimes = durationInt / 60;
                    int startTimeDatabase = int.Parse(reservedStartTime);
                    for (int i = 0; i < reservationTimeTimes; i++)
                    {
                        query = $"UPDATE ReservationTimeTable SET TimeStatus = 'UNAVAILABLE' WHERE PlaceTime = '{startTimeDatabase}'";
                        database.insertOrUpdateValuesIntoDatabase(query);

                        startTimeDatabase = startTimeDatabase + 100;
                    }
                }
                query = $"SELECT PlaceTime FROM ReservationTimeTable WHERE TimeStatus = 'AVAILABLE';";
                DataTable checkReservationStartTimeDataTable = database.getDataTable(query);
                string placeStartTimeCBoxInput = "";
                startTimeCBox.Items.Clear();

                foreach (DataRow row in checkReservationStartTimeDataTable.Rows)
                {
                    string placeTimeString = row["PlaceTime"].ToString();
                    int placeStartTime = int.Parse(placeTimeString);

                    if (placeStartTime == 1700)
                    {
                        placeStartTimeCBoxInput = "17:00 (5:00 PM)";
                    }
                    else if (placeStartTime == 1800)
                    {
                        placeStartTimeCBoxInput = "18:00 (6:00 PM)";
                    }
                    else if (placeStartTime == 1900)
                    {
                        placeStartTimeCBoxInput = "19:00 (7:00 PM)";
                    }
                    else if (placeStartTime == 2000)
                    {
                        placeStartTimeCBoxInput = "20:00 (8:00 PM)";
                    }
                    else if (placeStartTime == 2100)
                    {
                        placeStartTimeCBoxInput = "21:00 (9:00 PM)";
                    }
                    startTimeCBox.Items.Add(placeStartTimeCBoxInput);
                }
                startTimeCBox.Enabled = true;
            }else if(database.insertOrUpdateValuesIntoDatabase(query) == false)
            {
                MessageBox.Show("Table not Cleared");
            }
            else
            {
                MessageBox.Show("Error");
            }
            }
        }
    }
