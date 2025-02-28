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
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        private int groupId;

        public UpdateForm(int id, string groupCode, int numStudents, string instructor, string description)
        {
            InitializeComponent();

            // Set data in the UpdateGroupControl inside UpdateForm
            updateGroupControl1.SetGroupData(id, groupCode, numStudents, instructor, description);
        }
        
        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
