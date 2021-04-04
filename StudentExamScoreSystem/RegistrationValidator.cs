using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExamScoreSystem
{
    public class RegistrationValidator : IValidator
    {
        LoginScreen screen;

        public RegistrationValidator(LoginScreen loginScreen)
        {
            this.screen = loginScreen;
        }

        public bool AreAllInputsValid()
        {
            bool isThereAnyInvalidInput = false;

            if (!NameInputIsValid())
                isThereAnyInvalidInput = true;

            if (!SurnameInputIsValid())
                isThereAnyInvalidInput = true;

            if (!UsernameInputIsValid())
                isThereAnyInvalidInput = true;
            if (!PasswordInputIsValid())
                isThereAnyInvalidInput = true;

            if (isThereAnyInvalidInput)
                return false;

            return true;
        }

        private bool NameInputIsValid()
        {
            if (NameIsCorrect())
            {
                screen.NameValidatorLabel.Text = "Enter first name";
                return false;
            }

            screen.NameValidatorLabel.Text = "";
            return true;
        }
        private bool NameIsCorrect() => screen._NameTextBox.Text.Trim().Length == 0 || screen._NameTextBox.Text.Any(char.IsDigit);


        private bool SurnameInputIsValid()
        {
            if (SurnameIsCorrect())
            {
                screen.SurnameValidatorLabel.Text = "Enter last name";
                return false;
            }

            screen.SurnameValidatorLabel.Text = "";
            return true;
        }
        private bool SurnameIsCorrect() => screen._SurnameTextBox.Text.Trim().Length == 0 || screen._SurnameTextBox.Text.Any(char.IsDigit);


        private bool UsernameInputIsValid()
        {
            string username = screen.RUsernameTextBox.Text.Trim();

            if (username.Length == 0)
                return false;
            
            List<string> allUserData = UserFileUtil.GetAllUserData();

            bool userExists = UsernameExists(allUserData, username);

            if (userExists)
            {
                screen.RegisterUserNameValidatorLabel.Text = "This username is already registered";
                return false;
            }

            screen.RegisterUserNameValidatorLabel.Text = "";
            return true;
        }
        private bool UsernameExists(List<string> lines, string username)
        {

            foreach (string line in lines)
            {
                string[] splitted = line.Split(' ');
                if (splitted[0].Equals(username))
                    return true;
            }
            return false;
        }

        private bool PasswordInputIsValid()
        {
            string password = screen.RPasswordTextBox.Text.Trim();
            string confirmed = screen.ConfirmTextBox.Text.Trim();

            bool equal = password.Equals(confirmed);

            if (!equal) 
            {
                screen.RegisterPasswordValidatorLabel.Text = "Those passwords didn’t match. Try again.";
                return false;
            }

            screen.RegisterPasswordValidatorLabel.Text = "";
            return true;
        }

    }
}
