using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.DataAccessLayer
{
    internal class AttendanceDAL
    {
        private static string connStr = new ConfigurationBuilder().AddJsonFile("MyConnection.json").Build().GetSection("connection").Value;
        private static SqlConnection conn = new SqlConnection(connStr);
        public static DataTable Select(SqlCommand cmd)
        {
            cmd.Connection = conn;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public static int DML(SqlCommand cmd)
        {
            int res = 0;
            cmd.Connection = conn;
            conn.Open();
            res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }
        public static int GetScalar(SqlCommand cmd)
        {
            int res = 0;
            cmd.Connection = conn;
            conn.Open();
            res = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return res;
        }

        internal static bool ExecuteScalar(SqlCommand cmd)

        {
            bool result = false;
            try
            {
                cmd.Connection = conn;
                conn.Open();
                var scalarResult = cmd.ExecuteScalar();

                if (scalarResult != null && bool.TryParse(scalarResult.ToString(), out bool parsedResult))
                {
                    result = parsedResult;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
