using Attendance;
using Attendance_Management_System.PAL.User_Control;
using Attendance_System.BusinessLayer;
using Attendance_System.PresentationLayer.UserControls;
using Attendance_System.UserControls;
using Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System.PresentationLayer.Forms
{
    public partial class InstructorForm : Form
    {
        private int userId;
        private string userName;
        private Form parentForm;
        usercontrolAttendance usercontrolAttendance2 = new usercontrolAttendance();
        UserControlReportInstructor userControlReportAttendance2;
        InstructorDashboardControl instructorDashboard;


        public InstructorForm(int userId, string userName, Form parent)
        {
            this.userId = userId;
            this.userName = userName;
            instructorDashboard = new InstructorDashboardControl(userId);
            userControlReportAttendance2 = new UserControlReportInstructor(userId);
            InitializeComponent();
            parentForm = parent;
            userControlReportAttendance2.Dock = DockStyle.Fill;
            usercontrolAttendance2.Dock = DockStyle.Fill;
            instructorDashboard.Dock = DockStyle.Fill;


            insPanel.Controls.Add(userControlReportAttendance2);
            insPanel.Controls.Add(usercontrolAttendance2);
            insPanel.Controls.Add(instructorDashboard);


            userControlReportAttendance2.Visible = false;
            usercontrolAttendance2.Visible = false;
            instructorDashboard.Visible = true;
        }

        private void btn_atten_Click(object sender, EventArgs e)
        {
            userControlReportAttendance2.Visible = false;
            instructorDashboard.Visible = false;
            usercontrolAttendance2.Visible = true;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            userControlReportAttendance2.Visible = true;
            instructorDashboard.Visible = false;
            usercontrolAttendance2.Visible = false;

            userControlReportAttendance2.dvgGroupRepIns.DataSource = BusinessLayer.ReportBL.getAllAttendanceForSpecificIns(2);
            userControlReportAttendance2.dvgGroupRepIns.Columns["ID"].Width = 80;
            userControlReportAttendance2.dvgGroupRepIns.Columns["Group"].Width = 100;
            userControlReportAttendance2.dvgGroupRepIns.Columns["Date"].Width = 180;
            userControlReportAttendance2.dvgGroupRepIns.Columns["Status"].Width = 180;



        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            ins_name.Text = userName;
        }

        private void insPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnI_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                parentForm.Show();
            }
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            userControlReportAttendance2.Visible = false;
            usercontrolAttendance2.Visible = false;
            instructorDashboard.Visible = true;
        }

        private void InstructorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
