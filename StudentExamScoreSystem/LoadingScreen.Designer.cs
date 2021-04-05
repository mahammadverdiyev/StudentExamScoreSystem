
namespace StudentExamScoreSystem
{
    partial class LoadingScreen
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
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.ProgressBar = new System.Windows.Forms.Panel();
            this.pictureAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureAnimationInvoker = new System.Windows.Forms.Timer(this.components);
            this.slideAnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.nextButton = new System.Windows.Forms.Button();
            this.MyPicture = new System.Windows.Forms.PictureBox();
            this.screenCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.ProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SlidePanel
            // 
            this.SlidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(129)))), ((int)(((byte)(156)))));
            this.SlidePanel.Location = new System.Drawing.Point(0, 0);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(188, 13);
            this.SlidePanel.TabIndex = 1;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ProgressBar.Controls.Add(this.SlidePanel);
            this.ProgressBar.Location = new System.Drawing.Point(157, 503);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(585, 13);
            this.ProgressBar.TabIndex = 2;
            // 
            // pictureAnimationTimer
            // 
            this.pictureAnimationTimer.Interval = 10;
            this.pictureAnimationTimer.Tick += new System.EventHandler(this.pictureAnimationTimer_Tick);
            // 
            // pictureAnimationInvoker
            // 
            this.pictureAnimationInvoker.Interval = 3000;
            this.pictureAnimationInvoker.Tick += new System.EventHandler(this.pictureAnimationInvoker_Tick);
            // 
            // slideAnimationTimer
            // 
            this.slideAnimationTimer.Interval = 20;
            this.slideAnimationTimer.Tick += new System.EventHandler(this.slideAnimationTimer_Tick);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Image = global::StudentExamScoreSystem.Properties.Resources.nextBtn;
            this.nextButton.Location = new System.Drawing.Point(773, 448);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(77, 46);
            this.nextButton.TabIndex = 6;
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // MyPicture
            // 
            this.MyPicture.Image = global::StudentExamScoreSystem.Properties.Resources.beu;
            this.MyPicture.Location = new System.Drawing.Point(1, 1);
            this.MyPicture.Name = "MyPicture";
            this.MyPicture.Size = new System.Drawing.Size(849, 441);
            this.MyPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MyPicture.TabIndex = 3;
            this.MyPicture.TabStop = false;
            // 
            // screenCloseTimer
            // 
            this.screenCloseTimer.Interval = 12000;
            this.screenCloseTimer.Tick += new System.EventHandler(this.screenCloseTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(851, 528);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.MyPicture);
            this.Controls.Add(this.ProgressBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingScreen";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Panel ProgressBar;
        private System.Windows.Forms.PictureBox MyPicture;
        private System.Windows.Forms.Timer pictureAnimationTimer;
        private System.Windows.Forms.Timer pictureAnimationInvoker;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Timer slideAnimationTimer;
        private System.Windows.Forms.Timer screenCloseTimer;
    }
}