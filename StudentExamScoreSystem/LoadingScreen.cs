using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudentExamScoreSystem
{
    public partial class LoadingScreen : Form
    {

        private int picSpeed = 1;
        private int picSpeedChanger = 1;
        private int pictureIndex = 1;


        private int slideSpeed = 10;

        private Bitmap[] pictures = new Bitmap[]
        {
            Properties.Resources.beu,
            Properties.Resources.stargazersmedium,
            Properties.Resources.stargazersfacebook,
            Properties.Resources.github,
            Properties.Resources.workpic,
        };

        public LoadingScreen()
        {
            InitializeComponent();
        }

        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            slideAnimationTimer.Start();
            pictureAnimationInvoker.Start();
        }

        private void pictureAnimationTimer_Tick(object sender, EventArgs e)
        {
            int currX = MyPicture.Location.X;
            int currY = MyPicture.Location.Y;

            MyPicture.Left += picSpeed;
            picSpeed += picSpeedChanger;

            if(currX  > (this.Size.Width - 1))
            {
                MyPicture.Image = pictures[pictureIndex];
                
                pictureIndex = pictureIndex == (pictures.Length - 1) ? 0 
                    :  pictureIndex + 1;

                MyPicture.Location = new Point(-850,currY);
                picSpeedChanger = -1;
            }
            if(currX < 0 && currX > -10)
            {
                picSpeed = 1;
                picSpeedChanger = 1;
                MyPicture.Location = new Point(1, 1);
                nextButton.Visible = true;
                pictureAnimationTimer.Stop();
            }
        }

        private void pictureAnimationInvoker_Tick(object sender, EventArgs e)
        {
            if(!pictureAnimationTimer.Enabled)
               pictureAnimationTimer.Start();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (!pictureAnimationTimer.Enabled)
                pictureAnimationTimer.Start();

                pictureAnimationInvoker.Stop();
                pictureAnimationInvoker.Start();
        }

        private void slideAnimationTimer_Tick(object sender, EventArgs e)
        {
            int currX = SlidePanel.Location.X;
            int currY = SlidePanel.Location.Y;
            int width = SlidePanel.Size.Width;

            SlidePanel.Left += slideSpeed;
            
            if(currX > ProgressBar.Size.Width)
            {
                SlidePanel.Location = new Point(-width, currY);
            }
        }
    }
}
