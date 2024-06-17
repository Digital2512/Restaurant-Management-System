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
    public partial class CustomerReservationPage : Form
    {
        //change the connection string when using a different laptop to connect to the database
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public string UserID;
        public CustomerReservationPage(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            Database database = new Database(connectionString);
            string query = "SELECT PlaceID, PlaceName, Description, MinOfPax, EventType FROM PlacesOfReservation";
            DataTable placeDataTable = database.getDataTable(query);

            foreach (DataRow rows in placeDataTable.Rows)
            {
                string placeID = rows["PlaceID"].ToString();
                string placeName = rows["PlaceName"].ToString();
                string placeDescription = rows["Description"].ToString();
                string placeMinofPax = $"{rows["MinOfPax"].ToString()} People";
                string placeEventType = rows["EventType"].ToString();

                query = $"SELECT PlaceImage FROM PlacesOfReservation WHERE PlaceID = '{placeID}';";
                Image PlaceImage = database.getImage(query);

                var placeButton = new placeButton(UserID, placeID, placeName, placeMinofPax, placeDescription, placeEventType, PlaceImage);

                placeDisplayFlowPnl.Controls.Add(placeButton);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            placeDisplayFlowPnl.Controls.Clear();

            Database database = new Database(connectionString);
            string searchString = searchTxtBox.Text;
            string query = $"SELECT PlaceID, PlaceName, Description, MinOfPax, EventType FROM PlacesOfReservation WHERE PlaceName LIKE '{searchString}%'";

            string minOfPaxFilter = minOfPaxCBox.Text;

            string eventFilter = "";
            for(int i = 0; i < eventsCListBox.CheckedItems.Count; i++)
            {
                if (i == eventsCListBox.CheckedItems.Count - 1)
                {
                    eventFilter += $"'{eventsCListBox.CheckedItems[i].ToString()}'";
                }
                else
                {
                    eventFilter += $"'{eventsCListBox.CheckedItems[i].ToString()}',";
                }
            }

            if (minOfPaxFilter != "")
            {
                query += $"AND MinOfPax {minOfPaxFilter}";
            }

            if(eventFilter != "")
            {
                query += $"AND EventType IN ({eventFilter})";
             
            }

            DataTable searchDataTable = database.getDataTable(query);

            foreach(DataRow rows in searchDataTable.Rows)
            {
                string placeID = rows["PlaceID"].ToString().ToLower();
                string placeName = rows["PlaceName"].ToString().ToLower();
                string placeDescription = rows["Description"].ToString().ToLower();
                string placeMinOfPax = rows["MinOfPax"].ToString();
                string placeEventType = rows["EventType"].ToString();
                query = $"SELECT PlaceImage FROM PlacesOfReservation WHERE PlaceID = '{placeID}';";
                Image PlaceImage = database.getImage(query);

                var placeButton = new placeButton(UserID, placeID, placeName, placeMinOfPax, placeDescription, placeEventType, PlaceImage);

                placeDisplayFlowPnl.Controls.Add(placeButton);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage(UserID);
            customerHomePage.Show();
        }
    }
}
