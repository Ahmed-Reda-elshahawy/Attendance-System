using Attendance_System.PresentationLayer.UserControls;
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
    public partial class StudentForm : Form
    {
        private int userId;
        private string userName;
        private Form parentForm;
        StudentAttendanceControl StdControl;
        StudentDashboardControl studentDashboardControl;
        public StudentForm(int userId, string userName, Form parent)
        {
            this.userId = userId;
            this.userName = userName;
            parentForm = parent;
            StdControl = new StudentAttendanceControl(userId);
            studentDashboardControl = new StudentDashboardControl(userId);


            InitializeComponent();
            StdControl.Dock = DockStyle.Fill;
            mainPanal.Controls.Add(StdControl);
            mainPanal.Controls.Add(studentDashboardControl);
            StdControl.Visible = false;
            studentDashboardControl.Visible = true;
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

        private void btn_atten_Click(object sender, EventArgs e)
        {
            StdControl.Visible = true;
            studentDashboardControl.Visible = false;
        }

        private void btn_dash_Click(object sender, EventArgs e)
        {
            StdControl.Visible = false;
            studentDashboardControl.Visible = true;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            std_name.Text = userName;
        }

        private void StudentForm_FormClosing(object sender, FormClosingEventArgs e)
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
