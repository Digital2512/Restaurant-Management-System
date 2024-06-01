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
            endTimeCBox.Enabled = false;

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
            
            query = $"SELECT PlaceTime FROM ReservationTimeTable WHERE PlaceID = '{placeID}' AND TimeStatus = 'AVAILABLE';";
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


            MessageBox.Show(startTime.ToString());
            MessageBox.Show(endTime.ToString());
            int durationInt = endTime - startTime;
            MessageBox.Show(durationInt.ToString());
            int durationTime = 0;
            if (durationInt == 100)
            {
                durationTime = 60;
                MessageBox.Show(durationTime.ToString());
            }
            else if (durationInt == 200)
            {
                durationTime = 120;
                MessageBox.Show(durationTime.ToString());
            }
            else if (durationInt == 300)
            {
                durationTime = 180;
                MessageBox.Show(durationTime.ToString());
            }
            else if (durationInt == 400)
            {
                durationTime = 240;
                MessageBox.Show(durationTime.ToString());
            }
            else if (durationInt == 500)
            {
                durationTime = 300;
                MessageBox.Show(durationTime.ToString());
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
                    query = $"INSERT INTO Reservation(ReservationID, CustomerID, PlaceName, PlaceCustomerPax, PlaceSpecialInstructions, ReservedDate, ReservationStatus, PlaceID, Duration, ReservedStartTime, ReservedEndTime) VALUES ('{reservationID}', '{customerID}', '{placeName}', '{noOfPax}', '{placeSpecialInstructions}', '{reservedDateTime}', 'PENDING', '{PlaceID}', {durationTime}, '{startTime}', '{endTime}')";
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

        private void startTimeCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblReservedEndTime.Visible = true;
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

            query = $"SELECT PlaceTime FROM ReservationTimeTable WHERE PlaceID = '{placeID}' AND PlaceTime > {startTime} AND TimeStatus = 'AVAILABLE';";
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
    }
}
