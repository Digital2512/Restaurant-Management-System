using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using System.Collections.ObjectModel;

namespace IOOP_Assignment
{
    class Manager
    {
        
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

        public static string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand cmd;
        public void CombineAndInsert(DateTimePicker datetimepicker1, DateTimePicker datetimepicker2)
        {
            // Combine the date from datetimepicker1 and the time from datetimepicker2 into a single DateTime object
            DateTime combinedDateTime = datetimepicker1.Value.Date.Add(datetimepicker2.Value.TimeOfDay);

            SqlConnection con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Reservation ReservedDateTime VALUES (@ReservedDateTime)", con);
            cmd.Parameters.AddWithValue("@ReservedDateTime", combinedDateTime);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static void CloseCurrentPage()
        {
            // Hide the current form
            Form frmcurrent = Form.ActiveForm;
            if (frmcurrent != null)
            {
                frmcurrent.Hide();
            }
          
        }

        public void ShowVacantPlaces(PictureBox pictureBox, Button button)
        {
            UpdatePictureBoxAndButton(pictureBox, button, true);
        }

        public void ShowReservedPlaces(PictureBox pictureBox, Button button)
        {
            UpdatePictureBoxAndButton(pictureBox, button, false);
        }

        private void UpdatePictureBoxAndButton(PictureBox pictureBox, Button button, bool isVacant)
        {
            try
            {
                SqlConnection con = new SqlConnection(connetionString);
                con.Open();
                string sqlQuery = isVacant ?
                    "SELECT ReservationID, CustomerID FROM PlaceOfReservation WHERE ReservationID IS NULL AND CustomerID IS NULL" :
                    "SELECT ReservationID, CustomerID FROM PlaceOfReservation WHERE ReservationID IS NOT NULL AND CustomerID IS NOT NULL";
                cmd = new SqlCommand(sqlQuery, con);


                SqlDataReader reader = cmd.ExecuteReader();

                // Read the data and update the PictureBox and Button visibility
                if (reader.Read())
                {
                    pictureBox.Visible = true;
                    button.Visible = true;
                }
                else
                {
                    pictureBox.Visible = false;
                    button.Visible = false;
                }

                // Close the reader
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (this.con != null && this.con.State == ConnectionState.Open)
                    this.con.Close();
            }

        }

        public static DataTable SearchReservation(string searchInput)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connetionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Menu WHERE ReservationID LIKE @SearchInput OR CustomerID LIKE @SearchInput OR PlaceID LIKE @SearchInput OR PlaceName LIKE @SearchInput OR ReservedDateTime LIKE @SearchInput OR Duration LIKE @SearchInput", con);
                    cmd.Parameters.AddWithValue("@SearchInput", "%" + searchInput + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}