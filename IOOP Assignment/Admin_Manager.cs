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
    internal class Admin_Manager
    {
        private string id;
        private string fullName;
        private string dateOfBirth;
        private string gender;
        private string phoneNumber;
        private string email;
        private string skills;
        private string educationalBackground;

        //change the connection string when using a different laptop to connect to the database
        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-9JG6P7V;Initial Catalog=IOOPDatabase;Integrated Security=True");

        public string Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Skills { get => skills; set => skills = value; }
        public string EducationalBackground { get => educationalBackground; set => educationalBackground = value; }

        public Admin_Manager(string Id, string fullName, string dateOfBirth, string gender, string phoneNumber, string email, string skills, string educationalBackground)
        {
            this.Id = Id;
            this.fullName = fullName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.skills = skills;
            this.educationalBackground = educationalBackground;
        }

        private string AutoNewId()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM manager ORDER BY Id DESC", con);
            object result = cmd.ExecuteScalar();
            con.Close();

            string lastId = result != null ? result.ToString() : "M00";
            string newId = GenerateNextId(lastId);

            return newId;
        }

        private string GenerateNextId(string lastId)
        {
            int numericPart = int.Parse(lastId.Substring(1)); 
            string newNumericPart = (numericPart + 1).ToString("D2"); 
            return "M" + newNumericPart;
        }

        //Add Manager
        public string addManager()
        {
            string status;

            string newId = AutoNewId();

            DateTime dob;
            if (!DateTime.TryParse(dateOfBirth, out dob))
            {
                return "Invalid date of birth format.";
            }
            string Dob = dob.ToString("yyyy-MM-dd");

            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO manager(Id,fullName, dateOfBirth, Gender, phoneNumber, Email, Skills, educationalBackground) VALUES (@id,@name, @dob, @gender, @num, @em, @skills, @eb)", con);            
            cmd.Parameters.AddWithValue("@id", newId);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@dob", Dob);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@num", phoneNumber);
            cmd.Parameters.AddWithValue("@em", Email);
            cmd.Parameters.AddWithValue("@skills", Skills);
            cmd.Parameters.AddWithValue("@eb", educationalBackground);

            int rowsAffected = cmd.ExecuteNonQuery(); 
            con.Close();

            if (rowsAffected > 0)
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand($"INSERT INTO Users(UserID,role,LoggedIn,FullName,Gender,Birthday) VALUES(@id, 'MANAGER','TRUE',@name,@gender,@dob)", con);
                cmd2.Parameters.AddWithValue("@id", newId);
                cmd2.Parameters.AddWithValue("@name", FullName);
                cmd2.Parameters.AddWithValue("@gender", Gender);
                cmd2.Parameters.AddWithValue("@dob", Dob);


                int usersRowsAffected = cmd2.ExecuteNonQuery(); 
                con.Close();

                if (usersRowsAffected > 0)
                    status = "Manager Registration Successful.";
                else
                    status = "Unable to register manager in Users table.";
            }
            else
            {
                status = "Unable to register manager.";
            }

            return status;
        }

        public Admin_Manager(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }
        public DataTable GetManagerId() 
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SELECT Id FROM manager", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetManagerById(string id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM manager WHERE Id = @id", con))
            {
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        //update manager
        public string updateManager(string id, string fullName, string dob, string gender, string phoneNumber, string email, string educationalBackground, string skills)
        {
            string status;

            DateTime dateOfBirth;
            if (!DateTime.TryParse(dob, out dateOfBirth))
            {
                return "Invalid date of birth format.";
            }
            string Dob = dateOfBirth.ToString("yyyy-MM-dd");

            con.Open();
            SqlCommand cmd = new SqlCommand("Update manager set fullName= @fn,dateOfBirth =@dob, Gender =@gender,phoneNumber = @pn,Email = @em, educationalBackground = @eb,Skills =@skills where Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fn", fullName);
            cmd.Parameters.AddWithValue("@dob", Dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@pn", phoneNumber);
            cmd.Parameters.AddWithValue("@em", email);
            cmd.Parameters.AddWithValue("@eb", educationalBackground);
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
                    status = "Manager Update Successful.";
                }
                else
                    status = "Unable to update manager in Users table.";
            }
            else
            {
                status = "Unable to update manager.";
            }

            con.Close();
            return status;

        }

        //delete manager
        public string deleteManager(string id)
        {
            string status = "Unable to delete manager";
            bool success = true;
            con.Open();
            //delete user id from users table
            SqlCommand cmd = new SqlCommand("delete from users where UserId = @userid", con);
            cmd.Parameters.AddWithValue("@userid", id);
            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected == 0)
            {
                status = "Unable to delete manager from Users table.";
                success = false;
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Delete from manager where Id = @id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                int rowAffected2 = cmd2.ExecuteNonQuery();

                if (rowAffected2 == 0)
                {
                    status = "Unable to delete manager from manager table.";
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
