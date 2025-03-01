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

namespace Attendance_System.Forms
{

    public partial class MainForm : Form
    {
        private int userId;
        private Form parentForm;
        DashboardControl dashboardControl = new DashboardControl();
        UserControlReportAttendance userControlReportAttendance = new UserControlReportAttendance();
        usercontrolAttendance usercontrolAttendance = new usercontrolAttendance();
        UserControlRegister instructorControl = new UserControlRegister();
        StudentUserControl studentUserControl = new StudentUserControl();
        GroupControl groupControl = new GroupControl();
        public MainForm(int userId, Form parent)
        {
            this.userId = userId;
            parentForm = parent;
            InitializeComponent();
            // Add controls to the form
            dashboardControl.Dock = DockStyle.Fill;
            userControlReportAttendance.Dock = DockStyle.Fill;
            usercontrolAttendance.Dock = DockStyle.Fill;
            instructorControl.Dock = DockStyle.Fill;
            studentUserControl.Dock = DockStyle.Fill;
            groupControl.Dock = DockStyle.Fill;

            p_main.Controls.Add(userControlReportAttendance);
            p_main.Controls.Add(instructorControl);
            p_main.Controls.Add(usercontrolAttendance);
            p_main.Controls.Add(dashboardControl);
            p_main.Controls.Add(studentUserControl);
            p_main.Controls.Add(groupControl);

            // Set initial visibility
            dashboardControl.Visible = true;
            userControlReportAttendance.Visible = false;
            usercontrolAttendance.Visible = false;
            instructorControl.Visible = false;
            studentUserControl.Visible = false;
            groupControl.Visible = false;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            instructorControl.Visible = false;
            usercontrolAttendance.Visible = false;
            userControlReportAttendance.Visible = true;
            if (ReportBL.getAllAttendance().Rows.Count > 0)
            {
                userControlReportAttendance.dvgGroupRep.DataSource = ReportBL.getAllAttendance();

            }
            else
            {
                userControlReportAttendance.dvgGroupRep.DataSource = null;
                MessageBox.Show($"No Attendace Found!", "Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userControlReportAttendance.dvgGroupRep.Columns["ID"].Width = 80;
            userControlReportAttendance.dvgGroupRep.Columns["Group"].Width = 100;
            userControlReportAttendance.dvgGroupRep.Columns["Date"].Width = 180;
            userControlReportAttendance.dvgGroupRep.Columns["Status"].Width = 180;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            admin_name.Text = "Admin";
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            userControlReportAttendance.Visible = false;
            usercontrolAttendance.Visible = false;
            instructorControl.Visible = false;
            groupControl.Visible = false;
            studentUserControl.Visible = false;
            dashboardControl.Visible = true;
        }

        private void btn_atten_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            instructorControl.Visible = false;
            userControlReportAttendance.Visible = false;
            studentUserControl.Visible = false;
            groupControl.Visible = false;
            usercontrolAttendance.Visible = true;
        }

        private void btn_ins_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            usercontrolAttendance.Visible = false;
            userControlReportAttendance.Visible = false;
            groupControl.Visible = false;
            studentUserControl.Visible = false;
            instructorControl.Visible = true;
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            usercontrolAttendance.Visible = false;
            userControlReportAttendance.Visible = false;
            groupControl.Visible = false;
            instructorControl.Visible = false;
            studentUserControl.Visible = true;

        }

        private void p_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_group_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            userControlReportAttendance.Visible = false;
            usercontrolAttendance.Visible = false;
            instructorControl.Visible = false;
            studentUserControl.Visible = false;
            groupControl.Visible = true;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                parentForm.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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
