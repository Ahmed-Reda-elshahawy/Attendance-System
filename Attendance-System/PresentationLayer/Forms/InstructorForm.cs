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

        private Form parentForm;
        //UserControlReportAttendance userControlReportAttendance2 = new UserControlReportAttendance();

        usercontrolAttendance usercontrolAttendance2 = new usercontrolAttendance();


        //UserControlInstructorAtt usercontrolAttendance2 = new UserControlInstructorAtt();

        UserControlReportInstructor userControlReportAttendance2 = new UserControlReportInstructor();


        public InstructorForm(int userId, Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            //panel2.Visible = false;
            //panel2.Location = new Point(360, 0);
            //mainPanal.Location = new Point(360, 100);
            userControlReportAttendance2.Dock = DockStyle.Fill;
            usercontrolAttendance2.Dock = DockStyle.Fill;


            insPanel.Controls.Add(userControlReportAttendance2);
            insPanel.Controls.Add(usercontrolAttendance2);


            userControlReportAttendance2.Visible = false;
            usercontrolAttendance2.Visible = false;


        }

        private void btn_atten_Click(object sender, EventArgs e)
        {
            userControlReportAttendance2.Visible = false;

            usercontrolAttendance2.Visible = true;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            userControlReportAttendance2.Visible = true;
            usercontrolAttendance2.Visible = false;

            userControlReportAttendance2.dvgGroupRepIns.DataSource = BusinessLayer.ReportBL.getAllAttendanceForSpecificIns(2);
            userControlReportAttendance2.dvgGroupRepIns.Columns["ID"].Width = 80;
            userControlReportAttendance2.dvgGroupRepIns.Columns["Group"].Width = 100;
            userControlReportAttendance2.dvgGroupRepIns.Columns["Date"].Width = 180;
            userControlReportAttendance2.dvgGroupRepIns.Columns["Status"].Width = 180;



        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void insPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnI_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }
    }
}
