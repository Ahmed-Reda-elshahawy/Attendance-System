using Attendance_System.BusinessLayer;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using static System.Runtime.InteropServices.JavaScript.JSType;
//using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Report
{
    public partial class UserControlReportAttendance : UserControl
    {
        public UserControlReportAttendance()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void view_Click(object sender, EventArgs e)
        {
            if (ReportBL.getAttendaceByClassNameAndDate((txtGroupRep.Text), (dtRepGroup.Value.ToString())).Rows.Count > 0)
            {
                dvgGroupRep.DataSource = ReportBL.getAttendaceByClassNameAndDate((txtGroupRep.Text), dtRepGroup.Value.ToString());
            }
            else
            {
                MessageBox.Show($"{ReportBL.getAttendaceByClassNameAndDate((txtGroupRep.Text), (dtRepGroup.Value.ToString())).Rows.Count}");
                dvgGroupRep.DataSource = null;
                MessageBox.Show($"No Attendace of group {txtGroupRep.Text} in date {dtRepGroup.Value.ToString()}!", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dvgGroupRep.Columns["ID"].Width = 80;
            dvgGroupRep.Columns["Group"].Width = 100;
            dvgGroupRep.Columns["Date"].Width = 180;
            dvgGroupRep.Columns["Status"].Width = 180;

            txtGroupRep.Text = string.Empty;
            txtGroupRep.Focus();
        }

        private void GroupRep_Click(object sender, EventArgs e)
        {
            dvgGroupRep.DataSource = ReportBL.getAllAttendance();
            dvgStudentRep.DataSource = ReportBL.getAllAttendance();
            dvgGroupRep.Columns["ID"].Width = 80;
            dvgGroupRep.Columns["Group"].Width = 100;
            dvgGroupRep.Columns["Date"].Width = 180;
            dvgGroupRep.Columns["Status"].Width = 180;

            dvgStudentRep.Columns["ID"].Width = 80;
            dvgStudentRep.Columns["Group"].Width = 100;
            dvgStudentRep.Columns["Date"].Width = 180;
            dvgStudentRep.Columns["Status"].Width = 180;
        }

        private void view1_Click(object sender, EventArgs e)
        {
            if (ReportBL.getStdAttendance(int.Parse(txtStdId.Text)).Rows.Count > 0)
            {
                dvgStudentRep.DataSource = ReportBL.getStdAttendance(int.Parse(txtStdId.Text));
            }
            else
            {
                dvgStudentRep.DataSource = null;
                MessageBox.Show($"No Studnt Found with this Id {txtStdId}!", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dvgStudentRep.Columns["ID"].Width = 80;
            dvgStudentRep.Columns["Group"].Width = 100;
            dvgStudentRep.Columns["Date"].Width = 180;
            dvgStudentRep.Columns["Status"].Width = 180;
            txtStdId.Text = string.Empty;
            txtStdId.Focus();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dvgGroupRep == null || dvgGroupRep.Rows.Count <= 0)

            {
                MessageBox.Show("No data available to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                ReportBL.ExportDataGridViewToExcel(dvgGroupRep);

            }
        }

        private void txtGroupRep_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvgGroupRep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
