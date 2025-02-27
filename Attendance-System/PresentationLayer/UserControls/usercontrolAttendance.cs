using Attendance_System.BusinessLayer;
using DocumentFormat.OpenXml.Office2010.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Attendance
{
    public partial class usercontrolAttendance : UserControl
    {
        public usercontrolAttendance()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void getAtt_Click(object sender, EventArgs e)
        {
            dvgAtt.AllowUserToAddRows = false;

            if (MarkAttendanceBL.getAtt(txtAtt.Text).Rows.Count > 0)
            {
                dvgAtt.DataSource = MarkAttendanceBL.getAtt(txtAtt.Text);
                foreach (DataGridViewRow row in dvgAtt.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells["Date"].Value = dtAtt.Value.ToString("yyyy - MM - dd");


                    }


                }
                if (dvgAtt.Columns.Contains("Status"))
                {
                    return;
                }

                // Create a new CheckBox column
                DataGridViewCheckBoxColumn chkColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Status",
                    HeaderText = "Status",
                    Width = 50,
                    TrueValue = true,  // Value when checked
                    FalseValue = false
                };
                // Add the column to the DataGridView
                dvgAtt.Columns.Add(chkColumn);

                dvgAtt.Columns["Id"].Width = 100;
                dvgAtt.Columns["Group"].Width = 100;
                dvgAtt.Columns["Date"].Width = 180;
                dvgAtt.Columns["Status"].Width = 180;


            }
            else
            {
                MessageBox.Show("No Student Found in this Group", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          


        }

        private void save_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dvgAtt.Rows)
            {

                int id = 0;
                string status;

                id = (int)row.Cells["Id"].Value;

                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                bool isChecked = Convert.ToBoolean(row.Cells["Status"].Value);

                if (isChecked)
                {

                    status = "Present";
                }
                else
                {
                    status = "Absent";
                }

                if (!MarkAttendanceBL.IsAttendanceRecorded(id, date))
                {
                    MarkAttendanceBL.insertAttendance(id, date, status);
 

                }
                else
                {
                    MessageBox.Show($"The Attendence of These Students had been recorded before!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;



                }


            }
                MessageBox.Show($"The Attendence of Students Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

