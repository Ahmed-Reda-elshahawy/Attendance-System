using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Attendance_System.BusinessLayer;
using Attendance_System.PresentationLayer.Validation.YourNamespace;
using System.Net;

namespace Attendance_Management_System.PAL.User_Control
{
    public partial class UserControlRegister : UserControl
    {
        private int instructorID;
        public UserControlRegister()
        {
            InitializeComponent();
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Load all instructors
            dgv_instructors.DataSource = InstructorBL.GetInstructors();
            pb_hide.Visible = false;
            pb_view.Visible = true;
            pb_notshow.Visible = false;
            pb_show.Visible = true;

            // remove update tab
            tabControlInstructor.TabPages.Remove(tabPageUpdateInstructor);
        }

        // Method to clear all input fields
        private void ClearInputs()
        {
            tb_fname.Clear();
            tb_lname.Clear();
            tb_email.Clear();
            tb_password.Clear();
            tb_phone.Clear();
            tb_address.Clear();
            rd_male.Checked = true; // Reset gender selection
            rd_female.Checked = false; // Reset gender selection
            error_provider.Clear(); // Clear any error messages
        }

        private void ClearUpdateInputs()
        {
            tb_FN.Clear();
            tb_LN.Clear();
            tb_mail.Clear();
            tb_P.Clear();
            tb_ph.Clear();
            tb_add.Clear();
            male.Checked = true; // Reset gender selection
            female.Checked = false; // Reset gender selection
            error_provider.Clear(); // Clear any error messages
        }

        private void RefreshDataGridView()
        {
            dgv_instructors.DataSource = InstructorBL.GetInstructors();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateInstructorInputs(error_provider, tb_fname, tb_lname, tb_email, tb_password, tb_phone, tb_address))
            {
                return;
            }

            string fname = tb_fname.Text.Trim();
            string lname = tb_lname.Text.Trim();
            string email = tb_email.Text.Trim();
            string pass = tb_password.Text.Trim();
            int adminId = 1;
            string img = "";
            string phone = tb_phone.Text.Trim();
            string address = tb_address.Text.Trim();
            char gender = 'F';
            gender = (rd_male.Checked) ? 'M' : 'F';

            DataTable dt = InstructorBL.GetInstructorsByEmail(email);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Email already exists", "Failed to add data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int result = InstructorBL.AddInstructor(fname, lname, email, pass, adminId, img, phone, address, gender);
                if (result > 0)
                {
                    MessageBox.Show("Added Sussessfully", "Success Addition", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInputs();
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to Add Data", "Failed Addition", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv_instructors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int ins_id = Convert.ToInt32(dgv_instructors.SelectedRows[0].Cells["id"].Value);

            DialogResult res = MessageBox.Show("Are you sure you want to delete this instructor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                int result = InstructorBL.DeleteInstructor(ins_id);
                if (result > 0)
                {
                    MessageBox.Show("Deleted Sussessfully", "Success Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to Delete Data", "Failed Deletion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dgv_instructors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgv_instructors.SelectedRows[0];

            int instructorID = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string fname = selectedRow.Cells["fname"].Value.ToString();
            string lname = selectedRow.Cells["lname"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();
            string pass = selectedRow.Cells["password"].Value.ToString();
            string phone = selectedRow.Cells["phone"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            char gender = Convert.ToChar(selectedRow.Cells["Gender"].Value);

            // Add the update tab if it's not already added
            if (!tabControlInstructor.TabPages.Contains(tabPageUpdateInstructor))
            {
                tabControlInstructor.TabPages.Add(tabPageUpdateInstructor);
            }

            PopulateUpdateForm(instructorID, fname, lname, email, pass, phone, address, gender);

            tabControlInstructor.SelectedTab = tabPageUpdateInstructor;
        }
        private void PopulateUpdateForm(int insId, string fname, string lname, string email, string pass, string phone, string address, char gender)
        {
            tb_FN.Text = fname;
            tb_LN.Text = lname;
            tb_mail.Text = email;
            tb_P.Text = pass;
            tb_ph.Text = phone;
            tb_add.Text = address;
            if (gender == 'M')
            {
                male.Checked = true;
            }
            else
            {
                female.Checked = true;
            }

            this.instructorID = insId;
        }

        private void btn_saveUpdates_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.ValidateInstructorInputs(error_provider, tb_FN, tb_LN, tb_mail, tb_P, tb_ph, tb_add))
            {
                return;
            }

            string fname = tb_FN.Text;
            string lname = tb_LN.Text;
            string email = tb_mail.Text;
            string pass = tb_P.Text;
            string phone = tb_ph.Text;
            string address = tb_add.Text;
            char gender = male.Checked ? 'M' : 'F';

            int rowsAffected = InstructorBL.UpdateInstructor(instructorID, fname, lname, email, pass, phone, address, gender);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Instructor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Switch back to Tab 1
                tabControlInstructor.SelectedTab = tabPageSearchUser;

                // clear form
                ClearUpdateInputs();

                // remove update tab
                tabControlInstructor.TabPages.Remove(tabPageUpdateInstructor);

                // Refresh the DataGridView
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Failed to update instructor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pb_view_Click(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = false;
            pb_hide.Visible = true;
            pb_view.Visible = false;
        }

        private void pb_hide_Click(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;
            pb_hide.Visible = false;
            pb_view.Visible = true;
        }

        private void pb_show_Click(object sender, EventArgs e)
        {
            tb_P.UseSystemPasswordChar = false;
            pb_notshow.Visible = true;
            pb_show.Visible = false;
        }

        private void pb_notshow_Click(object sender, EventArgs e)
        {
            tb_P.UseSystemPasswordChar = true;
            pb_notshow.Visible = false;
            pb_show.Visible = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

            // Switch back to Tab 1
            tabControlInstructor.SelectedTab = tabPageSearchUser;

            // clear form
            ClearUpdateInputs();

            // remove update tab
            tabControlInstructor.TabPages.Remove(tabPageUpdateInstructor);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable originalDataTable = InstructorBL.GetInstructors();
            string searchTerm = textBoxSearch.Text.Trim();
            //if (string.IsNullOrEmpty(searchTerm))
            //{
            //    dgv_instructors.DataSource = originalDataTable;
            //    return;
            //}

            //// Use LINQ to filter the DataTable
            //var filteredRows = originalDataTable.AsEnumerable()
            //    .Where(row => row.Field<string>("fname").IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
            //                   row.Field<string>("lname").IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0);

            //// Convert the filtered rows to a new DataTable
            //DataTable filteredDataTable = filteredRows.Any() ? filteredRows.CopyToDataTable() : originalDataTable.Clone();

            //dgv_instructors.DataSource = filteredDataTable;

            DataView dv = originalDataTable.DefaultView;
            dv.RowFilter = $"fname like '%{searchTerm}%' or lname like '%{searchTerm}%'";
            dgv_instructors.DataSource = dv.ToTable();
        }

    }
}
