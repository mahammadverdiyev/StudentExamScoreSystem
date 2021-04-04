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
        RegistrationValidator registrationValidator;
        int sliderDisplacement = 28;
        bool isUsernameActive = true;
        bool isPasswordActive = true;
        bool isNameActive = true;
        bool isSurnameActive = true;
        bool isRegisterUsernameActive = true;
        bool isRegisterPasswordActive = true;
        bool isConfirmActive = true;
        
        Color grayColor = Color.FromArgb(149, 156, 161);


        public Label NameValidatorLabel => nameValidatorLabel;
        public Label SurnameValidatorLabel => surnameValidatorLabel;
        public Label RegisterUserNameValidatorLabel => registerUserNameValidatorLabel;
        public Label RegisterPasswordValidatorLabel => registerPasswordValidatorLabel;

        public TextBox _NameTextBox => this.NameTextBox;
        public TextBox _SurnameTextBox => this.SurnameTextBox;
        public TextBox RUsernameTextBox => this.registerUserNameTextBox;
        public TextBox RPasswordTextBox => this.registerPasswordTextBox;
        public TextBox ConfirmTextBox => this.confirmTextBox;


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







        private void ResetLabels()
        {
            nameValidatorLabel.Text = "";
            surnameValidatorLabel.Text = "";
            registerUserNameValidatorLabel.Text = "";
            registerPasswordValidatorLabel.Text = "";
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            ResetLabels();
            InitializeFocus();
            registrationValidator = new RegistrationValidator(this);
        }

        private void LoginTab_Click(object sender, EventArgs e)
        {
            //Slider.Location = new Point(7, 95);
            timer_slider.Start();
            RegisterTab.BackColor = Color.FromArgb(59, 102, 128);
            LoginTab.BackColor = Color.FromArgb(23, 117, 173);
            LoginPanel.Show();
            RegistrationPanel.Hide();
        }

        private void RegisterTab_Click(object sender, EventArgs e)
        {
            //Slider.Location = new Point(243, 95);
            timer_slider.Start();
            LoginTab.BackColor = Color.FromArgb(59, 102, 128);
            RegisterTab.BackColor = Color.FromArgb(23, 117, 173);
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

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(179, 71, 71);
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.FromArgb(32, 51, 60);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_slider_Tick(object sender, EventArgs e)
        {
            int currX = Slider.Location.X;
            int currY = Slider.Location.Y;

            if (sliderDisplacement > 0)
            {
                if ((RegisterTab.Location.X - Slider.Location.X) >= sliderDisplacement)
                {
                    Slider.Location = new Point(currX + sliderDisplacement, currY);
                }
                else
                {
                    Slider.Location = new Point(RegisterTab.Location.X, currY);
                    sliderDisplacement = -sliderDisplacement;
                    timer_slider.Stop();
                }
            }
            else
            {
                if ((Slider.Location.X - LoginTab.Location.X) >= -sliderDisplacement)
                {
                    Slider.Location = new Point(currX + sliderDisplacement, currY);
                }
                else
                {
                    Slider.Location = new Point(LoginTab.Location.X, currY);
                    sliderDisplacement = -sliderDisplacement;
                    timer_slider.Stop();
                }

            }
        }

        private void AddNewUser(List<string> allUserData)
        {
            string name = NameTextBox.Text.Trim();
            string surname = SurnameTextBox.Text.Trim();
            string username = registerUserNameTextBox.Text.Trim();
            string password = registerPasswordTextBox.Text.Trim();
            string line = $"{username} {name} {surname} {password}";
            Console.WriteLine(allUserData.Count);
            int index = allUserData.Count == 0 ? 0 : allUserData.Count - 1;
            allUserData.Insert(index, line);
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            bool canAccess = registrationValidator.AreAllInputsValid();
            if (canAccess)
            {
                List<string> allUserData = UserFileUtil.GetAllUserData();
                AddNewUser(allUserData);
                UserFileUtil.EncryptAllDataInList(allUserData);
                MessageBox.Show("Successfully registered!");
            }
        }

    }

}
