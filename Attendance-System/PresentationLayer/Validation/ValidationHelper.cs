using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attendance_System.PresentationLayer.Validation
{
    using System;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    namespace YourNamespace
    {
        public static class ValidationHelper
        {
            // Validate inputs for the instructor form
            public static bool ValidateInstructorInputs(ErrorProvider errorProvider, TextBox tb_fname, TextBox tb_lname, TextBox tb_email, TextBox tb_password, MaskedTextBox tb_phone, TextBox tb_address)
            {
                // Clear previous errors
                errorProvider.Clear();

                bool isValid = true;

                // Validate First Name
                if (string.IsNullOrWhiteSpace(tb_fname.Text))
                {
                    errorProvider.SetError(tb_fname, "First name is required.");
                    isValid = false;
                }

                // Validate Last Name
                if (string.IsNullOrWhiteSpace(tb_lname.Text))
                {
                    errorProvider.SetError(tb_lname, "Last name is required.");
                    isValid = false;
                }

                // Validate Email
                if (string.IsNullOrWhiteSpace(tb_email.Text) || !IsValidEmail(tb_email.Text))
                {
                    errorProvider.SetError(tb_email, "Valid email is required.");
                    isValid = false;
                }

                // Validate Password
                if (string.IsNullOrWhiteSpace(tb_password.Text))
                {
                    errorProvider.SetError(tb_password, "Password is required.");
                    isValid = false;
                }

                // Validate Phone
                if (string.IsNullOrWhiteSpace(tb_phone.Text))
                {
                    errorProvider.SetError(tb_phone, "Phone number is required.");
                    isValid = false;
                }

                // Validate Address
                if (string.IsNullOrWhiteSpace(tb_address.Text))
                {
                    errorProvider.SetError(tb_address, "Address is required.");
                    isValid = false;
                }

                return isValid;
            }

            // Helper method to validate email format
            private static bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;
                email = email.Trim();
                // Regex pattern for validating email addresses
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
        }
    }
}
