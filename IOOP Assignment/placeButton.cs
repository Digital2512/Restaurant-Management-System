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
    public partial class placeButton : UserControl
    {
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        public string PlaceID { get; set; }
        public string UserID;
        public placeButton(string userID, string placeID, string placeName, string placeMinOfPax, string placeDescription, string placeEvents, Image placeImage)
        {
            InitializeComponent();
            this.UserID = userID;
            this.lblPlaceID.Text = placeID;
            this.lblPlaceName.Text = placeName;
            this.lblDescriptions.Text = placeDescription;
            this.lblMinOfPax.Text = placeMinOfPax;
            this.lblEvents.Text = placeEvents;
            this.placeImagePBox.Image = placeImage;
            PlaceID = placeID;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                Database database = new Database(connectionString);
                string query = $"UPDATE PlacesOfReservation SET Chosen = 'TRUE' WHERE PlaceID = '{PlaceID}'";
                database.insertOrUpdateValuesIntoDatabase(query);

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }

                CustomerIndividualReservationPlacePage customerIndividualReservationPlace = new CustomerIndividualReservationPlacePage(UserID);
                customerIndividualReservationPlace.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
