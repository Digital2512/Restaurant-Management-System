using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Assignment
{

    public class Manager
    {
        private string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";
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

        public static void CloseCurrentPage(Form form)
        {
            form.Close();
        }
        public byte[] LoadImage(string imgLocation)
        {
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(stream);
            return br.ReadBytes((int)stream.Length);

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

        //update reservationid POR

        public static string GetReservationIdByPlaceId(SqlConnection con, string placeID, string newReservationID)
        {
            try
            {
                // 构建查询语句
                string query = "SELECT ReservationID FROM PlaceOfReservation WHERE PlaceID = @PlaceID ";

                // 创建并执行 SqlCommand
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PlaceID ", placeID);
                SqlDataReader reader = command.ExecuteReader();

                // 读取查询结果
                string reservationID = "";
                while (reader.Read())
                {
                    reservationID = reader["ReservationID"].ToString();
                    // 如果只需要一个 reservationId，你可以在找到第一个后立即退出循环
                    break;
                }
                reader.Close();

                // 更新数据库中的 reservationid
                if (!string.IsNullOrEmpty(newReservationID))
                {
                    // 获取旧的 reservationid
                    string updatedReservationIDs = reservationID + "," + newReservationID;

                    // 更新数据库
                    string updateQuery = "UPDATE PlaceOfReservation SET ReservationID = @newReservationIds WHERE PlaceID = @PlaceID ";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@newReservationIds", updatedReservationIDs);
                    updateCommand.Parameters.AddWithValue("@PlaceID", placeID);
                    updateCommand.ExecuteNonQuery();
                }

                return reservationID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null; // 返回 null 表示出现了错误
            }
        }

        //delete reservationID por
        public static void DeleteReservationById(SqlConnection con, string placeID, string reservationIDToDelete)
        {
            try
            {
                // Retrieve the existing reservation IDs for the place
                string query = "SELECT ReservationID FROM PlaceOfReservation WHERE PlaceID = @PlaceID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@PlaceID", placeID);
                SqlDataReader reader = command.ExecuteReader();

                string existingReservationIDs = "";
                while (reader.Read())
                {
                    existingReservationIDs = reader["ReservationID"].ToString();
                    // Since we're just interested in the first value, exit the loop after reading it
                    break;
                }
                reader.Close();

                // Split the existing reservation IDs by comma
                string[] reservationIDs = existingReservationIDs.Split(',');

                // Remove the reservation ID to be deleted from the array
                List<string> updatedReservationIDs = new List<string>(reservationIDs);
                updatedReservationIDs.Remove(reservationIDToDelete);

                // Join the remaining reservation IDs back into a string
                string newReservationIDs = string.Join(",", updatedReservationIDs);

                // Update the PlaceOfReservation table with the new reservation IDs
                string updateQuery = "UPDATE PlaceOfReservation SET ReservationID = @newReservationIds WHERE PlaceID = @PlaceID";
                SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                updateCommand.Parameters.AddWithValue("@newReservationIds", newReservationIDs);
                updateCommand.Parameters.AddWithValue("@PlaceID", placeID);
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //display tableinfo
        public static void DisplayTableInformation(string placeID)
        {
            string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase1;Integrated Security=True";

            string currentDate = DateTime.Today.ToString("MM/dd/yyyy");
            // Define the selected time and duration
            DateTime selectedTime = DateTime.Now; // Assuming selected time is the current time
            TimeSpan duration = TimeSpan.FromHours(2); // Example duration of 2 hours

            // Calculate the end time
            DateTime endTime = selectedTime.Add(duration);

            // Define the current day start and end times
            DateTime currentDayStart = DateTime.Today;
            DateTime currentDayEnd = currentDayStart.AddDays(1).AddSeconds(-1);

            string placeName = ""; // Variable to store PlaceName
            string description = ""; // Variable to store Description
            string reservedDateTimesString = ""; // Variable to store reserved date times

            // Fetch PlaceName and Description for the specified PlaceID
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                SqlCommand cmdPlaceInfo = new SqlCommand("SELECT PlaceName, Description FROM PlaceOfReservation WHERE PlaceID = @PlaceID", con);
                cmdPlaceInfo.Parameters.AddWithValue("@PlaceID", placeID);
                SqlDataReader readerPlaceInfo = cmdPlaceInfo.ExecuteReader();
                if (readerPlaceInfo.Read())
                {
                    placeName = readerPlaceInfo["PlaceName"].ToString();
                    description = readerPlaceInfo["Description"].ToString();
                }
            }

            // Fetch reserved date times for the current day and place ID
            using (SqlConnection con = new SqlConnection(connetionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ReservedDateTime FROM Reservation " +
                            "WHERE PlaceID = @PlaceID AND ReservedDateTime >= @StartTime AND ReservedDateTime <= @EndTime", con);
                cmd.Parameters.AddWithValue("@PlaceID", placeID);
                cmd.Parameters.AddWithValue("@StartTime", currentDayStart);
                cmd.Parameters.AddWithValue("@EndTime", currentDayEnd);
                SqlDataReader reader = cmd.ExecuteReader();

                List<string> reservedDateTimeStrings = new List<string>();
                while (reader.Read())
                {
                    DateTime reservedDateTime = Convert.ToDateTime(reader["ReservedDateTime"]);
                    string reservedDateTimeString = reservedDateTime.ToString("hh:mm tt");
                    reservedDateTimeStrings.Add(reservedDateTimeString);
                }

                // Check if there are no reservations
                if (reservedDateTimeStrings.Count == 0)
                {
                    MessageBox.Show("There are no reservations for this table.", $"#{placeID}", MessageBoxButtons.OK);
                    return; // Exit the method
                }

                // Concatenate reserved date times into a string
                reservedDateTimesString = string.Join("\n", reservedDateTimeStrings);
            }

            // Display the information in a MessageBox
            MessageBox.Show($"Date: {currentDate}\n\nPlace Name: {placeName}\n\nDescription: {description}\n\nReserved Time:\n\n{reservedDateTimesString}\n", $"#{placeID}", MessageBoxButtons.OK);
        }

    }
}

