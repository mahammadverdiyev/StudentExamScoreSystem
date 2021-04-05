﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExamScoreSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StudentExamScoreSys());
            //Application.Run(new CurrentUserInfo());
            //Application.Run(new StudentExamScoreSys());
            Application.Run(new LoginScreen());
            //PrintAllUserData();

        }

        // written for testing purpose
        public static void PrintAllUserData()
        {
            List<string> lines = UserFileUtil.GetAllUserData();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

    }
}
