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
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginHeaderLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationPanel = new System.Windows.Forms.Panel();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.RegistrationLabelHeader = new System.Windows.Forms.Label();
            this.confirmTextBox = new System.Windows.Forms.TextBox();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.registerUserNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginTab = new System.Windows.Forms.Button();
            this.RegisterTab = new System.Windows.Forms.Button();
            this.Slider = new System.Windows.Forms.Panel();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer_slider = new System.Windows.Forms.Timer(this.components);
            this.nameValidatorLabel = new System.Windows.Forms.Label();
            this.surnameValidatorLabel = new System.Windows.Forms.Label();
            this.registerUserNameValidatorLabel = new System.Windows.Forms.Label();
            this.registerPasswordValidatorLabel = new System.Windows.Forms.Label();
            this.LoginPanel.SuspendLayout();
            this.RegistrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.LoginPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginPanel.Controls.Add(this.LoginHeaderLabel);
            this.LoginPanel.Controls.Add(this.passwordTextBox);
            this.LoginPanel.Controls.Add(this.userNameTextBox);
            this.LoginPanel.Location = new System.Drawing.Point(7, 100);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(471, 412);
            this.LoginPanel.TabIndex = 0;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(100, 184);
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
            this.passwordTextBox.Location = new System.Drawing.Point(100, 143);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(221, 26);
            this.passwordTextBox.TabIndex = 6;
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
            // 
            // RegistrationPanel
            // 
            this.RegistrationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.RegistrationPanel.Controls.Add(this.registerPasswordValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.registerUserNameValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.surnameValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.nameValidatorLabel);
            this.RegistrationPanel.Controls.Add(this.AddStudentButton);
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
            // SurnameTextBox
            // 
            this.SurnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SurnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SurnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameTextBox.ForeColor = System.Drawing.Color.White;
            this.SurnameTextBox.Location = new System.Drawing.Point(100, 143);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(251, 26);
            this.SurnameTextBox.TabIndex = 11;
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
            this.confirmTextBox.Location = new System.Drawing.Point(100, 313);
            this.confirmTextBox.Name = "confirmTextBox";
            this.confirmTextBox.Size = new System.Drawing.Size(251, 26);
            this.confirmTextBox.TabIndex = 8;
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.registerPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.registerPasswordTextBox.Location = new System.Drawing.Point(100, 278);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(251, 26);
            this.registerPasswordTextBox.TabIndex = 6;
            // 
            // registerUserNameTextBox
            // 
            this.registerUserNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.registerUserNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.registerUserNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserNameTextBox.ForeColor = System.Drawing.Color.White;
            this.registerUserNameTextBox.Location = new System.Drawing.Point(100, 213);
            this.registerUserNameTextBox.Name = "registerUserNameTextBox";
            this.registerUserNameTextBox.Size = new System.Drawing.Size(251, 26);
            this.registerUserNameTextBox.TabIndex = 4;
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
            // AddStudentButton
            // 
            this.AddStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(110)))), ((int)(((byte)(153)))));
            this.AddStudentButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AddStudentButton.FlatAppearance.BorderSize = 0;
            this.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentButton.ForeColor = System.Drawing.Color.White;
            this.AddStudentButton.Location = new System.Drawing.Point(170, 376);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(104, 31);
            this.AddStudentButton.TabIndex = 13;
            this.AddStudentButton.Text = "Add";
            this.AddStudentButton.UseVisualStyleBackColor = false;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
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
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // timer_slider
            // 
            this.timer_slider.Interval = 5;
            this.timer_slider.Tick += new System.EventHandler(this.timer_slider_Tick);
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
            // surnameValidatorLabel
            // 
            this.surnameValidatorLabel.AutoSize = true;
            this.surnameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.surnameValidatorLabel.Location = new System.Drawing.Point(97, 168);
            this.surnameValidatorLabel.Name = "surnameValidatorLabel";
            this.surnameValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.surnameValidatorLabel.TabIndex = 15;
            this.surnameValidatorLabel.Text = "label2";
            // 
            // registerUserNameValidatorLabel
            // 
            this.registerUserNameValidatorLabel.AutoSize = true;
            this.registerUserNameValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.registerUserNameValidatorLabel.Location = new System.Drawing.Point(97, 242);
            this.registerUserNameValidatorLabel.Name = "registerUserNameValidatorLabel";
            this.registerUserNameValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.registerUserNameValidatorLabel.TabIndex = 16;
            this.registerUserNameValidatorLabel.Text = "label2";
            // 
            // registerPasswordValidatorLabel
            // 
            this.registerPasswordValidatorLabel.AutoSize = true;
            this.registerPasswordValidatorLabel.ForeColor = System.Drawing.Color.Red;
            this.registerPasswordValidatorLabel.Location = new System.Drawing.Point(97, 342);
            this.registerPasswordValidatorLabel.Name = "registerPasswordValidatorLabel";
            this.registerPasswordValidatorLabel.Size = new System.Drawing.Size(35, 13);
            this.registerPasswordValidatorLabel.TabIndex = 17;
            this.registerPasswordValidatorLabel.Text = "label2";
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(488, 519);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.RegisterTab);
            this.Controls.Add(this.LoginTab);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RegistrationPanel);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
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
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer_slider;
        private System.Windows.Forms.Label surnameValidatorLabel;
        private System.Windows.Forms.Label nameValidatorLabel;
        private System.Windows.Forms.Label registerUserNameValidatorLabel;
        private System.Windows.Forms.Label registerPasswordValidatorLabel;
    }
}