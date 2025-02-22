using Attendance_System.DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Attendance_System.BusinessLayer
{

    
        public class StudentBL
        {


            public static int AddStudent(string fname, string lname, string email, string pass, int classId, int adminId, string phone, string address, char gender)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Student (fname, lname, email, pass, class_id, admin_id, Phone, Address, Gender) VALUES (@fname, @lname, @email, @pass, @classId, @adminId, @phone, @address, @gender);");
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@classId", classId);
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    return AttendanceDAL.DML(cmd);
                }
                catch (Exception e)

                {
                    Console.WriteLine("Error in AddStudent: " + e.Message);
                    return -1;
                }

            }

            public static DataTable GetStudents()
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, email, pass, class_id, admin_id, Phone, Address, Gender FROM Student");
                    return AttendanceDAL.Select(cmd);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetStudents: " + ex.Message);
                    return null;
                }
            }

            public static int DeleteStudent(int studentId)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE id = @studentId");
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    return AttendanceDAL.DML(cmd);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in DeleteStudent: " + ex.Message);
                    return -1;
                }
            }

            public static int UpdateStudent(int studentId, string fname, string lname, string email, string pass, int classId, int adminId, string phone, string address, char gender)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Student SET fname = @fname, lname = @lname, email = @email, pass = @pass, class_id = @classId, admin_id = @adminId, Phone = @phone, Address = @address, Gender = @gender WHERE id = @studentId");
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.Parameters.AddWithValue("@classId", classId);
                    cmd.Parameters.AddWithValue("@adminId", adminId);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    return AttendanceDAL.DML(cmd);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in UpdateStudent: " + ex.Message);
                    return -1;
                }
            }
        
    public static DataTable SearchStudentById(int studentId)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT id, fname, lname, email, pass, class_id, admin_id, Phone, Address, Gender FROM Student WHERE id = @studentId"))
                {
                    cmd.Parameters.AddWithValue("@studentId", studentId);
                    return AttendanceDAL.Select(cmd);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving student: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataTable SearchStudent(string[] columnNames, string[] searchTerms, bool partialMatch = false)
        {
            try
            {
                string query = "SELECT id, fname, lname, email, pass, class_id, admin_id, Phone, Address, Gender FROM Student WHERE ";
                for (int i = 0; i < columnNames.Length; i++)
                {
                    if (i > 0)
                    {
                        query += " AND ";
                    }
                    query += partialMatch ? $"{columnNames[i]} LIKE @searchTerm{i}" : $"{columnNames[i]} = @searchTerm{i}";
                }

                using (SqlCommand cmd = new SqlCommand(query))
                {
                   
                    for (int i = 0; i < columnNames.Length; i++)
                    {
                        if (partialMatch)
                        {
                          
                            cmd.Parameters.AddWithValue($"@searchTerm{i}", $"%{searchTerms[i]}%");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue($"@searchTerm{i}", searchTerms[i]);
                        }
                    }

                
                    return AttendanceDAL.Select(cmd);
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Error in SearchStudent: " + ex.Message);
                return null;
            }
        }
    }
 }

    





