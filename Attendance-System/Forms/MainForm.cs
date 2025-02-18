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
        public MainForm()
        {
            InitializeComponent();
            // Add controls to the form
            dashboardControl.Dock = DockStyle.Fill;
            userControlReportAttendance.Dock = DockStyle.Fill;

            p_main.Controls.Add(userControlReportAttendance);
            p_main.Controls.Add(dashboardControl);

            // Set initial visibility
            dashboardControl.Visible = true;
            userControlReportAttendance.Visible = false;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            dashboardControl.Visible = false;
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
            dashboardControl.Visible = true;
            userControlReportAttendance.Visible = false;
        }
    }
}
