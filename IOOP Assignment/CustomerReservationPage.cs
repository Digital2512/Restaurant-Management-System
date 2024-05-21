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
        public string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";
        public CustomerReservationPage()
        {
            InitializeComponent();
            Database database = new Database(connectionString);
            string query = "SELECT PlaceID, Name, Description, MinOfPax, EventType FROM PlacesOfReservation WHERE ReservationID IS NULL";
            DataTable placeDataTable = database.getDataTable(query);

            foreach (DataRow rows in placeDataTable.Rows)
            {
                string placeID = rows["PlaceID"].ToString();
                string placeName = rows["Name"].ToString();
                string placeDescription = rows["Description"].ToString();
                string placeMinofPax = $"{rows["MinOfPax"].ToString()} People";
                string placeEventType = rows["EventType"].ToString();

                query = $"SELECT PlaceImage FROM PlacesOfReservation WHERE PlaceID = '{placeID}';";
                Image PlaceImage = database.getImage(query);

                var placeButton = new placeButton(placeID, placeName, placeMinofPax, placeDescription, placeEventType, PlaceImage);

                placeDisplayFlowPanel.Controls.Add(placeButton);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            placeDisplayFlowPanel.Controls.Clear();

            Database database = new Database(connectionString);
            string searchString = searchTxtBox.Text;
            string query = $"SELECT PlaceID, Name, Description, MinOfPax, EventType FROM PlacesOfReservation WHERE ReservationID IS NULL AND Name LIKE '{searchString}%'";

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
                MessageBox.Show(eventFilter);
            }
            MessageBox.Show(eventFilter);

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
                string placeName = rows["Name"].ToString().ToLower();
                string placeDescription = rows["Description"].ToString().ToLower();
                string placeMinOfPax = rows["MinOfPax"].ToString();
                string placeEventType = rows["EventType"].ToString();
                query = $"SELECT PlaceImage FROM PlacesOfReservation WHERE PlaceID = '{placeID}';";
                Image PlaceImage = database.getImage(query);

                var placeButton = new placeButton(placeID, placeName, placeMinOfPax, placeDescription, placeEventType, PlaceImage);

                placeDisplayFlowPanel.Controls.Add(placeButton);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerHomePage customerHomePage = new CustomerHomePage();
            customerHomePage.Show();
        }
    }
}
