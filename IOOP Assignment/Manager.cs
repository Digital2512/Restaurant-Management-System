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
        private static string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
        public static void OpenManagerHomePage()
        {
            // Hide the current form
            Form frmcurrent = Form.ActiveForm;
            if (frmcurrent != null)
            {
                frmcurrent.Hide();
            }
            // Open ManagerHomePage
            ManagerHomePage frmMngHome = new ManagerHomePage();
            frmMngHome.ShowDialog();
        }

        public byte[] LoadImage(string imgLocation)
        {
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            return br.ReadBytes((int)stream.Length);

        }

        public static string SelectAndDisplayImage(PictureBox pictureBox)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG files (*.png)|*.png|JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string imgLocation = dialog.FileName;
                pictureBox.ImageLocation = imgLocation;
                return imgLocation;
            }

            return null; // User cancelled the dialog
        }

        //managermenu
        public string GenerateProductID()
        {
            using (SqlConnection con = new SqlConnection(connetionString))
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
                reader.Close();

                // Find the first gap in the sequence
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



        //add reservation
        public string GenerateReservationID()
        {
            // Fetch all ReservationIDs
            SqlConnection con = new SqlConnection(connetionString);
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
            existingIDs.Sort();

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

        //menu 
        public string GenerateRecipeID()
        {
            // Fetch all RecipeIDs
            SqlConnection con = new SqlConnection(connetionString);
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
            existingIDs.Sort();

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


        //ViewProfile and UpdateProfile
        public DataTable GetManagerProfile()
        {
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT UserID, Password, Role, FullName, Gender, Birthday, ProfileImage FROM Users WHERE Role = 'Manager' and LoggedIn = 'TRUE'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }



        //update reservationid POR
        public static string GetReservationIdByPlaceId(SqlConnection con, string placeID, string newReservationID)
        {
            try
            {

                string query = "SELECT ReservationID FROM PlaceOfReservation WHERE PlaceID = @PlaceID ";

                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PlaceID ", placeID);
                SqlDataReader reader = command.ExecuteReader();

                // 读取查询结果
                string reservationID = "";
                while (reader.Read())
                {
                    reservationID = reader["ReservationID"].ToString();

                    break;
                }
                reader.Close();

                // 更新数据库中的 reservationid
                if (!string.IsNullOrEmpty(newReservationID))
                {
                    // get old reservationid
                    string updatedReservationIDs = reservationID + "," + newReservationID;

                    // update
                    string updateQuery = "UPDATE PlaceOfReservation SET ReservationID = @newReservationIds WHERE PlaceID = @PlaceID ";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@newReservationIds", updatedReservationIDs);
                    updateCommand.Parameters.AddWithValue("@PlaceID", placeID);
                    int rowsAffected = updateCommand.ExecuteNonQuery();
                }

                return reservationID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; // return null if there is mistake
            }
        }

        //delete reservationID por
        public static void DeleteReservationById(SqlConnection con, string placeID, string reservationIDToDelete)
        {
            try
            {
                // Retrieve the existing reservation IDs for the place
                string query = "SELECT ReservationID FROM PlaceOfReservation WHERE PlaceID = @PlaceID";
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


                    // Split the existing reservation IDs by comma
                    string[] reservationIDs = existingReservationIDs.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    // Remove the reservation ID to be deleted from the array
                    List<string> updatedReservationIDs = new List<string>(reservationIDs);

                    if (!updatedReservationIDs.Remove(reservationIDToDelete))
                    {
                        MessageBox.Show("Reservation ID not found.");
                        return;
                    }


                    // Join the remaining reservation IDs back into a string
                    string newReservationIDs = string.Join(",", updatedReservationIDs);

                    // Update the PlaceOfReservation table with the new reservation IDs
                    string updateQuery = "UPDATE PlaceOfReservation SET ReservationID = @newReservationIds WHERE PlaceID = @PlaceID";
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

        //display tableinfo new
        public static void DisplayTableInformation(string placeID)
        {
            // Get the current date
            DateTime currentDate = DateTime.Today;

            // Create a StringBuilder to construct the message
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                // Open a connection to the database
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();

                    // SQL query to retrieve reservations for the current date and specified placeID
                    string query = "SELECT r.ReservedStartTime, r.ReservedEndTime, p.PlaceID, p.PlaceName, p.Description FROM Reservation r JOIN PlaceOfReservation p ON r.PlaceID = p.PlaceID WHERE r.PlaceID = @PlaceID AND r.ReservedDate = @CurrentDate AND ReservationStatus = 'APPROVED'";


                    // Create a command with parameters
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PlaceID", placeID);
                        cmd.Parameters.AddWithValue("@CurrentDate", currentDate);


                        // Execute the query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Check if there are reservations
                            if (reader.HasRows)
                            {
                                // Read the first row to get PlaceName and Description
                                reader.Read();
                                string placeName = reader.GetString(reader.GetOrdinal("PlaceName"));
                                string description = reader.GetString(reader.GetOrdinal("Description"));

                                // Append PlaceName and Description to the message
                                messageBuilder.AppendLine(placeName);
                                messageBuilder.AppendLine(description);
                                messageBuilder.AppendLine();

                                // Append reservations to the message
                                messageBuilder.AppendLine("Reservations for today:");

                                // Read the rest of the rows to get reservations
                                do
                                {
                                    int startTime = reader.GetInt32(reader.GetOrdinal("ReservedStartTime"));
                                    int endTime = reader.GetInt32(reader.GetOrdinal("ReservedEndTime"));
                                    messageBuilder.AppendLine($"{startTime}pm - {endTime}pm");
                                } while (reader.Read());
                            }
                            else
                            {
                                // If no reservations, indicate so
                                messageBuilder.AppendLine("No reservations for today.");
                            }
                        }
                    }
                }

                // Display the message box
                MessageBox.Show(messageBuilder.ToString(), placeID, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ShowAvailableTimeSlots(string placeID, DateTime reservedDate)
        {
            StringBuilder messageBuilder = new StringBuilder();

            try
            {
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    // SQL query to retrieve available time slots for the specified placeID and reservedDate
                    string query = @"SELECT ReservedStartTime, ReservedEndTime FROM Reservation
                             WHERE PlaceID = @PlaceID AND ReservedDate = @ReservedDate AND ReservationStatus = 'APPROVED'";

                    // Create a command with parameters
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PlaceID", placeID);
                        cmd.Parameters.AddWithValue("@ReservedDate", reservedDate);

                        // Execute the query
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Append message to inform user about available time slots
                            messageBuilder.AppendLine("The selected place is already booked for the chosen time and date. Following unvailable time slots:");

                            // Read all reserved time slots
                            while (reader.Read())
                            {
                                int startTime = reader.GetInt32(0);
                                int endTime = reader.GetInt32(1);
                                messageBuilder.AppendLine($"{startTime}pm - {endTime}pm");
                            }
                        }
                    }

                    // Display the available time slots to the user
                    MessageBox.Show(messageBuilder.ToString(), "Available Time Slots", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving available time slots: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
