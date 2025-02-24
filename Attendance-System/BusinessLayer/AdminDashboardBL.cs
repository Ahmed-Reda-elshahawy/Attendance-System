using Attendance_System.DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.BusinessLayer
{
    internal class AdminDashboardBL
    {
        public static int GetStudentsCount()
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) as stds_count from Student");
            return AttendanceDAL.GetScalar(cmd);
        }
        public static int GetInstructorsCount() 
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) as stds_count from Instructor");
            return AttendanceDAL.GetScalar(cmd);
        }
        public static int GetGroupsCount() 
        {
            SqlCommand cmd = new SqlCommand("Select Count(*) as stds_count from Groups");
            return AttendanceDAL.GetScalar(cmd);
        }
    }
}
