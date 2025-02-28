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

namespace Attendance_System.UserControls
{
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
            
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            ShowCountOfSystemElements();
        }
        private void ShowCountOfSystemElements()
        {
            lb_students.Text = AdminDashboardBL.GetStudentsCount().ToString();
            lb_groups.Text =  AdminDashboardBL.GetGroupsCount().ToString();
            lb_instructors.Text =  AdminDashboardBL.GetInstructorsCount().ToString();
        }
    }
}
