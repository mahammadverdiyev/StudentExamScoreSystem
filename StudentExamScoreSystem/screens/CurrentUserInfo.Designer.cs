
namespace StudentExamScoreSystem
{
    partial class CurrentUserInfo
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
            this.NameHeaderLabel = new System.Windows.Forms.Label();
            this.SurnameHeaderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserInfoLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.UsernameHeaderLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameHeaderLabel
            // 
            this.NameHeaderLabel.AutoSize = true;
            this.NameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.NameHeaderLabel.Location = new System.Drawing.Point(17, 23);
            this.NameHeaderLabel.Name = "NameHeaderLabel";
            this.NameHeaderLabel.Size = new System.Drawing.Size(70, 15);
            this.NameHeaderLabel.TabIndex = 0;
            this.NameHeaderLabel.Text = "First Name:";
            // 
            // SurnameHeaderLabel
            // 
            this.SurnameHeaderLabel.AutoSize = true;
            this.SurnameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.SurnameHeaderLabel.Location = new System.Drawing.Point(17, 91);
            this.SurnameHeaderLabel.Name = "SurnameHeaderLabel";
            this.SurnameHeaderLabel.Size = new System.Drawing.Size(70, 15);
            this.SurnameHeaderLabel.TabIndex = 1;
            this.SurnameHeaderLabel.Text = "Last Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.UsernameLabel);
            this.panel1.Controls.Add(this.UsernameHeaderLabel);
            this.panel1.Controls.Add(this.SurnameLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Controls.Add(this.NameHeaderLabel);
            this.panel1.Controls.Add(this.SurnameHeaderLabel);
            this.panel1.Location = new System.Drawing.Point(8, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 237);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.UserInfoLabel);
            this.panel2.Location = new System.Drawing.Point(8, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(397, 32);
            this.panel2.TabIndex = 3;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // UserInfoLabel
            // 
            this.UserInfoLabel.AutoSize = true;
            this.UserInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserInfoLabel.ForeColor = System.Drawing.Color.White;
            this.UserInfoLabel.Location = new System.Drawing.Point(16, 6);
            this.UserInfoLabel.Name = "UserInfoLabel";
            this.UserInfoLabel.Size = new System.Drawing.Size(84, 20);
            this.UserInfoLabel.TabIndex = 2;
            this.UserInfoLabel.Text = "User Info";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(17, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 25);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "First Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLabel.ForeColor = System.Drawing.Color.White;
            this.SurnameLabel.Location = new System.Drawing.Point(17, 115);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(115, 25);
            this.SurnameLabel.TabIndex = 4;
            this.SurnameLabel.Text = "Last Name";
            // 
            // UsernameHeaderLabel
            // 
            this.UsernameHeaderLabel.AutoSize = true;
            this.UsernameHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameHeaderLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameHeaderLabel.Location = new System.Drawing.Point(17, 159);
            this.UsernameHeaderLabel.Name = "UsernameHeaderLabel";
            this.UsernameHeaderLabel.Size = new System.Drawing.Size(68, 15);
            this.UsernameHeaderLabel.TabIndex = 5;
            this.UsernameHeaderLabel.Text = "Username:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.White;
            this.UsernameLabel.Location = new System.Drawing.Point(17, 183);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(110, 25);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = global::StudentExamScoreSystem.Properties.Resources.close;
            this.ExitButton.Location = new System.Drawing.Point(350, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(47, 32);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CurrentUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(414, 295);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CurrentUserInfo";
            this.Load += new System.EventHandler(this.CurrentUserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NameHeaderLabel;
        private System.Windows.Forms.Label SurnameHeaderLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label UserInfoLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label UsernameHeaderLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}