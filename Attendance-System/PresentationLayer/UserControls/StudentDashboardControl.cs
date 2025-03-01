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

namespace Attendance_System.PresentationLayer.UserControls
{
    public partial class StudentDashboardControl : UserControl
    {
        private int stdId;
        public StudentDashboardControl(int stdId)
        {
            InitializeComponent();
            this.stdId = stdId;
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Control_Load(object sender, EventArgs e)
        {
            DataTable dt = StudentBL.GetStudentDashboardData(stdId);
            if(dt.Rows.Count > 0 )
            {
                DataRow dr = dt.Rows[0];
                lb_std_name.Text = dr["SFullName"].ToString();
                lb_std_email.Text = dr["email"].ToString();
                lb_std_phone.Text = dr["Phone"].ToString();
                lb_std_address.Text = dr["Address"].ToString();
                lb_std_instructor.Text = dr["IFullName"].ToString();
                lb_std_group.Text = dr["className"].ToString();
                lb_std_discription.Text = dr["discription"].ToString();
            }
        }
    }
}
