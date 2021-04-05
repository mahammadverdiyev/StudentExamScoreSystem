using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace StudentExamScoreSystem
{
    public partial class CurrentUserInfo : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public CurrentUserInfo()
        {
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReadCurrentUserData()
        {
            string userData = File.ReadAllText(UserFileUtil.CURRENT_USER_DATA_PATH);
            string[] splittedData = userData.Split(' ');
            UsernameLabel.Text = splittedData[0];
            NameLabel.Text = splittedData[1];
            SurnameLabel.Text = splittedData[2];
        }

        private void CurrentUserInfo_Load(object sender, EventArgs e)
        {
            ReadCurrentUserData();
        }
    }
}
