using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExamScoreSystem
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        bool isUsernameActive = true;
        bool isPasswordActive = true;
        bool isNameActive = true;
        bool isSurnameActive = true;
        bool isRegisterUsernameActive = true;
        bool isRegisterPasswordActive = true;
        bool isConfirmActive = true;
        
        Color grayColor = Color.FromArgb(149, 156, 161);




        public void InitializeFocus()
        {

            userNameTextBox.Text = "Username";
            passwordTextBox.Text = "Password";
            NameTextBox.Text = "First name";
            SurnameTextBox.Text = "Last name";
            registerUserNameTextBox.Text = "Username";
            registerPasswordTextBox.Text = "Password";
            confirmTextBox.Text = "Confirm";

            userNameTextBox.ForeColor = grayColor;
            passwordTextBox.ForeColor = grayColor;
            NameTextBox.ForeColor = grayColor;
            SurnameTextBox.ForeColor = grayColor;
            registerUserNameTextBox.ForeColor = grayColor;
            registerPasswordTextBox.ForeColor = grayColor;
            confirmTextBox.ForeColor = grayColor;


            this.userNameTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isUsernameActive)
                {
                    isUsernameActive = false;
                    this.userNameTextBox.Text = "";
                    this.userNameTextBox.ForeColor = Color.White;
                }
            };


            this.userNameTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isUsernameActive && string.IsNullOrEmpty(this.userNameTextBox.Text))
                {
                    isUsernameActive = true;
                    this.userNameTextBox.Text = "Username";
                    this.userNameTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                }
            };
            //***************************************************************************
            this.passwordTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isPasswordActive)
                {
                    isPasswordActive = false;
                    this.passwordTextBox.Text = "";
                    this.passwordTextBox.ForeColor = Color.White;
                    this.passwordTextBox.PasswordChar = '•';
                }
            };

            this.passwordTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isPasswordActive && string.IsNullOrEmpty(this.passwordTextBox.Text))
                {
                    isPasswordActive = true;
                    this.passwordTextBox.PasswordChar = '\u0000';
                    this.passwordTextBox.Text = "Password";
                    this.passwordTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                }
            };
            //***************************************************************************

            this.NameTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isNameActive)
                {
                    isNameActive = false;
                    this.NameTextBox.Text = "";
                    this.NameTextBox.ForeColor = Color.White;
                }
            };

            this.NameTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isNameActive && string.IsNullOrEmpty(this.NameTextBox.Text))
                {
                    isNameActive = true;
                    this.NameTextBox.Text = "First name";
                    this.NameTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                }
            };


            //***************************************************************************

            this.SurnameTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isSurnameActive)
                {
                    isSurnameActive = false;
                    this.SurnameTextBox.Text = "";
                    this.SurnameTextBox.ForeColor = Color.White;
                }
            };

            this.SurnameTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isSurnameActive && string.IsNullOrEmpty(this.SurnameTextBox.Text))
                {
                    isSurnameActive = true;
                    this.SurnameTextBox.Text = "Last name";
                    this.SurnameTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                }
            };


            //***************************************************************************


            this.registerUserNameTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isRegisterUsernameActive)
                {
                    isRegisterUsernameActive = false;
                    this.registerUserNameTextBox.Text = "";
                    this.registerUserNameTextBox.ForeColor = Color.White;
                }
            };

            this.registerUserNameTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isRegisterUsernameActive && string.IsNullOrEmpty(this.registerUserNameTextBox.Text))
                {
                    isRegisterUsernameActive = true;
                    this.registerUserNameTextBox.Text = "Username";
                    this.registerUserNameTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                }
            };
            //***************************************************************************

            this.registerPasswordTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isRegisterPasswordActive)
                {
                    isRegisterPasswordActive = false;
                    this.registerPasswordTextBox.Text = "";
                    this.registerPasswordTextBox.ForeColor = Color.White;
                    this.registerPasswordTextBox.PasswordChar = '•';
                }
            };

            this.registerPasswordTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isRegisterPasswordActive && string.IsNullOrEmpty(this.registerPasswordTextBox.Text))
                {
                    isRegisterPasswordActive = true;
                    this.registerPasswordTextBox.Text = "Password";
                    this.registerPasswordTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                    this.registerPasswordTextBox.PasswordChar = '\u0000';
                }
            };


            //***************************************************************************




            this.confirmTextBox.GotFocus += (source, eventArgs) =>
            {
                if (this.isConfirmActive)
                {
                    isConfirmActive = false;
                    this.confirmTextBox.Text = "";
                    this.confirmTextBox.ForeColor = Color.White;
                    this.confirmTextBox.PasswordChar = '•';
                }
            };

            this.confirmTextBox.LostFocus += (source, eventArgs) =>
            {
                if (!this.isConfirmActive && string.IsNullOrEmpty(this.confirmTextBox.Text))
                {
                    isConfirmActive = true;
                    this.confirmTextBox.Text = "Confirm";
                    this.confirmTextBox.ForeColor = Color.FromArgb(149, 156, 161);
                    this.confirmTextBox.PasswordChar = '\u0000';
                }
            };
        }








        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Console.WriteLine(passwordTextBox.PasswordChar);
            InitializeFocus();
        }

        private void LoginTab_Click(object sender, EventArgs e)
        {
            LoginPanel.Show();
            RegistrationPanel.Hide();
        }

        private void RegisterTab_Click(object sender, EventArgs e)
        {
            RegistrationPanel.Show();
            LoginPanel.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\u0000';
            }
            else
            {
                passwordTextBox.PasswordChar = '•';
            }
        }
    }

}
