﻿using Attendance;
using Attendance_Management_System.PAL.User_Control;
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
        DashboardControl dashboardControl = new DashboardControl();
        UserControlReportAttendance userControlReportAttendance = new UserControlReportAttendance();
        usercontrolAttendance usercontrolAttendance = new usercontrolAttendance();
        UserControlRegister instructorControl = new UserControlRegister();
        public MainForm()
        {
            InitializeComponent();
            // Add controls to the form
            dashboardControl.Dock = DockStyle.Fill;
            userControlReportAttendance.Dock = DockStyle.Fill;
            usercontrolAttendance.Dock = DockStyle.Fill;
            instructorControl.Dock = DockStyle.Fill;

            p_main.Controls.Add(userControlReportAttendance);
            p_main.Controls.Add(instructorControl);
            p_main.Controls.Add(usercontrolAttendance);
            p_main.Controls.Add(dashboardControl);

            // Set initial visibility
            dashboardControl.Visible = true;
            userControlReportAttendance.Visible = false;
            usercontrolAttendance.Visible = false;
            instructorControl.Visible = false;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            instructorControl.Visible = false;
            usercontrolAttendance.Visible = false;
            userControlReportAttendance.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //// Ensure buttons are wired up correctly
            //btn_report.Click += btn_report_Click;
            //btn_dash.Click += btn_dash_Click;
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            userControlReportAttendance.Visible = false;
            usercontrolAttendance.Visible = false;
            instructorControl.Visible = false;
            dashboardControl.Visible = true;
        }

        private void btn_atten_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            instructorControl.Visible = false;
            userControlReportAttendance.Visible = false;
            usercontrolAttendance.Visible = true;
        }

        private void btn_ins_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
            instructorControl.Visible = true;
            usercontrolAttendance.Visible = false;
            userControlReportAttendance.Visible = false;
        }
    }
}
