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
        private Form parentForm;
        StudentAttendanceControl StdControl;
        public StudentForm(int userId, Form parent)
        {
            
            parentForm = parent;
            StdControl = new StudentAttendanceControl(userId);
            InitializeComponent();
            StdControl.Dock = DockStyle.Fill;
            mainPanal.Controls.Add(StdControl);
            StdControl.Visible = false;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            parentForm.Show();
        }

        private void btn_atten_Click(object sender, EventArgs e)
        {
            StdControl.Visible = true;
        }
    }
}
