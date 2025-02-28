using Attendance_System.BusinessLayer;
using Attendance_System.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System.PresentationLayer.UserControls
{
    public partial class StudentAttendanceControl : UserControl
    {
        private int std_id;
        public StudentAttendanceControl(int stdid)
        {
            std_id = stdid;
            InitializeComponent();
            //LoadAttendanceData(std_id);
            // Populate the ComboBox with attendance status options
            sltSSAtt.Items.Add("All");
            sltSSAtt.Items.Add("Present");
            sltSSAtt.Items.Add("Absent");
            sltSSAtt.SelectedIndex = 0; // Default to "All"

            LoadAttendanceReport(); // Load all records initially

            // Attach event handler for selection change
            sltSSAtt.SelectedIndexChanged += sltSSAtt_SelectedIndexChanged;
        }
        //private void LoadAttendanceData(int studentId)
        //{
        //    DataTable attendanceData = AttendanceBl.GetAttendanceReport(studentId);
        //    if (attendanceData != null)
        //    {
        //        dvgAttStudent.DataSource = attendanceData;
        //    }
        //    else
        //    {
        //        MessageBox.Show("No attendance records found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}


        private void dtRepGroup_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dvgAttStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadAttendanceReport()
        {
            int studentId = std_id; // Replace with actual student ID (e.g., from a TextBox)
            string selectedStatus = sltSSAtt.SelectedItem.ToString();

            // Convert "All" to null so that the query doesn't filter by status
            string statusFilter = selectedStatus == "All" ? null : selectedStatus;

            DataTable dt = AttendanceBl.GetAttendanceReport(studentId, statusFilter);
            dvgAttStudent.DataSource = dt;
        }

        private void sltSSAtt_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceReport(); // Reload data with the selected filter
        }
    }
}
