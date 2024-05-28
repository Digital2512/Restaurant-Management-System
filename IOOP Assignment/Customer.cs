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
    internal class Customer
    {
        private string id;
        private string fullName;
        private string dateOfBirth;
        private string gender;
        private string phoneNumber;
        private string email;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }

        public Customer(string id, string fullName, string dateOfBirth, string gender, string phoneNumber, string email)
        {
            this.Id = id;
            this.FullName = fullName;
            this.DateOfBirth = dateOfBirth;
            this.Gender = gender;
            this.PhoneNumber = phoneNumber;
            this.Email = email;

        }

        private string AutoNewID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Top 1 Id from customers order by Id Desc", con);
            object result = cmd.ExecuteScalar();
            con.Close();

            string lastId = result != null ? result.ToString() : "C00";
            string newId = GenerateNextId(lastId);

            return newId;
        }

        private string GenerateNextId(string lastId)
        {
            int numericPart = int.Parse(lastId.Substring(1));
            string newNumericPart = (numericPart + 1).ToString("D2");
            return "C" + newNumericPart;
        }

        //add Customer
        public string addCustomer()
        {
            string status;

            string newId = AutoNewID();

            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into customers(Id,fullName,dateOfBirth,Gender,phoneNumber,Email) values (@id,@name,@dob,@gender,@num,@em)", con);
            cmd.Parameters.AddWithValue("@id", newId);
            cmd.Parameters.AddWithValue("@name", fullName);
            cmd.Parameters.AddWithValue("@dob", dateOfBirth);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@num", phoneNumber);
            cmd.Parameters.AddWithValue("@em", Email);

            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                con.Open();
                SqlCommand cmd2 = new SqlCommand("insert into Users(UserID, password, role, LoggedIn) values(@id,'123','customer','True')", con);
                cmd2.Parameters.AddWithValue("@id", newId);

                int userRowsAffected = cmd2.ExecuteNonQuery();
                con.Close();

                if (userRowsAffected > 0)
                    status = "Customer Registration Successful.";
                else
                    status = "Unable to register customer in Users table.";
            }
            else
            {
                status = "Unable to register customer.";
            }

            return status;
        }

        public Customer(string connectionString)
        {
            con = new SqlConnection(connectionString);
        }

        public DataTable GetCustomerId()
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("Select Id from customers", con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            return dt;
        }

        public DataTable GetCustomerById(string id)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("Select * from customers where Id = @id", con))
            {
                cmd.Parameters.AddWithValue("id", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            return dt;
        }

        //update customer
        public string updateCustomer(string id, string fullName, string dob, string gender, string phoneNumber, string email)
        {
            string status;
            con.Open();

            SqlCommand cmd = new SqlCommand("Update customers set fullName = @fn, dateOfBirth = @dob, Gender =@gender, phoneNumber = @pn, Email = @em where Id = @id", con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fn", fullName);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@pn", phoneNumber);
            cmd.Parameters.AddWithValue("@em", email);

            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected != 0)
            {
                status = "Customer update successful.";

            }
            else
            {
                status = "Unable to update customer.";
            }
            con.Close();
            return status;
        }

        //delete manager
        public string deleteCustomer(string id)
        {
            string status = "Unable to delete customer";
            bool success = true;
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from users where UserId = @userid", con);
            cmd.Parameters.AddWithValue("@userid", id);
            int rowAffected = cmd.ExecuteNonQuery();

            if (rowAffected == 0)
            {
                status = "Unable to delete customer from Users table.";
                success = false;
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Delete from customers where Id =@id", con);
                cmd2.Parameters.AddWithValue("@id", id);
                int rowAffected2 = cmd2.ExecuteNonQuery();

                if (rowAffected2 == 0)
                {
                    status = "Unable to delete customer from customers table.";
                    success = false;
                }
            }
            if (success)
            {
                status = "Customer Deleted Successfully.";
            }

            con.Close();
            return status;
        }
    }
}
