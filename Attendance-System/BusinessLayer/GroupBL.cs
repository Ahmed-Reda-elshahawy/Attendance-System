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
    public class GroupBL
    {

        // Method to add a new group
        public static int AddGroup(string className, int classNum, int instructorId, int adminId, string description)
        {
            string query = "INSERT INTO Groups (className, classNum, instructor_id, admin_id, discription) VALUES (@className, @classNum, @instructorId, @adminId, @description)";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@className", className);
            cmd.Parameters.AddWithValue("@classNum", classNum);
            cmd.Parameters.AddWithValue("@instructorId", instructorId);
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Parameters.AddWithValue("@description", description);

            return AttendanceDAL.DML(cmd);
        }

        // Method to update an existing group
        public static int UpdateGroup(int id, string className, int classNum, int instructorId, int adminId, string description)
        {
            string query = "UPDATE Groups SET className = @className, classNum = @classNum, instructor_id = @instructorId, admin_id = @adminId, discription = @description WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@className", className);
            cmd.Parameters.AddWithValue("@classNum", classNum);
            cmd.Parameters.AddWithValue("@instructorId", instructorId);
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Parameters.AddWithValue("@description", description);

            return AttendanceDAL.DML(cmd);
        }

        // Method to delete a group
        public static int DeleteGroup(int id)
        {
            string query = "DELETE FROM Groups WHERE id = @id";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@id", id);

            return AttendanceDAL.DML(cmd);
        }

        // Method to display all groups
        public static DataTable DisplayGroups()
        {
            string query = "SELECT * FROM Groups";
            SqlCommand cmd = new SqlCommand(query);

            return AttendanceDAL.Select(cmd);
        }      
        public static DataTable GetGroups()
        {
            string query = "SELECT g.id, g.className, g.classNum, CONCAT(i.fname, ' ', i.lname) AS instructor_name, g.discription FROM Groups g INNER JOIN Instructor i ON g.instructor_id = i.id";
            SqlCommand cmd = new SqlCommand(query);

            return AttendanceDAL.Select(cmd);
        }

        // Method to search for a group by class name
        public static DataTable SearchGroup(string className)
        {
            string query = "SELECT * FROM Groups WHERE className LIKE @className";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@className", "%" + className + "%");

            return AttendanceDAL.Select(cmd);
        }

        //Helper method to check if a group exists
        public static bool IsGroupExists(string className)
        {
            string query = "SELECT COUNT(*) FROM Groups WHERE className = @className";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@className", className);

            int count = Convert.ToInt32(AttendanceDAL.ExecuteScalar(cmd));
            return count > 0;
        }

        //public static DataTable GetFilteredGroups(string groupCode, string instructorName)
        //{
        //    string query = "SELECT * FROM Groups WHERE 1=1";

        //    if (!string.IsNullOrEmpty(groupCode))
        //        query += " AND className = @GroupCode";

        //    if (!string.IsNullOrEmpty(instructorName))
        //        query += " AND CONCAT(fname, ' ', lname) = @InstructorName";

        //    using (SqlCommand cmd = new SqlCommand(query))
        //    {
        //        if (!string.IsNullOrEmpty(groupCode))
        //            cmd.Parameters.AddWithValue("@GroupCode", groupCode);

        //        if (!string.IsNullOrEmpty(instructorName))
        //            cmd.Parameters.AddWithValue("@InstructorName", instructorName);

        //        return AttendanceDAL.Select(cmd);  // Use DAL to execute query
        //    }
        //}

        //public static DataTable GetFilteredGroups(string groupCode, string instructorName)
        //{
        //    string query = @"
        //SELECT g.id, g.className, g.classNum, 
        //       CONCAT(i.fname, ' ', i.lname) AS instructor_name, 
        //       g.discription 
        //FROM Groups g 
        //INNER JOIN Instructor i ON g.instructor_id = i.id
        //WHERE 1=1";

        //    if (!string.IsNullOrEmpty(groupCode))
        //        query += " AND g.className = @GroupCode";

        //    if (!string.IsNullOrEmpty(instructorName))
        //        query += " AND CONCAT(i.fname, ' ', i.lname) = @InstructorName";

        //    using (SqlCommand cmd = new SqlCommand(query))
        //    {
        //        if (!string.IsNullOrEmpty(groupCode))
        //            cmd.Parameters.AddWithValue("@GroupCode", groupCode);

        //        if (!string.IsNullOrEmpty(instructorName))
        //            cmd.Parameters.AddWithValue("@InstructorName", instructorName);

        //        return AttendanceDAL.Select(cmd);  // Use DAL to execute query
        //    }
        //}

        public static DataTable GetFilteredGroups(string groupCode, int? instructorID)
        {
            string query = @"
SELECT g.id, g.className, g.classNum, 
       CONCAT(i.fname, ' ', i.lname) AS instructor_name, 
       g.discription 
FROM Groups g 
INNER JOIN Instructor i ON g.instructor_id = i.id
WHERE 1=1";

            if (!string.IsNullOrEmpty(groupCode))
                query += " AND g.className = @GroupCode";

            if (instructorID.HasValue && instructorID > 0)
                query += " AND i.id = @InstructorID";  // Use InstructorID instead of full name comparison

            using (SqlCommand cmd = new SqlCommand(query))
            {
                if (!string.IsNullOrEmpty(groupCode))
                    cmd.Parameters.AddWithValue("@GroupCode", groupCode);

                if (instructorID.HasValue && instructorID > 0)
                    cmd.Parameters.AddWithValue("@InstructorID", instructorID.Value);  // Use ID instead of name

                return AttendanceDAL.Select(cmd);  // Use DAL to execute query
            }
        }



        public static DataTable GetGroupCodes()
        {
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT className FROM Groups");
            return AttendanceDAL.Select(cmd); // Uses your existing DAL method
        }

    }
}

