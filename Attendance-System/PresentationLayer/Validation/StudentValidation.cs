using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Attendance_System.PresentationLayer.Validation
{
    internal class StudentValidation
    {
           
            public static bool ValidateStudentInputs(ErrorProvider errorProvider, TextBox tbfname, TextBox tbLname, TextBox tboxEmail, TextBox tbpassword,TextBox tbGroupid, MaskedTextBox tbPhon, TextBox textBoxAddress)
            {
               
                errorProvider.Clear();

                bool isValid = true;

              
                if (string.IsNullOrWhiteSpace(tbfname.Text))
                {
                    errorProvider.SetError(tbfname, "First name is required.");
                    isValid = false;
                }

              
                if (string.IsNullOrWhiteSpace(tbLname.Text))
                {
                    errorProvider.SetError(tbLname, "Last name is required.");
                    isValid = false;
                }

              
                if (string.IsNullOrWhiteSpace(tboxEmail.Text) || !IsValidEmail(tboxEmail.Text))
                {
                    errorProvider.SetError(tboxEmail, "Valid email is required.");
                    isValid = false;
                }

              
                if (string.IsNullOrWhiteSpace(tbpassword.Text))
                {
                    errorProvider.SetError(tbpassword, "Password is required.");
                    isValid = false;
                }

              
                if (string.IsNullOrWhiteSpace(tbPhon.Text))
                {
                    errorProvider.SetError(tbPhon, "Phone number is required.");
                    isValid = false;
                }

              
                if (string.IsNullOrWhiteSpace(textBoxAddress.Text))
                {
                    errorProvider.SetError(textBoxAddress, "Address is required.");
                    isValid = false;
                }

                return isValid;
            }

         
            private static bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;
                email = email.Trim();
               
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
        }
    }



