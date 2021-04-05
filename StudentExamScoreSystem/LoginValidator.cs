using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExamScoreSystem
{
    class LoginValidator : IValidator
    {
        LoginScreen screen;

        public LoginValidator(LoginScreen loginScreen)
        {
            screen = loginScreen;
        }

        public bool AreAllInputsValid()
        {
            bool isThereAnyInvalidInput = false;

            if (!UsernameInputIsValid())
                isThereAnyInvalidInput = true;

            if (!PasswordInputIsValid())
                isThereAnyInvalidInput = true;

            if (isThereAnyInvalidInput)
                return false;

            return true;
        }

        private bool UsernameInputIsValid()
        {
            if (FieldIsEmpty(screen.UsernameTextBox,"Username"))
            {
                screen.UsernameValidatorLabel.Text = "Enter valid username";
                return false;
            }
            if(FieldIsEmpty(screen.PasswordTextBox,"Password"))
                return false;

            string username = screen.UsernameTextBox.Text.Trim();

            bool userExists = UserFileUtil.UsernameExists(username);

            if (!userExists)
            {
                screen.UsernameValidatorLabel.Text = "Couldn't find your username";
                return false;
            }

            screen.UsernameValidatorLabel.Text = "";
            return true;
        }

        private bool PasswordInputIsValid()
        {
            if(FieldIsEmpty(screen.PasswordTextBox,"Password"))
            {
                screen.PasswordValidatorLabel.Text = "Enter password";
                return false;
            }
            if(FieldIsEmpty(screen.UsernameTextBox,"Username"))
                return false;
            string username = screen.UsernameTextBox.Text.Trim();
            string password = screen.PasswordTextBox.Text.Trim();

            bool passWordMatches = UserFileUtil.UsernamePasswordMatches(username, password);

            if(!passWordMatches)
            {
                if(screen.UsernameValidatorLabel.Text.Length == 0)
                {
                    screen.PasswordValidatorLabel.Text = "Password is wrong";
                }
                else
                {
                    screen.PasswordValidatorLabel.Text = "Username or password is wrong";
                }
                return false;
            }

            screen.PasswordValidatorLabel.Text = "";
            return true;
        }

        private bool FieldIsEmpty(TextBox textBox, string wrongText) =>
            textBox.Text.Equals(wrongText)
         || textBox.Text.Trim().Length == 0;
    }
}
