using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Attendance_System.DataAccessLayer;
using Microsoft.Data.SqlClient;
using Microsoft.Data;

using System.Windows.Forms;
using System.Data;

namespace Attendance_System.BusinessLayer
{
    public class MarkAttendanceBL
    {
        public static DataTable getAtt(string _className)
        {
            string query = @"
        SELECT 
            s.id AS 'Id',  
            (s.fname + ' ' + s.lname) AS 'Student Name',
            g.className AS 'Group', 
            CAST(NULL AS DATETIME) AS 'Date'
        FROM Student s
        INNER JOIN Groups g ON g.id = s.class_id
        WHERE g.className = @className";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@className", _className);

            return AttendanceDAL.Select(cmd);
        }


        public static int insertAttendance(int _id, DateTime _date, string _status)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO Attendance(student_id , date , status) VALUES (@id,@date, @status)");
            cmd.Parameters.AddWithValue("id", _id);
            cmd.Parameters.AddWithValue("date", _date);
            cmd.Parameters.AddWithValue("status", _status);

            return AttendanceDAL.DML(cmd);
        }
        public static bool IsAttendanceRecorded(int studentId, DateTime date)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Attendance WHERE student_id = @id AND date = @date");
            cmd.Parameters.AddWithValue("@id", studentId);
            cmd.Parameters.AddWithValue("@date", date);

            DataTable dt = AttendanceDAL.Select(cmd);

            return dt.Rows[0][0] != DBNull.Value && Convert.ToInt32(dt.Rows[0][0]) > 0;
        }
    }
}
