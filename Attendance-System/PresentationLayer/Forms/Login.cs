using Attendance_System.BusinessLayer;
using Attendance_System.Forms;
using Attendance_System.PresentationLayer.Forms;
using System.Data;

namespace Attendance_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            labelError.Visible = false; // Hide error label on form load
            PicInvalidUserOrpass.Visible = false; // Hide error icon
            txtbxLPassword.PasswordChar = '*';
        }


        private void labelError_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //string email = txtbxLName.Text.Trim();
            //string password = txtbxLPassword.Text.Trim();

            //if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            //{
            //    labelError.Text = "Please enter both Email and Password.";
            //    return;
            //}

            //DataTable result = AuthBL.Login(email, password);

            //if (result?.Rows.Count > 0)
            //{
            //    // Successful login
            //    MessageBox.Show("Login successful!");
            //    this.Hide();
            //    // Open the main application form here
            //    Login mainForm = new Login();
            //    mainForm.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    // Invalid credentials
            //    labelError.Text = "Invalid Email or Password.";
            //}

            string email = txtbxLName.Text.Trim();
            string password = txtbxLPassword.Text.Trim();

            // Reset error label visibility
            labelError.Visible = false;
            PicInvalidUserOrpass.Visible = false; // Hide error icon

            // Validation
            if (string.IsNullOrEmpty(email))
            {
                labelError.Text = "Please enter your Email.";
                labelError.Visible = true;
                PicInvalidUserOrpass.Visible = true; // Hide error icon
                txtbxLName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                labelError.Text = "Please enter your Password.";
                labelError.Visible = true;
                PicInvalidUserOrpass.Visible = true; // Hide error icon
                txtbxLPassword.Focus();
                return;
            }

            // Authenticate using business logic layer
            DataTable result = AuthBL.Login(email, password);

            if (result?.Rows.Count > 0)
            {
                // Successful login
                //MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Main Application Form (Replace 'MainForm' with your actual main form)
                //Login mainForm = new Login();
                //mainForm.Show();
                //----------------------------
                //MainForm Main_Form = new MainForm();
                //Main_Form.ShowDialog();
                //// Hide this login form
                //this.Close();
                //----------------------------
                int userId = Convert.ToInt32(result.Rows[0]["ID"]);
                string userRole = result.Rows[0]["Role"].ToString();

                Form nextForm = userRole switch
                {
                    "Admin" => new MainForm(userId,this),
                    "Instructor" => new InstructorForm(userId,this),
                    "Student" => new StudentForm(userId,this),
                    //"Admin" => new MainForm(),
                    //"Instructor" => new InstructorForm(),
                    //"Student" => new StudentForm(),
                    _ => null
                };

                if (nextForm != null)
                {
                    this.Hide();
                    nextForm.Show();
                    
                }
            }
            else
            {
                // Invalid credentials
                labelError.Text = "Invalid Email or Password.";
                labelError.Visible = true;
                PicInvalidUserOrpass.Visible = true; // Hide error icon
            }
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            Forgetpassword Forget_password = new Forgetpassword(this);
            this.Hide();
            Forget_password.ShowDialog();
            //this.Hide();
        }
    }
}
