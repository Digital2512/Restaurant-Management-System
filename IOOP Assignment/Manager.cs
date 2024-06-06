using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace IOOP_Assignment
{
    internal class Manager
    {
        private static string connectionString = "Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True";

        public static void OpenManagerHomePage()
        {
            // Hide the current form
            Form currentForm = Form.ActiveForm;
            if (currentForm != null)
            {
                currentForm.Hide();
            }
            // Open ManagerHomePage
            using (ManagerHomePage managerHomePage = new ManagerHomePage())
            {
                managerHomePage.ShowDialog();
            }
        }

        public byte[] LoadImage(string imgLocation)
        {
            using (FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read))
            using (BinaryReader br = new BinaryReader(stream))
            {
                return br.ReadBytes((int)stream.Length);
            }
        }

        // Generate ProductID
        public string GenerateProductID()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductID FROM Menu ORDER BY ProductID", con);
                SqlDataReader reader = cmd.ExecuteReader();

                List<int> existingIDs = new List<int>();
                while (reader.Read())
                {
                    string productId = reader["ProductID"].ToString();
                    int id = int.Parse(productId.Substring(1));
                    existingIDs.Add(id);
                }

                int newID = 1;
                for (int i = 1; i <= existingIDs.Count + 1; i++)
                {
                    if (!existingIDs.Contains(i))
                    {
                        newID = i;
                        break;
                    }
                }

                return "P" + newID.ToString("D3");
            }
        }

        // Generate ReservationID
        public string GenerateReservationID()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ReservationID FROM [Reservation] ORDER BY ReservationID", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtReservation = new DataTable();
                da.Fill(dtReservation);

                List<int> existingIDs = new List<int>();
                foreach (DataRow row in dtReservation.Rows)
                {
                    string reservationID = row["ReservationID"].ToString();
                    if (reservationID.StartsWith("RSV") && int.TryParse(reservationID.Substring(3), out int idNumber))
                    {
                        existingIDs.Add(idNumber);
                    }
                }

                int newIDNumber = 1;
                for (int i = 0; i < existingIDs.Count; i++)
                {
                    if (existingIDs[i] != newIDNumber)
                    {
                        break;
                    }
                    newIDNumber++;
                }

                return $"RSV{newIDNumber:D3}";
            }
        }

        // Generate RecipeID
        public string GenerateRecipeID()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT RecipeID FROM RecipeStock ORDER BY RecipeID", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtRecipe = new DataTable();
                da.Fill(dtRecipe);

                List<int> existingIDs = new List<int>();
                foreach (DataRow row in dtRecipe.Rows)
                {
                    string recipeID = row["RecipeID"].ToString();
                    if (recipeID.StartsWith("R") && int.TryParse(recipeID.Substring(1), out int idNumber))
                    {
                        existingIDs.Add(idNumber);
                    }
                }

                int newIDNumber = 1;
                for (int i = 0; i < existingIDs.Count; i++)
                {
                    if (existingIDs[i] != newIDNumber)
                    {
                        break;
                    }
                    newIDNumber++;
                }

                return $"R{newIDNumber:D3}";
            }
        }

        // Get Manager Profile
        public DataTable GetManagerProfile()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT UserID, Password, Role, FullName, Gender, Birthday, ProfileImage FROM Users WHERE Role = 'Manager' and LoggedIn = 'TRUE'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        // Get ReservationID by PlaceID
        public static string GetReservationIdByPlaceId(SqlConnection con, string placeID, string newReservationID)
        {
            try
            {
                string query = "SELECT ReservationID FROM PlacesOfReservation WHERE PlaceID = @PlaceID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@PlaceID", placeID);
                    SqlDataReader reader = command.ExecuteReader();

                    string reservationID = "";
                    if (reader.Read())
                    {
                        reservationID = reader["ReservationID"].ToString();
                    }
                    reader.Close();

                    if (!string.IsNullOrEmpty(newReservationID))
                    {
                        string updatedReservationIDs = reservationID + "," + newReservationID;

                        string updateQuery = "UPDATE PlacesOfReservation SET ReservationID = @newReservationIds WHERE PlaceID = @PlaceID";
                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@newReservationIds", updatedReservationIDs);
                            updateCommand.Parameters.AddWithValue("@PlaceID", placeID);
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    return reservationID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }

        // Delete Reservation by ID
        public static void DeleteReservationById(SqlConnection con, string placeID, string reservationIDToDelete)
        {
            try
            {
                string query = "SELECT ReservationID FROM PlacesOfReservation WHERE PlaceID = @PlaceID";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@PlaceID", placeID);
                    SqlDataReader reader = command.ExecuteReader();

                    string existingReservationIDs = "";
                    if (reader.Read())
                    {
                        existingReservationIDs = reader["ReservationID"].ToString();
                    }
                    reader.Close();

                    if (string.IsNullOrEmpty(existingReservationIDs))
                    {
                        MessageBox.Show("No reservations found for the provided PlaceID.");
                        return;
                    }

                    string[] reservationIDs = existingReservationIDs.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    List<string> updatedReservationIDs = new List<string>(reservationIDs);

                    if (!updatedReservationIDs.Remove(reservationIDToDelete))
                    {
                        MessageBox.Show("Reservation ID not found.");
                        return;
                    }

                    string newReservationIDs = string.Join(",", updatedReservationIDs);

                    string updateQuery = "UPDATE PlacesOfReservation SET ReservationID = @newReservationIds WHERE PlaceID = @PlaceID";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                    {
                        updateCommand.Parameters.AddWithValue("@newReservationIds", newReservationIDs);
                        updateCommand.Parameters.AddWithValue("@PlaceID", placeID);
                        updateCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Display Table Information
        public static void DisplayTableInformation(string placeID)
        {
            DateTime currentDate = DateTime.Today;
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT r.ReservedStartTime, r.ReservedEndTime, p.PlaceID, p.PlaceName, p.Description 
                                 FROM Reservation r 
                                 JOIN PlacesOfReservation p ON r.PlaceID = p.PlaceID 
                                 WHERE r.PlaceID = @PlaceID AND r.ReservedDate = @CurrentDate AND ReservationStatus = 'APPROVED'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PlaceID", placeID);
                        cmd.Parameters.AddWithValue("@CurrentDate", currentDate);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                string placeName = reader.GetString(reader.GetOrdinal("PlaceName"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));

                                messageBuilder.AppendLine(placeName);
                                messageBuilder.AppendLine(description);
                                messageBuilder.AppendLine();
                                messageBuilder.AppendLine("Reservations for today:");

                                do
                                {
                                    int startTime = reader.GetInt32(reader.GetOrdinal("ReservedStartTime"));
                                    int endTime = reader.GetInt32(reader.GetOrdinal("ReservedEndTime"));
                                    messageBuilder.AppendLine($"{startTime}pm - {endTime}pm");
                                } while (reader.Read());
                            }
                            else
                            {
                                messageBuilder.AppendLine("No reservations for today.");
                            }
                        }
                    }
                }

                MessageBox.Show(messageBuilder.ToString(), placeID, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Show Reserved Time Slots
        public static void ShowReservedTimeSlots(string placeID, DateTime reservedDate)
        {
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT ReservedStartTime, ReservedEndTime 
                                 FROM Reservation
                                 WHERE PlaceID = @PlaceID AND ReservedDate = @ReservedDate AND ReservationStatus = 'APPROVED'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PlaceID", placeID);
                        cmd.Parameters.AddWithValue("@ReservedDate", reservedDate);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            messageBuilder.AppendLine("The selected place is already booked for the chosen time and date. Following unavailable time slots:");

                            while (reader.Read())
                            {
                                int startTime = reader.GetInt32(0);
                                int endTime = reader.GetInt32(1);
                                messageBuilder.AppendLine($"{startTime}pm - {endTime}pm");
                            }
                        }
                    }

                    MessageBox.Show(messageBuilder.ToString(), "Unavailable Time Slots", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving available time slots: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
