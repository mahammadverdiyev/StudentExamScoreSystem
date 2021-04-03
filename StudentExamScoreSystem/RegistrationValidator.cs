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


            if (isThereAnyInvalidInput)
                return false;

            return true;
        }

        public bool NameInputIsValid()
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


        public bool SurnameInputIsValid()
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
    }
}
