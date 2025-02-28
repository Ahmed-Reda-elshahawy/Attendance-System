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
    public partial class UpdateGroupControl : UserControl
    {
        int _group_id;
        public UpdateGroupControl()
        {
            InitializeComponent();
            LoadInstructors();
        }

        private void UpdateGroupControl_Load(object sender, EventArgs e)
        {

        }

        private void lblUpdateCF_Click(object sender, EventArgs e)
        {

        }

        private void txtNOSCF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetGroupData(int id, string groupCode, int numStudents, string instructor, string description)
        {
            _group_id = id;
            txtGCCF.Text = groupCode;
            txtNOSCF.Text = numStudents.ToString();
            sltINSCF.SelectedItem = instructor;
            txtDiscriptionCF.Text = description;

            //lblGroupId.Text = id.ToString(); // Store the ID for updating
        }

        private void btnUpdateGCF_Click(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(lblGroupId.Text);
            string groupCode = txtGCCF.Text;
            int numStudents = Convert.ToInt32(txtNOSCF.Text);
            string instructor = sltINSCF.SelectedItem.ToString();
            string description = txtDiscriptionCF.Text;

            int instructorId = sltINSCF.SelectedIndex > -1 ? Convert.ToInt32(sltINSCF.SelectedValue) : 0;

            int result = GroupBL.UpdateGroup(_group_id, groupCode, numStudents, instructorId, 1, description);

            if (result > 0)
            {
                MessageBox.Show("Group updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ParentForm?.Close(); // Close UpdateForm
            }
            else
            {
                MessageBox.Show("Failed to update group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInstructors()
        {
            try
            {
                // Get instructors from database
                DataTable dt = InstructorBL.GetInstructors();

                if (dt.Rows.Count > 0)
                {
                    // Insert "Select Instructor" Placeholder
                    DataRow newRow = dt.NewRow();
                    newRow["id"] = 0;
                    newRow["fname"] = "Select";
                    newRow["lname"] = "Instructor";
                    dt.Rows.InsertAt(newRow, 0);

                    // Combine First and Last Name
                    foreach (DataRow row in dt.Rows)
                    {
                        row["fname"] = row["fname"] + " " + row["lname"];
                    }

                    // Bind data to sltINS (ComboBox)
                    sltINSCF.DataSource = dt;
                    sltINSCF.DisplayMember = "fname";  // Show "fname lname"
                    sltINSCF.ValueMember = "id";       // Store instructor ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // Check if the control is inside a form and close the form
            if (this.ParentForm != null)
            {
                this.ParentForm.Close();
            }
        }
    }
}
