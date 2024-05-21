using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Data.SqlClient;
using System.Data;
=======
using System.IO;
>>>>>>> parent of 3a951e5 (commit ManagerMenuPage)
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.Common;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace IOOP_Assignment
{
    internal class Manager
    {
        
<<<<<<< HEAD
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

        public static string connetionString = "Data Source=DESKTOP-0LAGVB0;Initial Catalog=IOOPDatabase;Integrated Security=True";
        private SqlConnection con;
        private SqlCommand cmd;
        

        
      


        //ManagerTablesPage
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
        
<<<<<<< HEAD
=======
>>>>>>> parent of 3a951e5 (commit ManagerMenuPage)
=======
>>>>>>> parent of 45003f4 (commitMenuPage)
    }
}