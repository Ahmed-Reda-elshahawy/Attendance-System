using Attendance_System.DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.BusinessLayer
{
    public class AuthBL
    {
        // Method to handle user login
        public static DataTable Login(string email, string password)
        {

            DataTable result = new DataTable();
            string query = "";

            using (SqlCommand cmd = new SqlCommand())
            {
                // Check Admin table
                query = "SELECT ID, 'Admin' As fname, 'Admin' AS Role FROM Admin WHERE email = @email AND pass = @password";
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                result = AttendanceDAL.Select(cmd);
                if (result.Rows.Count > 0) return result;

                // Check Instructor table
                query = "SELECT ID, fname, 'Instructor' AS Role FROM Instructor WHERE email = @email AND pass = @password";
                cmd.CommandText = query;
                result = AttendanceDAL.Select(cmd);
                if (result.Rows.Count > 0) return result;

                // Check Student table
                query = "SELECT ID, fname, 'Student' AS Role FROM Student WHERE email = @email AND pass = @password";
                cmd.CommandText = query;
                result = AttendanceDAL.Select(cmd);
                if (result.Rows.Count > 0) return result;
            }

            return result; // Return empty DataTable if no match found
        }



        // Method to retrieve password by email (Forget Password)
        public static string GetPasswordByEmail(string email)
        {
            string query = "SELECT pass FROM Admin WHERE email = @email";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@email", email);

            DataTable result = AttendanceDAL.Select(cmd);

            // If no result is found in Admin table, check Instructor table
            if (result.Rows.Count == 0)
            {
                query = "SELECT pass FROM Instructor WHERE email = @email";
                cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@email", email);
                result = AttendanceDAL.Select(cmd);
            }

            // If no result is found in Instructor table, check Student table
            if (result.Rows.Count == 0)
            {
                query = "SELECT pass FROM Student WHERE email = @email";
                cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@email", email);
                result = AttendanceDAL.Select(cmd);
            }

            // If a result is found, return the password
            if (result.Rows.Count > 0)
            {
                return result.Rows[0]["pass"].ToString();
            }

            // If no result is found, return null
            return null;
        }

        public static bool EmailExists(string email)
        {
            string query = "SELECT email FROM Admin WHERE email = @email";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@email", email);

            DataTable result = AttendanceDAL.Select(cmd);
            if (result.Rows.Count > 0) return true;

            query = "SELECT email FROM Instructor WHERE email = @email";
            cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@email", email);
            result = AttendanceDAL.Select(cmd);
            if (result.Rows.Count > 0) return true;

            query = "SELECT email FROM Student WHERE email = @email";
            cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@email", email);
            result = AttendanceDAL.Select(cmd);
            if (result.Rows.Count > 0) return true;

            return false;
        }

        public static string ResetPassword(string email)
        {
            if (!EmailExists(email)) return null;

            string newPassword = GenerateRandomPassword();
            bool updated = false;

            string[] tables = { "Admin", "Instructor", "Student" };

            foreach (string table in tables)
            {
                string query = $"UPDATE {table} SET pass = @password WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@password", newPassword);
                cmd.Parameters.AddWithValue("@email", email);

                int rowsAffected = AttendanceDAL.DML(cmd);
                if (rowsAffected > 0)
                {
                    updated = true;
                    break; // Stop after the first successful update
                }
            }

            return updated ? newPassword : null;
        }

        private static string GenerateRandomPassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";
            Random random = new Random();
            char[] password = new char[10];
            for (int i = 0; i < password.Length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }
            return new string(password);
        }
    }
}
