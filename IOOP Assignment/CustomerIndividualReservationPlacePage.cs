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
            string query = $"SELECT PlaceID FROM Reservation WHERE Chosen = 'TRUE';";
            this.lblPlaceID.Text = database.getString(query);
            query = $"SELECT Name FROM Reservation WHERE Chosen = 'TRUE';";
            this.lblPlaceName.Text = database.getString(query);
            query = $"SELECT Description FROM Reservation WHERE Chosen = 'TRUE';";
            this.lblPlaceDescription.Text = database.getString(query);
            query = $"SELECT MinOfPax FROM Reservation WHERE Chosen = 'TRUE';";
            this.lblMinOfPax.Text = database.getString(query);
            query = $"SELECT EventType FROM Reservation WHERE Chosen = 'TRUE';";
            this.lblPlaceEventType.Text = database.getString(query);
        }

        private void reserveBtn_Click(object sender, EventArgs e)
        {
            Database database = new Database(connectionString);
            string query = $"SELECT PlaceID FROM Reservation WHERE Chosen = 'TRUE';";
            string PlaceID = database.getString(query);
            query = $"UPDATE Reservation SET ReservationStatus = 'PENDING' WHERE PlaceID = '{PlaceID}';";
            if(database.insertOrUpdateValuesIntoDatabase(query) == true)
            {
                MessageBox.Show("Reservation Request Sent");
                this.Hide();
                CustomerHomePage customerHomePage = new CustomerHomePage();
                customerHomePage.Show();
            }
            else
            {
                MessageBox.Show("Error: Reservation Request Not Sent");
            }
            
        }
    }
}
