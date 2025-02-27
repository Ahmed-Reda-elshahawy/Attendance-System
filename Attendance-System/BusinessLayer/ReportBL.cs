using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Attendance_System.DataAccessLayer;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;

using System.IO;
namespace Attendance_System.BusinessLayer
{
    public class ReportBL
    {
        public static DataTable getAttendaceByClassNameAndDate(string _className, string _date)
        {
            //SqlCommand cmd = new SqlCommand("select s.id , (s.fname + ' '+s.lname) as 'Student Name' , a.date , a.status from Attendance a , Student s where s.id = a.student_id and s.class_id =" + _id);

            string sc = "select s.id as 'ID', (s.fname + ' '+s.lname) as 'Student Name' , g.className as 'Group' , a.date as 'Date' , a.status  \r\nfrom Student s , Attendance a , Groups g where s.class_id = g.id and s.id = a.student_id and g.className = ";
            SqlCommand cmd = new SqlCommand(sc + $"'{_className}'"+ $" and CAST(date AS DATE) = '{_date}'");
            return AttendanceDAL.Select(cmd);

        }

        public static DataTable getAttendaceByDate(string _date)
        {
            //SqlCommand cmd = new SqlCommand("select s.id , (s.fname + ' '+s.lname) as 'Student Name' , a.date , a.status from Attendance a , Student s where s.id = a.student_id and s.class_id =" + _id);

            string sc = "select s.id as 'Student Number', (s.fname + ' '+s.lname) as 'Student Name' , g.className as 'Group Name' , a.date as 'Date' , a.status  \r\nfrom Student s , Attendance a , Groups g where s.class_id = g.id and s.id = a.student_id  ";
            SqlCommand cmd = new SqlCommand(sc + $" and CAST(date AS DATE) = '{_date}'");
            return AttendanceDAL.Select(cmd);

        }

        public static DataTable getAttendaceByClassName(string _className)
        {
            //SqlCommand cmd = new SqlCommand("select s.id , (s.fname + ' '+s.lname) as 'Student Name' , a.date , a.status from Attendance a , Student s where s.id = a.student_id and s.class_id =" + _id);

            string sc = "select s.id as 'Student Number', (s.fname + ' '+s.lname) as 'Student Name' , g.className as 'Group Name' , a.date as 'Date' , a.status  \r\nfrom Student s , Attendance a , Groups g where s.class_id = g.id and s.id = a.student_id and g.className = ";
            SqlCommand cmd = new SqlCommand(sc + $"  '{_className}'");
            return AttendanceDAL.Select(cmd);

        }

        public static DataTable getAllAttendance()
        {
            SqlCommand cmd = new("select s.id as 'ID', (s.fname + ' '+s.lname) as 'Student Name' , g.className as 'Group' , a.date as 'Date' , a.status as Status  \r\nfrom Student s , Attendance a , Groups g where s.class_id = g.id and s.id = a.student_id ");
            return AttendanceDAL.Select(cmd);

        }

        public static DataTable getAllAttendanceForSpecificIns(int _id )
        {
            SqlCommand cmd = new("select s.id as 'ID', (s.fname + ' '+s.lname) as 'Student Name' , g.className as 'Group' , a.date as 'Date' , a.status as Status \r\nfrom Student s , Attendance a , Groups g , Instructor i where s.class_id = g.id and s.id = a.student_id and i.id = g.instructor_id and i.id = " + _id);
            return AttendanceDAL.Select(cmd);

        }


        public static DataTable getStdAttendance(int _id)
        {
            SqlCommand cmd = new("select s.id as 'ID', (s.fname + ' '+s.lname) as 'Student Name' , g.className as 'Group' , a.date as 'Date' , a.status as Status  \r\nfrom Student s , Attendance a , Groups g where s.class_id = g.id and s.id = a.student_id and s.id = " + _id);
            return AttendanceDAL.Select(cmd);

        }

        public static void ExportDataGridViewToExcel(DataGridView dgv)
        {
            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save as Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    using (ExcelPackage package = new ExcelPackage(file))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Exported Data");

                        // Export Headers
                        for (int i = 0; i < dgv.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dgv.Columns[i].HeaderText;
                        }

                        // Export Data
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgv.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dgv.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        // Auto-fit columns
                        worksheet.Cells.AutoFitColumns();

                        package.Save();
                    }

                    MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


            }



    }
}
