﻿using System;
using System.Linq;

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
            if (IsNameIncorrect())
            {
                screen.NameValidatorLabel.Text = "Enter first name";
                return false;
            }

            screen.NameValidatorLabel.Text = "";
            return true;
        }
        private bool IsNameIncorrect() =>
            screen._NameTextBox.Text.Trim().Equals("First name")
         || screen._NameTextBox.Text.Any(char.IsDigit)
         || screen._NameTextBox.Text.Where(char.IsLetter).Count() == 0;

        private bool SurnameInputIsValid()
        {
            if (IsSurnameIncorrect())
            {
                screen.SurnameValidatorLabel.Text = "Enter last name";
                return false;
            }

            screen.SurnameValidatorLabel.Text = "";
            return true;
        }
        private bool IsSurnameIncorrect() => 
            screen._SurnameTextBox.Text.Trim().Equals("Last name")
        || screen._SurnameTextBox.Text.Any(char.IsDigit)
        || screen._SurnameTextBox.Text.Where(char.IsLetter).Count() == 0;


        private bool UsernameInputIsValid()
        {
            string username = screen.RUsernameTextBox.Text.Trim();

            if (username.Length == 0)
            {
                screen.RegisterUserNameValidatorLabel.Text = "Enter username";
                return false;
            }

            if (username.Where(Char.IsLetter).Count() == 0)
            {
                screen.RegisterUserNameValidatorLabel.Text = "Wrong username format";
                return false;
            }
            
            if (username.Equals("Username"))
            {
                screen.RegisterUserNameValidatorLabel.Text = "Enter valid username";
                return false;
            }
            
            bool userExists = UserFileUtil.UsernameExists(username);

            if (userExists)
            {
                screen.RegisterUserNameValidatorLabel.Text = "This username is already registered";
                return false;
            }

            screen.RegisterUserNameValidatorLabel.Text = "";
            return true;
        }

        private bool PasswordInputIsValid()
        {
            string password = screen.RPasswordTextBox.Text.Trim();
            string confirmed = screen.ConfirmTextBox.Text.Trim();

            if (IsPasswordEmpty(password, confirmed))
            {
                screen.RegisterPasswordValidatorLabel.Text = "Enter password";
                return false;
            }

            bool equal = password.Equals(confirmed);

            if (!equal) 
            {
                screen.RegisterPasswordValidatorLabel.Text = "Those passwords didn’t match. Try again.";
                return false;
            }

            screen.RegisterPasswordValidatorLabel.Text = "";
            return true;
        }

        private bool IsPasswordEmpty(string password, string confirmed) =>
                password.Length == 0 || confirmed.Length == 0;

    }
}
