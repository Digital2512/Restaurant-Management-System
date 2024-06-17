using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment
{
    internal class Chef
    {
        private string id;
        private string fullName;
        private string dateOfBirth;
        private string gender;
        private string phoneNumber;
        private string email;
        private string skills;
        private string chefPositions;

        //change the connection string when using a different laptop to connect to the database
        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True");

        public string Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Skills { get => skills; set => skills = value; }
        public string ChefPositions { get => chefPositions; set => chefPositions = value; }

        public Chef(string id, string fullName, string dateOfBirth, string gender, string phoneNumber, string email, string skills, string chefPositions)
        {
            this.Id = id;
            this.FullName = fullName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Skills = skills;
            this.ChefPositions = chefPositions;

        }

        private string AutoNewID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select TOP 1 Id from chef order by Id Desc", con);
            object result = cmd.ExecuteScalar();
            con.Close();

            string lastId = result != null ? result.ToString() : "CH00";
            string newId = GenerateNextId(lastId);

            return newId;
        }
        private string GenerateNextId(string lastId)
        {
            if (lastId.Length < 3 || !lastId.StartsWith("CH") || !int.TryParse(lastId.Substring(2), out int numericPart))
            {
                return "CH00";
            }

            string newNumericPart = (numericPart + 1).ToString("D2");

            return "CH" + newNumericPart;
        }
        //add chef
        public string addChef()
        {
            string status;

            string newID = AutoNewID();

            DateTime dob;
            if (!DateTime.TryParse(dateOfBirth, out dob))
            {
                return "Invalid date of birth format.";
            }
            string Dob = dob.ToString("yyyy-MM-dd");

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into chef(Id,fullName,dateOfBirth,Gender,phoneNumber,Email,Skills,chefPositions) values(@id,@name,@dob,@gender,@num,@em,@skills,@cp)", con);
            cmd.Parameters.AddWithValue("@id", newID);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@dob", Dob);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@num", phoneNumber);
            cmd.Parameters.AddWithValue("@em", Email);
            cmd.Parameters.AddWithValue("@skills", Skills);
            cmd.Parameters.AddWithValue("@cp", ChefPositions);

            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("Insert into Users(UserID,role,LoggedIn,FullName,Gender,Birthday) values(@id, 'CHEF','TRUE',@name,@gender,@dob)", con);
                cmd2.Parameters.AddWithValue("@id", newID);
                cmd2.Parameters.AddWithValue("@name", FullName);
                cmd2.Parameters.AddWithValue("@gender", Gender);
                cmd2.Parameters.AddWithValue("@dob", Dob);

                int usersRowAffected = cmd2.ExecuteNonQuery();
                con.Close();

                if (usersRowAffected > 0)
                    status = "Chef Registration Successful";
                else
                    status = "Unable to register chef in Users table.";
            }

            else
            {
                status = "Unable to register chef.";
            }

            return status;
        }

        public Chef(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }

        public DataTable GetChefId()
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("Select Id from chef", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetChefById(string id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("Select * from chef where Id = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //update chef
        public string updateChef(string id, string fullName, string dob, string gender, string phoneNumber, string email, string chefPositions, string skills)
        {
            string status;

            DateTime dateOfBirth;
            if (!DateTime.TryParse(dob, out dateOfBirth))
            {
                return "Invalid date of birth format.";
            }
            string Dob = dateOfBirth.ToString("yyyy-MM-dd");

            con.Open();
            SqlCommand cmd = new SqlCommand("update chef set fullName = @fn, dateOfBirth = @dob, Gender = @gender, phoneNumber = @pn,Email=@em, chefPositions = @cp,Skills= @skills where Id =@id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fn", fullName);
            cmd.Parameters.AddWithValue("@dob", Dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@pn", phoneNumber);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@cp", chefPositions);
            cmd.Parameters.AddWithValue("@skills", skills);

            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected > 0)
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE Users SET fullName = @fn, Gender = @gender, Birthday = @dob WHERE UserID = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                cmd2.Parameters.AddWithValue("@fn", fullName);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.Parameters.AddWithValue("@dob", Dob);

                int usersRowsAffected = cmd2.ExecuteNonQuery();

                if (usersRowsAffected > 0)
                {
                    status = "Chef Update Successful.";
                }
                else
                    status = "Unable to update chef in Users table.";
            }
            else
            {
                status = "Unable to update chef.";
            }

            con.Close();
            return status;
        }

        //delete chef
        public string deleteChef(string id)
        {
            string status = "Unable to delete chef";
            bool success = true;
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from Users where UserId =@userid", con);
            cmd.Parameters.AddWithValue("@userid", id);
            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected == 0)
            {
                status = "Unable to delete chef from Users table.";
                success = false;
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Delete from chef where Id = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                int rowAffected2 = cmd2.ExecuteNonQuery();

                if (rowAffected2 == 0)
                {
                    status = "Unabale to delete chef from chef table.";
                    success = false;
                }
            }
            if (success)
            {
                status = "Manager Deleted Successfully.";
            }

            con.Close();
            return status;

        }
    }
}
