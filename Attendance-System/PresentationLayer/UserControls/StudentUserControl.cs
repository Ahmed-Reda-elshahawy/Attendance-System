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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Attendance_System.PresentationLayer.Validation.YourNamespace;
using System.ComponentModel.DataAnnotations;
using Attendance_System.PresentationLayer.Validation;
using Microsoft.IdentityModel.Tokens;
namespace Attendance_Management_System.PAL.User_Control
{
    public partial class StudentUserControl : UserControl
    {
        private int studentID;
        public StudentUserControl()
        {

            InitializeComponent();

            tbPass.UseSystemPasswordChar = true;
            tbpassword.UseSystemPasswordChar = true;


            pbShow.Visible = true;
            pbNotshow.Visible = false;
            pbView.Visible = true;
            pbHide.Visible = false;


            pbShow.Click += pbShow_Click;
            pbNotshow.Click += pbNotshow_Click;
            pbView.Click += pbView_Click;
            pbHide.Click += pbHide_Click;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            PopulateSearchComboBox();
            dvgStudent.DataSource = StudentBL.GetStudents();
            pbHide.Visible = false;
            pbView.Visible = true;
            pbNotshow.Visible = false;
            pbShow.Visible = true;
        }
        private void ClearInputs()
        {
            tbfname.Clear();
            tbLname.Clear();
            tboxEmail.Clear();
            tbpassword.Clear();
            tbPhon.Clear();
            textBoxAddress.Clear();
            tbGroupid.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            error_provider.Clear();

        }
        private void RefreshDataGridView()
        {
            dvgStudent.DataSource = StudentBL.GetStudents();
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tabPageAddStudent_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            if (!StudentValidation.ValidateStudentInputs(error_provider, tbfname, tbLname, tboxEmail, tbpassword, tbGroupid, tbPhon, textBoxAddress))
            {
                return;
            }
            int groupId;
            if (!int.TryParse(tbGroupid.Text, out groupId))
            {
                MessageBox.Show("Invalid Group ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fname = tbfname.Text;
            string lname = tbLname.Text;
            string email = tboxEmail.Text;
            string pass = tbpassword.Text;

            int adminId = 1;

            string phone = tbPhon.Text;
            string address = textBoxAddress.Text;
            char gender = radioButtonMale.Checked ? 'M' : 'F';

            int result = StudentBL.AddStudent(fname, lname, email, pass, groupId, adminId, phone, address, gender);
            if (result > 0)
            {
                MessageBox.Show("Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Failed to Add Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow selectedRow = dvgStudent.SelectedRows[0];

                studentID = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string fname = selectedRow.Cells["fname"].Value.ToString();
                string lname = selectedRow.Cells["lname"].Value.ToString();
                string email = selectedRow.Cells["email"].Value.ToString();
                string pass = selectedRow.Cells["pass"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                char gender = Convert.ToChar(selectedRow.Cells["Gender"].Value);

                int groupId = 0;
                if (selectedRow.Cells["class_id"].Value != null && int.TryParse(selectedRow.Cells["class_id"].Value.ToString(), out int validGroupId))
                {
                    groupId = validGroupId;
                }
                else
                {
                    MessageBox.Show("Invalid Group ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                PopulateUpdateForm(studentID, fname, lname, email, pass, phone, address, gender, groupId);
                tabControlRegister.SelectedTab = tPUpdate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while retrieving student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PopulateUpdateForm(int stuId, string fname, string lname, string email, string pass, string phone, string address, char gender, int groupId)
        {
            tbFN.Text = fname;
            tbLN.Text = lname;
            tbEmail.Text = email;
            tbPass.Text = pass;
            tbGId.Text = groupId.ToString();
            tbPhone.Text = phone;
            textBoxSearch.Clear();
            tbaddress.Text = address;
            rbMale.Checked = (gender == 'M');
            rbFemale.Checked = (gender == 'F');
            studentID = stuId;


        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId;
                if (!int.TryParse(tbGId.Text, out groupId))
                {
                    MessageBox.Show("Invalid Group ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string fname = tbFN.Text;
                string lname = tbLN.Text;
                string email = tbEmail.Text;
                string pass = tbPass.Text;
                string phone = tbPhone.Text;
                string address = tbaddress.Text;
                char gender = rbMale.Checked ? 'M' : 'F';

                int groupID;
                if (!int.TryParse(tbGId.Text, out groupID))
                {
                    MessageBox.Show("Invalid Class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int rowsAffected = StudentBL.UpdateStudent(studentID, fname, lname, email, pass, groupId, 1, phone, address, gender);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tabControlRegister.SelectedTab = TPSearch;
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed to update student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvgStudent.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int studentId = Convert.ToInt32(dvgStudent.SelectedRows[0].Cells["id"].Value);

                DialogResult res = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    int result = StudentBL.DeleteStudent(studentId);
                    if (result > 0)
                    {
                        MessageBox.Show("Deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during deletion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbShow_Click(object sender, EventArgs e)
        {

            tbPass.UseSystemPasswordChar = false;


            pbShow.Visible = false;
            pbNotshow.Visible = true;
        }

        private void pbNotshow_Click(object sender, EventArgs e)
        {

            tbPass.UseSystemPasswordChar = true;


            pbShow.Visible = true;
            pbNotshow.Visible = false;
        }

        private void pbView_Click(object sender, EventArgs e)
        {

            tbpassword.UseSystemPasswordChar = false;


            pbView.Visible = false;
            pbHide.Visible = true;
        }

        private void pbHide_Click(object sender, EventArgs e)
        {

            tbpassword.UseSystemPasswordChar = true;


            pbView.Visible = true;
            pbHide.Visible = false;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(textBoxSearch.Text))
                {
                    RefreshDataGridView();
                    return;
                }


                if (!int.TryParse(textBoxSearch.Text, out int searchId))
                {

                    return;
                }


                DataTable searchResult = StudentBL.SearchStudentById(searchId);


                if (searchResult != null && searchResult.Rows.Count > 0)
                {

                    dvgStudent.DataSource = searchResult;
                }
                else
                {
                    MessageBox.Show("No student found with the given ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {

            textBoxSearch.Clear();
            RefreshDataGridView();
        }
        private void PopulateSearchComboBox()
        {
            DataTable students = StudentBL.GetStudents();


            comboBox1.Items.Clear();


            foreach (DataRow row in students.Rows)
            {
                string displayText = $"{row["fname"]} {row["lname"]} - G: {row["class_id"]}";
                comboBox1.Items.Add(displayText);
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string searchTerm = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    MessageBox.Show("Please select a valid student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!IsValidFormat(searchTerm))
                {
                    MessageBox.Show("Invalid format in selected item. Expected format: 'First Name Last Name - Group: ID'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string[] parts = searchTerm.Split(new[] { " - " }, StringSplitOptions.None);


                string firstName = parts[0].Split(' ')[0];
                string lastName = parts[0].Split(' ')[1];
                string groupId = parts[1].Replace("G:", "");


                Console.WriteLine($"Searching for: First Name = {firstName}, Last Name = {lastName}, GroupId = {groupId}");


                DataTable searchResult = StudentBL.SearchStudent(
                    new[] { "fname", "lname", "class_id" },
                    new[] { firstName, lastName, groupId }
                );


                if (searchResult != null && searchResult.Rows.Count > 0)
                {
                    dvgStudent.DataSource = searchResult;
                }
                else
                {

                    MessageBox.Show("No students found matching the selected value.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidFormat(string searchTerm)
        {

            string[] parts = searchTerm.Split(new[] { " - " }, StringSplitOptions.None);
            return parts.Length == 2 && parts[1].StartsWith("G: ");
        }









        private void TPSearch_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();







        }



    }
}


