using Attendance_System.DataAccessLayer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.BusinessLayer
{
    internal class InstructorBL
    {
        public static int AddInstructor(string fname, string lname, string email, string pass, int adminId, string img, string phone, string address, char gender)
        {
            SqlCommand cmd = new SqlCommand("insert into Instructor (fname, lname, email, pass, admin_id, Phone, Address, Gender) values (@fname, @lname, @email, @pass, @adminId, @phone, @address, @gender);");
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@adminId", adminId);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            return AttendanceDAL.DML(cmd);
        }

        public static DataTable GetInstructors()
        {
            SqlCommand cmd = new SqlCommand("select id, fname, lname, email, pass, Phone, Address, Gender from Instructor");
            return AttendanceDAL.Select(cmd);
        }

        public static int DeleteInstructor(int ins_id)
        {
            SqlCommand cmd = new SqlCommand("delete from Instructor where id = @id");
            cmd.Parameters.AddWithValue("@id", ins_id);
            return AttendanceDAL.DML(cmd);
        }

        public static int UpdateInstructor(int ins_id, string fname, string lname, string email, string pass, string phone, string Address, char Gender)
        {
            SqlCommand cmd = new SqlCommand("update Instructor set fname = @fname, lname = @lname, email = @email, pass = @pass, Phone = @phone, Address = @address, Gender = @gender where id = @id");
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@lname", lname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@id", ins_id);
            return AttendanceDAL.DML(cmd);
        }
    }
}
