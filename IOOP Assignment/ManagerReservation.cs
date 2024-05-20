using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace IOOP_Assignment
{
    public class ManagerReservation
    {
        private static string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";

        public string ReservationID;
        public string CustomerID;
        public string PlaceID;
        public string PlaceName;
        public int PlaceMinOfPax;
        public DateTime ReservedDateTime;
        public int Duration;
        public int CustomerPax;
        public DateTime ReservedDate;
        public DateTime ReservedTime;

        //ManagerTablesPage
        public DataTable ReservationSearchDate(DateTime date)
        {
            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ReservationID, CustomerID, PlaceID, PlaceName, PlaceMinOfPax, ReservedDateTime, Duration FROM Reservation WHERE ReservedDateTime = @ReservedDate", con);
            cmd.Parameters.AddWithValue("@ReservedDate", date.Date);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public ManagerReservation GetReservationDetails(string reservationID)
        {
            ManagerReservation reservation = null;
            try
            {
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationID = @ReservationID", con);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reservation = new ManagerReservation() // Remove the misplaced semicolon
                        {
                            ReservationID = reader["ReservationID"].ToString(),
                            CustomerID = reader["CustomerID"].ToString(),
                            PlaceID = reader["PlaceID"].ToString(),
                            PlaceName = reader["PlaceName"].ToString(),
                            PlaceMinOfPax = Convert.ToInt32(reader["PlaceMinOfPax"]),
                            ReservedDateTime = Convert.ToDateTime(reader["ReservedDateTime"]),
                            Duration = Convert.ToInt32(reader["Duration"])
                        };
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving reservation details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return reservation;
        }

        public void DeleteReservation(string reservationID)
        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reservation WHERE ReservationID = @ReservationID", con);
                cmd.Parameters.AddWithValue("@ReservationID", reservationID); // Use the retrieved value
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static DataTable SearchReservation(string searchInput)
        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation WHERE ReservationID LIKE @SearchInput OR CustomerID LIKE @SearchInput OR PlaceID LIKE @SearchInput OR PlaceName LIKE @SearchInput OR ReservedDateTime LIKE @SearchInput OR Duration LIKE @SearchInput", con);
                cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void RejectReservation(string customerID)
        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Reservation WHERE CustomerID = @CustomerID", con);
                cmd.Parameters.AddWithValue("@CustomerID", customerID); // Use the retrieved value
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation rejected");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ManagerTablesInformationPage
        public DataTable GetVacantTableInfo(string placeID)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT PlaceID, Description, MinOfPax, EventType FROM PlaceOfReservation WHERE PlaceID = @PlaceID AND ReservationID IS NULL AND CustomerID IS NULL", con);
                cmd.Parameters.AddWithValue("@PlaceID", placeID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
        }
        public DataTable GetReservedTableInfo(string placeID)
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ReservationID, CustomerID, PlaceID, PlaceName, PlaceMinOfPax, ReservedDateTime, Duration FROM Reservation WHERE PlaceID = @PlaceID AND ReservationID IS NOT NULL AND CustomerID IS NOT NULL", con);
                cmd.Parameters.AddWithValue("@PlaceID", placeID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }


        //ManagerAddReservationPage
        

        public static void AddReservation(string reservationID, string customerID, string placeID, string placeName, int placeMinOfPax, DateTime reservedDate, DateTime reservedTime, int duration)
        {
            try
            {
                // Combine the date from reservedDate and the time from reservedTime into a single DateTime object
                DateTime combinedDateTime = reservedDate.Date.Add(reservedTime.TimeOfDay);


                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Reservation (ReservationID, CustomerID, PlaceID, PlaceName, PlaceMinOfPax, ReservedDateTime, Duration) " +
                    "VALUES (@ReservationID, @CustomerID, @PlaceID, @PlaceName, @PlaceMinOfPax, @ReservedDateTime, @Duration) " +
                    "WHERE PlaceID = @PlaceID AND ReservationID IS NOT NULL AND CustomerID IS NOT NULL",con);

                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@PlaceID", placeID);
                    cmd.Parameters.AddWithValue("@PlaceName", placeName);
                    cmd.Parameters.AddWithValue("@PlaceMinOfPax", placeMinOfPax);
                    cmd.Parameters.AddWithValue("@ReservedDateTime", combinedDateTime);
                    cmd.Parameters.AddWithValue("@Duration", duration);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Reservation added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Show ReservationSuccessfulPage after the user clicks "OK" on the message box
                    ManagerReservationSuccessfulPage reservationSuccessPage = new ManagerReservationSuccessfulPage();
                    reservationSuccessPage.Show();

                }
                    else
                    {
                        MessageBox.Show("No matching place found to add the reservation.");
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the reservation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ManagerReservationSuccessfulPage
        public ManagerReservation reservationSuccessful(string reservationID)
        {
            ManagerReservation reservationDetails = new ManagerReservation();

            try
            {

                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ReservationID, CustomerID, PlaceID, PlaceName, ReservedDateTime, Duration FROM Reservation WHERE ReservationID = @ReservationID", con);
                cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reservationDetails.ReservationID = reader["ReservationID"].ToString();
                    reservationDetails.CustomerID = reader["CustomerID"].ToString();
                    reservationDetails.PlaceID = reader["PlaceID"].ToString();
                    reservationDetails.PlaceName = reader["PlaceName"].ToString();
                    DateTime reservedDateTime = Convert.ToDateTime(reader["ReservedDateTime"]);
                    reservationDetails.ReservedDate = Convert.ToDateTime(reader["ReservedDateTime"]);
                    reservationDetails.ReservedTime = Convert.ToDateTime(reader["ReservedDateTime"]);
                    reservationDetails.Duration = Convert.ToInt32(reader["Duration"]);

                }
                reader.Close();
                
            }
            catch (Exception ex)
            {
                // Handle exception
            }

            return reservationDetails;
        }
    }

}





