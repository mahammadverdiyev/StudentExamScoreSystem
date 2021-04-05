using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace StudentExamScoreSystem
{
    public partial class LoginScreen : Form
    {

        public LoginScreen()
        {
            InitializeComponent();
        }
        int currentTabIndex = 0;
        RegistrationValidator registrationValidator;
        LoginValidator loginValidator;
        int sliderDisplacement = 28;
        
        StudentExamScoreSys system;

        public Label NameValidatorLabel => nameValidatorLabel;
        public Label SurnameValidatorLabel => surnameValidatorLabel;
        public Label RegisterUserNameValidatorLabel => registerUserNameValidatorLabel;
        public Label RegisterPasswordValidatorLabel => registerPasswordValidatorLabel;
        public Label UsernameValidatorLabel => this.usernameValidatorLabel;
        public Label PasswordValidatorLabel => this.passwordValidatorLabel;

        public TextBox _NameTextBox => this.NameTextBox;
        public TextBox _SurnameTextBox => this.SurnameTextBox;
        public TextBox RUsernameTextBox => this.registerUserNameTextBox;
        public TextBox RPasswordTextBox => this.registerPasswordTextBox;
        public TextBox ConfirmTextBox => this.confirmTextBox;

        public TextBox UsernameTextBox => this.userNameTextBox;
        public TextBox PasswordTextBox => this.passwordTextBox;



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void ResetLabels()
        {
            usernameValidatorLabel.Text = "";
            passwordValidatorLabel.Text = "";
            nameValidatorLabel.Text = "";
            surnameValidatorLabel.Text = "";
            registerUserNameValidatorLabel.Text = "";
            registerPasswordValidatorLabel.Text = "";
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            ResetLabels();
            registrationValidator = new RegistrationValidator(this);
            loginValidator = new LoginValidator(this);
        }

        private void LoginTab_Click(object sender, EventArgs e)
        {
            if(currentTabIndex == 1)
            {
                timer_slider.Start();
                RegisterTab.BackColor = Color.FromArgb(59, 102, 128);
                LoginTab.BackColor = Color.FromArgb(23, 117, 173);
                LoginPanel.Show();
                RegistrationPanel.Hide();
                currentTabIndex = 0;
            }

        }

        private void RegisterTab_Click(object sender, EventArgs e)
        {
            if(currentTabIndex == 0)
            {
                timer_slider.Start();
                LoginTab.BackColor = Color.FromArgb(59, 102, 128);
                RegisterTab.BackColor = Color.FromArgb(23, 117, 173);
                RegistrationPanel.Show();
                LoginPanel.Hide();
                currentTabIndex = 1;
            }
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

        private void ClearAllInputs()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            NameTextBox.Clear();
            SurnameTextBox.Clear();
            registerUserNameTextBox.Clear();
            registerPasswordTextBox.Clear();
            confirmTextBox.Clear();
        }

        private void InitializeSystem()
        {
            system = new StudentExamScoreSys();
            system.FormClosed += delegate
            {
                this.Show();
                ResetLabels();
                ClearAllInputs();
                ActiveControl = null;
            };
        }

        private void StartSystem()
        {
            InitializeSystem();
            this.Hide();
            system.Show();
        }


        private void StartRegistrationProcess()
        {
            bool canAccess = registrationValidator.AreAllInputsValid();
            if (canAccess)
            {
                List<string> allUserData = UserFileUtil.GetAllUserData();
                AddNewUser(allUserData);


                string encryptedData =
                    UserFileUtil.EncryptAllDataInList(allUserData);

                UserFileUtil.WriteEncryptedDataToFile(encryptedData);

                string currentUserData = UserFileUtil
                                           .GetUserData(RUsernameTextBox.Text.Trim(), false);

                UserFileUtil.WriteCurrentUserDataToFile(currentUserData);

                StartSystem();
            }
        }

        private void RegisterUserButton_Click(object sender, EventArgs e)
        {
            StartRegistrationProcess();
        }

        private void StartLoginProcess()
        {
            bool canAccess = loginValidator.AreAllInputsValid();
            if (canAccess)
            {
                string userData =
                            UserFileUtil.GetUserData(userNameTextBox.Text.Trim(), false);

                UserFileUtil.WriteCurrentUserDataToFile(userData);
                StartSystem();
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            StartLoginProcess();
        }

        private void LoginScreen_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RegisterProcessKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                StartRegistrationProcess();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        private void LoginProcessKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartLoginProcess();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }

}
