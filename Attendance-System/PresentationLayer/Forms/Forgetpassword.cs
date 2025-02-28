using Attendance_System.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System
{
    public partial class Forgetpassword : Form
    {
        private Form parentForm;
        public Forgetpassword(Form parent)
        {
            InitializeComponent();
            parentForm = parent;
            labelError.Visible = false;  // Hide error message initially
            InvlidEmail.Visible = false; // Hide invalid email icon initially
            this.FormClosing += Forgetpassword_FormClosing;
        }

        private void txtbxforget_TextChanged(object sender, EventArgs e)
        {
            ValidateEmail();
        }

        private void ValidateEmail()
        {
            string email = txtbxforget.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic email validation pattern

            if (Regex.IsMatch(email, pattern))
            {
                labelError.Visible = false;
                InvlidEmail.Visible = false;
                btnVerify.Enabled = true;
            }
            else
            {
                labelError.Visible = true;
                InvlidEmail.Visible = true;
                btnVerify.Enabled = false;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            //    string email = txtbxforget.Text;

            //    if (string.IsNullOrWhiteSpace(email))
            //    {
            //        MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }

            //    if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            //    {
            //        MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    if (AuthBL.EmailExists(email))
            //    {
            //        MessageBox.Show("Email found. Proceed with password recovery.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        // You can now proceed with sending a password reset link or showing further options.
            //    }
            //    else
            //    {
            //        MessageBox.Show("Email not found in our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //string email = txtbxforget.Text.Trim();

            //if (string.IsNullOrWhiteSpace(email))
            //{
            //    MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            //{
            //    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //// Try to reset the password
            //string newPassword = AuthBL.ResetPassword(email);

            //if (newPassword != null)
            //{
            //    MessageBox.Show($"Your new password is: {newPassword}", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Email not found in our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            string email = txtbxforget.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter an email address.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Generate new password and update the database
            string newPassword = AuthBL.ResetPassword(email);

            if (newPassword != null)
            {
                // Send the new password via email
                bool emailSent = SendPasswordResetEmail(email, newPassword);

                if (emailSent)
                {
                    MessageBox.Show("A new password has been sent to your email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to send email. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email not found in our records.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SendPasswordResetEmail(string toEmail, string newPassword)
        {
            try
            {
                string fromEmail = "medomedoftab@gmail.com\r\n"; // Change this
                string fromPassword = "kapz ftkh kylf uolx"; // Use an app password, not your real password

                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = "Password Reset Request";
                mail.Body = $"Hello,\n\nYour password has been reset. Your new password is: {newPassword}\n\nPlease change it after logging in.";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true
                };

                smtp.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PicVBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void PicVBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Forgetpassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (parentForm != null)
            {
                MessageBox.Show("Failed to send email. Error: ");

               parentForm.Show();
            }
        }
    }
}
