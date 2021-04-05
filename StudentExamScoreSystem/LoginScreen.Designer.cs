using StudentExamScoreSystem;

namespace StudentExamScoreSystem
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.passwordValidatorLabel = new System.Windows.Forms.Label();
            this.usernameValidatorLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginHeaderLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPasswordValidatorLabel = new System.Windows.Forms.Label();
            this.registerUserNameValidatorLabel = new System.Windows.Forms.Label();
            this.surnameValidatorLabel = new System.Windows.Forms.Label();
            this.nameValidatorLabel = new System.Windows.Forms.Label();
            this.RegisterUserButton = new System.Windows.Forms.Button();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationLabelHeader = new System.Windows.Forms.Label();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerUserNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTab = new System.Windows.Forms.Button();
            this.RegisterTab = new System.Windows.Forms.Button();
            this.Slider = new System.Windows.Forms.Panel();
            this.timer_slider = new System.Windows.Forms.Timer(this.components);
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            this.RegistrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.LoginPanel.Controls.Add(this.label6);
            this.LoginPanel.Controls.Add(this.label5);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.passwordValidatorLabel);
            this.LoginPanel.Controls.Add(this.usernameValidatorLabel);
            this.LoginPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginPanel.Controls.Add(this.LoginHeaderLabel);
            this.LoginPanel.Controls.Add(this.passwordTextBox);
            this.LoginPanel.Controls.Add(this.userNameTextBox);
            this.LoginPanel.Location = new System.Drawing.Point(7, 100);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(471, 412);
            this.LoginPanel.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(97, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Username";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(170, 376);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(104, 31);
            this.LoginButton.TabIndex = 17;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // passwordValidatorLabel
            // 
            this.passwordValidatorLabel.AutoSize = true;
            this.passwordValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordValidatorLabel.Location = new System.Drawing.Point(97, 191);
            this.passwordValidatorLabel.Name = "passwordValidatorLabel";
            this.passwordValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.passwordValidatorLabel.TabIndex = 16;
            this.passwordValidatorLabel.Text = "label1";
            // 
            // usernameValidatorLabel
            // 
            this.usernameValidatorLabel.AutoSize = true;
            this.usernameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.usernameValidatorLabel.Location = new System.Drawing.Point(97, 126);
            this.usernameValidatorLabel.Name = "usernameValidatorLabel";
            this.usernameValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.usernameValidatorLabel.TabIndex = 15;
            this.usernameValidatorLabel.Text = "label1";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(100, 207);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(122, 20);
            this.ShowPasswordCheckBox.TabIndex = 9;
            this.ShowPasswordCheckBox.Text = "Show password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // LoginHeaderLabel
            // 
            this.LoginHeaderLabel.AutoSize = true;
            this.LoginHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.LoginHeaderLabel.Location = new System.Drawing.Point(95, 33);
            this.LoginHeaderLabel.Name = "LoginHeaderLabel";
            this.LoginHeaderLabel.Size = new System.Drawing.Size(73, 29);
            this.LoginHeaderLabel.TabIndex = 8;
            this.LoginHeaderLabel.Text = "Login";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(100, 166);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(221, 26);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginProcessKeyDown);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.White;
            this.userNameTextBox.Location = new System.Drawing.Point(100, 97);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(221, 26);
            this.userNameTextBox.TabIndex = 4;
            this.userNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginProcessKeyDown);
            // 
            // RegistrationPanel
            // 
            this.RegistrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.RegistrationPanel.Controls.Add(this.label4);
            this.RegistrationPanel.Controls.Add(this.label3);
            this.RegistrationPanel.Controls.Add(this.label2);
            this.RegistrationPanel.Controls.Add(this.label1);
            this.RegistrationPanel.Controls.Add(this.registerPasswordValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.registerUserNameValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.surnameValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.nameValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.RegisterUserButton);
            this.RegistrationPanel.Controls.Add(this.SurnameTextBox);
            this.RegistrationPanel.Controls.Add(this.NameTextBox);
            this.RegistrationPanel.Controls.Add(this.RegistrationLabelHeader);
            this.RegistrationPanel.Controls.Add(this.confirmTextBox);
            this.RegistrationPanel.Controls.Add(this.registerPasswordTextBox);
            this.RegistrationPanel.Controls.Add(this.registerUserNameTextBox);
            this.RegistrationPanel.Location = new System.Drawing.Point(7, 100);
            this.RegistrationPanel.Name = "RegistrationPanel";
            this.RegistrationPanel.Size = new System.Drawing.Size(471, 412);
            this.RegistrationPanel.TabIndex = 1;
            this.RegistrationPanel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(97, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(97, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "First Name";
            // 
            // registerPasswordValidatorLabel
            // 
            this.registerPasswordValidatorLabel.AutoSize = true;
            this.registerPasswordValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.registerPasswordValidatorLabel.Location = new System.Drawing.Point(97, 363);
            this.registerPasswordValidatorLabel.Name = "registerPasswordValidatorLabel";
            this.registerPasswordValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.registerPasswordValidatorLabel.TabIndex = 17;
            this.registerPasswordValidatorLabel.Text = "label2";
            // 
            // registerUserNameValidatorLabel
            // 
            this.registerUserNameValidatorLabel.AutoSize = true;
            this.registerUserNameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.registerUserNameValidatorLabel.Location = new System.Drawing.Point(97, 266);
            this.registerUserNameValidatorLabel.Name = "registerUserNameValidatorLabel";
            this.registerUserNameValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.registerUserNameValidatorLabel.TabIndex = 16;
            this.registerUserNameValidatorLabel.Text = "label2";
            // 
            // surnameValidatorLabel
            // 
            this.surnameValidatorLabel.AutoSize = true;
            this.surnameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.surnameValidatorLabel.Location = new System.Drawing.Point(97, 197);
            this.surnameValidatorLabel.Name = "surnameValidatorLabel";
            this.surnameValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.surnameValidatorLabel.TabIndex = 15;
            this.surnameValidatorLabel.Text = "label2";
            // 
            // nameValidatorLabel
            // 
            this.nameValidatorLabel.AutoSize = true;
            this.nameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameValidatorLabel.Location = new System.Drawing.Point(97, 126);
            this.nameValidatorLabel.Name = "nameValidatorLabel";
            this.nameValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.nameValidatorLabel.TabIndex = 14;
            this.nameValidatorLabel.Text = "label1";
            // 
            // RegisterUserButton
            // 
            this.RegisterUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.RegisterUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.RegisterUserButton.FlatAppearance.BorderSize = 0;
            this.RegisterUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUserButton.ForeColor = System.Drawing.Color.White;
            this.RegisterUserButton.Location = new System.Drawing.Point(170, 376);
            this.RegisterUserButton.Name = "RegisterUserButton";
            this.RegisterUserButton.Size = new System.Drawing.Size(104, 31);
            this.RegisterUserButton.TabIndex = 15;
            this.RegisterUserButton.Text = "Register";
            this.RegisterUserButton.UseVisualStyleBackColor = false;
            this.RegisterUserButton.Click += new System.EventHandler(this.RegisterUserButton_Click);
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.ForeColor = System.Drawing.Color.White;
            this.SurnameTextBox.Location = new System.Drawing.Point(100, 168);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(251, 26);
            this.SurnameTextBox.TabIndex = 11;
            this.SurnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterProcessKeyDown);
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.ForeColor = System.Drawing.Color.White;
            this.NameTextBox.Location = new System.Drawing.Point(100, 97);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(251, 26);
            this.NameTextBox.TabIndex = 10;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterProcessKeyDown);
            // 
            // RegistrationLabelHeader
            // 
            this.RegistrationLabelHeader.AutoSize = true;
            this.RegistrationLabelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationLabelHeader.ForeColor = System.Drawing.Color.White;
            this.RegistrationLabelHeader.Location = new System.Drawing.Point(95, 33);
            this.RegistrationLabelHeader.Name = "RegistrationLabelHeader";
            this.RegistrationLabelHeader.Size = new System.Drawing.Size(142, 29);
            this.RegistrationLabelHeader.TabIndex = 9;
            this.RegistrationLabelHeader.Text = "Registration";
            // 
            // confirmTextBox
            // 
            this.confirmTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.confirmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmTextBox.ForeColor = System.Drawing.Color.White;
            this.confirmTextBox.Location = new System.Drawing.Point(100, 334);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.PasswordChar = '•';
            this.confirmTextBox.Size = new System.Drawing.Size(251, 26);
            this.confirmTextBox.TabIndex = 14;
            this.confirmTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterProcessKeyDown);
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.registerPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.registerPasswordTextBox.Location = new System.Drawing.Point(100, 302);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.PasswordChar = '•';
            this.registerPasswordTextBox.Size = new System.Drawing.Size(251, 26);
            this.registerPasswordTextBox.TabIndex = 13;
            this.registerPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterProcessKeyDown);
            // 
            // registerUserNameTextBox
            // 
            this.registerUserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.registerUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserNameTextBox.ForeColor = System.Drawing.Color.White;
            this.registerUserNameTextBox.Location = new System.Drawing.Point(100, 237);
            this.registerUserNameTextBox.Name = "registerUserNameTextBox";
            this.registerUserNameTextBox.Size = new System.Drawing.Size(251, 26);
            this.registerUserNameTextBox.TabIndex = 12;
            this.registerUserNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterProcessKeyDown);
            // 
            // LoginTab
            // 
            this.LoginTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(117)))), ((int)(((byte)(173)))));
            this.LoginTab.FlatAppearance.BorderSize = 0;
            this.LoginTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginTab.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTab.ForeColor = System.Drawing.Color.White;
            this.LoginTab.Location = new System.Drawing.Point(7, 47);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(235, 47);
            this.LoginTab.TabIndex = 8;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = false;
            this.LoginTab.Click += new System.EventHandler(this.LoginTab_Click);
            // 
            // RegisterTab
            // 
            this.RegisterTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(102)))), ((int)(((byte)(128)))));
            this.RegisterTab.FlatAppearance.BorderSize = 0;
            this.RegisterTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterTab.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterTab.ForeColor = System.Drawing.Color.White;
            this.RegisterTab.Location = new System.Drawing.Point(243, 47);
            this.RegisterTab.Name = "RegisterTab";
            this.RegisterTab.Size = new System.Drawing.Size(235, 47);
            this.RegisterTab.TabIndex = 9;
            this.RegisterTab.Text = "Register";
            this.RegisterTab.UseVisualStyleBackColor = false;
            this.RegisterTab.Click += new System.EventHandler(this.RegisterTab_Click);
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(161)))), ((int)(((byte)(237)))));
            this.Slider.Location = new System.Drawing.Point(7, 95);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(235, 4);
            this.Slider.TabIndex = 12;
            // 
            // timer_slider
            // 
            this.timer_slider.Interval = 5;
            this.timer_slider.Tick += new System.EventHandler(this.timer_slider_Tick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = global::StudentExamScoreSystem.Properties.Resources.close;
            this.ExitButton.Location = new System.Drawing.Point(417, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(61, 38);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(488, 519);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.RegisterTab);
            this.Controls.Add(this.LoginTab);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.RegistrationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginScreen_MouseDown);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.RegistrationPanel.ResumeLayout(false);
            this.RegistrationPanel.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel RegistrationPanel;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.TextBox registerUserNameTextBox;
        private System.Windows.Forms.Button LoginTab;
        private System.Windows.Forms.Button RegisterTab;
        private System.Windows.Forms.TextBox confirmTextBox;
        private System.Windows.Forms.Label LoginHeaderLabel;
        private System.Windows.Forms.Label RegistrationLabelHeader;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Panel Slider;
        private System.Windows.Forms.Button RegisterUserButton;
        private System.Windows.Forms.Timer timer_slider;
        private System.Windows.Forms.Label surnameValidatorLabel;
        private System.Windows.Forms.Label nameValidatorLabel;
        private System.Windows.Forms.Label registerUserNameValidatorLabel;
        private System.Windows.Forms.Label registerPasswordValidatorLabel;
        private System.Windows.Forms.Label passwordValidatorLabel;
        private System.Windows.Forms.Label usernameValidatorLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}