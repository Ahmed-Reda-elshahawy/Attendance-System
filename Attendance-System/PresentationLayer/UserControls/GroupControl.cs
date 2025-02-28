using Attendance_System.BusinessLayer;
using Attendance_System.DataAccessLayer;
using Attendance_System.PresentationLayer.Forms;
using Microsoft.Data.SqlClient;
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
    public partial class GroupControl : UserControl
    {

        public GroupControl()
        {
            InitializeComponent();
            InitializeValidationLabels();
            LoadInstructors();
            LoadGroups();
            LoadGroupCodes();

            // Attach event handlers to filter data
            sltSGC.SelectedIndexChanged += sltSGC_SelectedIndexChanged;
            sltSGI.SelectedIndexChanged += sltSGI_SelectedIndexChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddG_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return; // Stop execution if validation fails
            }

            // Fetch input values
            string className = txtGC.Text.Trim();
            int classNum = int.Parse(txtNOS.Text.Trim()); // No need to validate again since ValidateInputs() handles it
            int instructorId = Convert.ToInt32(sltINS.SelectedValue);
            int adminId = 1; // Assume the admin ID is set dynamically
            string description = txtDiscription.Text.Trim();

            // Check for duplicate Group Code
            if (GroupBL.IsGroupExists(className))
            {
                MessageBox.Show("This Group Code already exists. Please use a different one.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Attempt to insert into the database
            try
            {
                int result = GroupBL.AddGroup(className, classNum, instructorId, adminId, description);

                if (result > 0)
                {
                    MessageBox.Show("Group added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields(); // Reset fields after success
                                   //RefreshGroupList(); // Refresh UI to show the new entry
                }
                else
                {
                    MessageBox.Show("Failed to add group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
            }
        }


        //private void btnAddG_Click(object sender, EventArgs e)
        //{
        //    // Fetch input values
        //    string className = txtGC.Text.Trim();
        //    string classNumStr = txtNOS.Text.Trim();
        //    string description = txtDiscription.Text.Trim();
        //    int instructorId = sltINS.SelectedIndex > -1 ? Convert.ToInt32(sltINS.SelectedValue) : 0;
        //    int adminId = 1; // Assume the admin ID is set dynamically

        //    // Validation checks
        //    if (string.IsNullOrWhiteSpace(className))
        //    {
        //        MessageBox.Show("Group Code is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    if (!int.TryParse(classNumStr, out int classNum) || classNum <= 0)
        //    {
        //        MessageBox.Show("Number of Students must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    //if (instructorId == 0)
        //    //{
        //    //    MessageBox.Show("Please select a valid Instructor.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    return;
        //    //}

        //    // Check for duplicate Group Code
        //    if (GroupBL.IsGroupExists(className))
        //    {
        //        MessageBox.Show("This Group Code already exists. Please use a different one.", "Duplicate Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Attempt to insert into the database
        //    try
        //    {
        //        int result = GroupBL.AddGroup(className, classNum, instructorId, adminId, description);

        //        if (result > 0)
        //        {
        //            MessageBox.Show("Group added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            ClearFields(); // Reset fields after success
        //            //RefreshGroupList(); // Refresh UI to show the new entry
        //        }
        //        else
        //        {
        //            MessageBox.Show("Failed to add group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        // Log error details (for debugging)
        //        Console.WriteLine($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}");
        //    }
        //}


        // Helper method to clear form fields
        private void ClearFields()
        {
            txtGC.Text = "";
            txtNOS.Text = "";
            txtDiscription.Text = "";
            sltINS.SelectedIndex = -1;
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
                    sltINS.DataSource = dt;
                    sltSGI.DataSource = dt;
                    sltINS.DisplayMember = "fname";  // Show "fname lname"
                    sltSGI.DisplayMember = "fname";  // Show "fname lname"
                    sltINS.ValueMember = "id";       // Store instructor ID
                    sltSGI.ValueMember = "id";       // Store instructor ID
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void LoadGroups()
        //{

        //    dgvG.Columns.Clear();
        //    dgvG.DataSource = null; // Optional: Reset the data source before binding

        //    try
        //    {
        //        // Fetch groups from the database
        //        DataTable dt = GroupBL.GetGroups();

        //        if (dt.Rows.Count > 0)
        //        {
        //            // Optionally, format columns (rename headers)
        //            dt.Columns[0].ColumnName = "ID";
        //            dt.Columns[1].ColumnName = "Group Code";
        //            dt.Columns[2].ColumnName = "Number Of Student";
        //            dt.Columns[3].ColumnName = "Instructor Name";
        //            dt.Columns[4].ColumnName = "Group Discription";

        //            // Bind data to DataGridView
        //            dgvG.DataSource = dt;
        //        }
        //        else
        //        {
        //            dgvG.DataSource = null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading groups: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void LoadGroups(DataTable customData = null)
        {
            dgvG.Columns.Clear();
            dgvG.DataSource = null; // Optional: Reset the data source before binding

            try
            {
                // Use provided DataTable or fetch from database
                DataTable dt = customData ?? GroupBL.GetGroups();

                if (dt.Rows.Count > 0)
                {
                    // Ensure column names are properly set
                    dt.Columns[0].ColumnName = "ID";
                    dt.Columns[1].ColumnName = "Group Code";
                    dt.Columns[2].ColumnName = "Number Of Student";
                    dt.Columns[3].ColumnName = "Instructor Name";
                    dt.Columns[4].ColumnName = "Group Description";

                    // Bind data to DataGridView
                    dgvG.DataSource = dt;
                }
                else
                {
                    dgvG.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading groups: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGDelete_Click(object sender, EventArgs e)
        {
            if (dgvG.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Assuming ID is the first column
                    int selectedID = Convert.ToInt32(dgvG.SelectedRows[0].Cells[0].Value);

                    // Code to remove from database goes here
                    try
                    {
                        GroupBL.DeleteGroup(selectedID);
                        MessageBox.Show("Group deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Refresh DataGridView
                        dgvG.DataSource = GroupBL.GetGroups();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Remove from DataGridView
                    //dgvG.Rows.RemoveAt(dgvG.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGUpdate_Click(object sender, EventArgs e)
        {
            if (dgvG.SelectedRows.Count > 0)
            {
                //int selectedID = Convert.ToInt32(dgvG.SelectedRows[0].Cells["ID"].Value);
                //string groupCode = dgvG.SelectedRows[0].Cells["Group Code"].Value.ToString();
                //int numStudents = Convert.ToInt32(dgvG.SelectedRows[0].Cells["Number Of Student"].Value);
                //string instructor = dgvG.SelectedRows[0].Cells["Instructor Name"].Value.ToString();
                //string description = dgvG.SelectedRows[0].Cells["Group Discription"].Value.ToString();


                int selectedID = Convert.ToInt32(dgvG.SelectedRows[0].Cells[0].Value);
                string groupCode = dgvG.SelectedRows[0].Cells[1].Value.ToString();
                int numStudents = Convert.ToInt32(dgvG.SelectedRows[0].Cells[3].Value);
                string instructor = dgvG.SelectedRows[0].Cells[4].Value.ToString();
                string description = dgvG.SelectedRows[0].Cells[5].Value.ToString();

                // Open UpdateForm and pass data
                UpdateForm updateForm = new UpdateForm(selectedID, groupCode, numStudents, instructor, description);
                updateForm.ShowDialog();
                LoadGroups();
            }
            else
            {
                MessageBox.Show("Please select a group to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LoadGroupCodes()
        {
            try
            {
                DataTable dt = GroupBL.GetGroupCodes();

                if (dt.Rows.Count > 0)
                {
                    DataRow newRow = dt.NewRow();
                    newRow["className"] = "Select Group";
                    dt.Rows.InsertAt(newRow, 0);

                    sltSGC.DataSource = dt;
                    sltSGC.DisplayMember = "className";
                    sltSGC.ValueMember = "className";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading group codes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FilterGroups()
        {
            string selectedGroupCode = sltSGC.SelectedIndex > 0 ? sltSGC.SelectedValue.ToString() : string.Empty;
            //string selectedInstructor = sltSGI.SelectedIndex > 0 ? sltSGI.SelectedItem.ToString() : string.Empty;
            int instructorId = sltSGI.SelectedIndex > -1 ? Convert.ToInt32(sltSGI.SelectedValue) : 0;

            //dgvG.DataSource = GroupBL.GetFilteredGroups(selectedGroupCode, selectedInstructor);
            //dgvG.DataSource = GroupBL.GetFilteredGroups(selectedGroupCode, instructorId);


            LoadGroups(GroupBL.GetFilteredGroups(selectedGroupCode, instructorId));
        }

        private void sltSGC_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGroups();
        }

        private void sltSGI_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGroups();
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            Color errorColor = Color.Red;

            // Validate Group Code
            if (string.IsNullOrWhiteSpace(txtGC.Text))
            {
                InvalidCode.Visible = true;
                LblInvalidCode.Text = "Group Code is required.";
                LblInvalidCode.ForeColor = errorColor;
                LblInvalidCode.Visible = true;
                isValid = false;
            }
            else
            {
                InvalidCode.Visible = false;
                LblInvalidCode.Visible = false;
            }

            // Validate Number of Students
            if (!int.TryParse(txtNOS.Text, out int numOfStudents) || numOfStudents <= 0)
            {
                InvalidNumOfStudent.Visible = true;
                LblInvalidNumOfStudent.Text = "Enter a valid positive number.";
                LblInvalidNumOfStudent.ForeColor = errorColor;
                LblInvalidNumOfStudent.Visible = true;
                isValid = false;
            }
            else
            {
                InvalidNumOfStudent.Visible = false;
                LblInvalidNumOfStudent.Visible = false;
            }

            // Validate Instructor Selection
            if (sltINS.SelectedIndex <= 0)
            {
                InvlideSLT.Visible = true;
                LblInvlideSLT.Text = "Please select an instructor.";
                LblInvlideSLT.ForeColor = errorColor;
                LblInvlideSLT.Visible = true;
                isValid = false;
            }
            else
            {
                InvlideSLT.Visible = false;
                LblInvlideSLT.Visible = false;
            }

            return isValid;
        }


        //private bool ValidateInputs()
        //{
        //    bool isValid = true;

        //    // Validate Group Code
        //    if (string.IsNullOrWhiteSpace(txtGC.Text))
        //    {
        //        InvalidCode.Visible = true;
        //        LblInvalidCode.Visible = true;
        //        isValid = false;
        //    }
        //    else
        //    {
        //        InvalidCode.Visible = false;
        //        LblInvalidCode.Visible = false;
        //    }

        //    // Validate Number of Students
        //    if (!int.TryParse(txtNOS.Text, out int numOfStudents) || numOfStudents <= 0)
        //    {
        //        InvalidNumOfStudent.Visible = true;
        //        LblInvalidNumOfStudent.Visible = true;
        //        isValid = false;
        //    }
        //    else
        //    {
        //        InvalidNumOfStudent.Visible = false;
        //        LblInvalidNumOfStudent.Visible = false;
        //    }

        //    // Validate Instructor Selection
        //    if (sltINS.SelectedIndex <= 0)
        //    {
        //        InvlideSLT.Visible = true;
        //        LblInvlideSLT.Visible = true;
        //        isValid = false;
        //    }
        //    else
        //    {
        //        InvlideSLT.Visible = false;
        //        LblInvlideSLT.Visible = false;
        //    }

        //    return isValid;
        //}

        private void InitializeValidationLabels()
        {
            InvalidCode.Visible = false;
            LblInvalidCode.Visible = false;
            LblInvalidCode.Text = "";

            InvalidNumOfStudent.Visible = false;
            LblInvalidNumOfStudent.Visible = false;
            LblInvalidNumOfStudent.Text = "";

            InvlideSLT.Visible = false;
            LblInvlideSLT.Visible = false;
            LblInvlideSLT.Text = "";
        }

        


    }
}


