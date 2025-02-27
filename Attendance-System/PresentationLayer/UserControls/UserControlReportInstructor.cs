using Attendance_System.BusinessLayer;
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
    public partial class UserControlReportInstructor : UserControl
    {
        public UserControlReportInstructor()
        {
            InitializeComponent();
        }

        private void GroupRep_Click(object sender, EventArgs e)
        {
            dvgGroupRepIns.DataSource = BusinessLayer.ReportBL.getAllAttendanceForSpecificIns(2);
            dvgStudentRep.DataSource = BusinessLayer.ReportBL.getAllAttendanceForSpecificIns(2);
            dvgGroupRepIns.Columns["ID"].Width = 80;
            dvgGroupRepIns.Columns["Group"].Width = 100;
            dvgGroupRepIns.Columns["Date"].Width = 180;
            dvgGroupRepIns.Columns["Status"].Width = 180;

            dvgStudentRep.Columns["ID"].Width = 80;
            dvgStudentRep.Columns["Group"].Width = 100;
            dvgStudentRep.Columns["Date"].Width = 180;
            dvgStudentRep.Columns["Status"].Width = 180;

        }

        private void viewinsAtt_Click(object sender, EventArgs e)
        {
            if (ReportBL.getAttendaceByClassNameAndDate((txtGroupRep.Text), (dtRepGroup.Value.ToString())).Rows.Count > 0)
            {
                dvgGroupRepIns.DataSource = ReportBL.getAttendaceByClassNameAndDate((txtGroupRep.Text), dtRepGroup.Value.ToString());
            }
            else
            {
                MessageBox.Show($"{ReportBL.getAttendaceByClassNameAndDate((txtGroupRep.Text), (dtRepGroup.Value.ToString())).Rows.Count}");
                dvgGroupRepIns.DataSource = null;
                MessageBox.Show($"No Attendace of group {txtGroupRep.Text} in date {dtRepGroup.Value.ToString()}!", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dvgGroupRepIns.Columns["ID"].Width = 80;
            dvgGroupRepIns.Columns["Group"].Width = 100;
            dvgGroupRepIns.Columns["Date"].Width = 180;
            dvgGroupRepIns.Columns["Status"].Width = 180;

            txtGroupRep.Text = string.Empty;
            txtGroupRep.Focus();
        }

        private void dvgGroupRepIns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgStudentRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dvgGroupRepIns == null || dvgGroupRepIns.Rows.Count <= 0)

            {
                MessageBox.Show("No data available to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                ReportBL.ExportDataGridViewToExcel(dvgGroupRepIns);

            }
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            if (dvgStudentRep == null || dvgStudentRep.Rows.Count <= 0)

            {
                MessageBox.Show("No data available to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                ReportBL.ExportDataGridViewToExcel(dvgStudentRep);

            }
        }
    }
}
