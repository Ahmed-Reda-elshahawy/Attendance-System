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
    internal class AttendanceBl
    {
        //    public static DataTable GetAttendanceReport(int studentId)
        //    {


        //         try
        //{
        //    string query = @"
        //        SELECT 
        //            G.className AS GroupName, 
        //            I.fname + ' ' + I.lname AS InstructorFullName, 
        //            A.date AS AttendanceDate, 
        //            A.status AS AttendanceStatus
        //        FROM Attendance A
        //        JOIN Student S ON A.student_id = S.id
        //        JOIN Groups G ON S.class_id = G.id
        //        LEFT JOIN Instructor I ON G.instructor_id = I.id
        //        WHERE S.id = @studentId";

        //    SqlCommand cmd = new SqlCommand(query);
        //    cmd.Parameters.AddWithValue("@studentId", studentId);
        //    return AttendanceDAL.Select(cmd);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Error in GetAttendanceReport: " + ex.Message);
        //    return null;
        //}
        //    }

        public static DataTable GetAttendanceReport(int studentId, string attendanceStatus = null)
        {
            try
            {
                string query = @"
            SELECT 
                G.className AS GroupName, 
                I.fname + ' ' + I.lname AS InstructorFullName, 
                A.date AS AttendanceDate, 
                A.status AS AttendanceStatus
            FROM Attendance A
            JOIN Student S ON A.student_id = S.id
            JOIN Groups G ON S.class_id = G.id
            LEFT JOIN Instructor I ON G.instructor_id = I.id
            WHERE S.id = @studentId";

                if (!string.IsNullOrEmpty(attendanceStatus))
                {
                    query += " AND A.status = @attendanceStatus";
                }

                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@studentId", studentId);

                if (!string.IsNullOrEmpty(attendanceStatus))
                {
                    cmd.Parameters.AddWithValue("@attendanceStatus", attendanceStatus);
                }

                return AttendanceDAL.Select(cmd);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in GetAttendanceReport: " + ex.Message);
                return null;
            }
        }

    }
}
