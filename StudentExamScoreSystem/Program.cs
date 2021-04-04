using System;
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
        public static List<IStudent> students = new List<IStudent>();


        public static void AddStudents()
        {
            students.Add(new BEUStudent("Mahammad", "Verdiyev", 2, 456465, new ExamScore(53, 87, 69, 74)));
            students.Add(new BEUStudent("Kamil", "Abiyev", 3, 784394, new ExamScore(85, 71, 65, 77)));
            students.Add(new BEUStudent("Elnur", "Veliyev", 1, 279246, new ExamScore(70, 89, 76, 85)));
            students.Add(new BEUStudent("Nihad", "Adigozelov", 4, 975473, new ExamScore(66, 79, 73, 90)));
            students.Add(new BEUStudent("Orxan", "Aslanov", 1, 972948, new ExamScore(63, 46, 70, 88)));

        }
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new StudentExamScoreSystem());
            //Application.Run(new LoginScreen());

            List<string> lines = UserFileUtil.GetAllUserData();
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void ReadWrite(string path)
        {
            string data = File.ReadAllText(path);
            File.WriteAllText($"new-{path}", data);
        }

        public static void DecryptAllDAtaInFile(string path)
        {
            string encryptedData = File.ReadAllText(path);
            string decryptedData = Decryptor.Decrypt(encryptedData, "mahammad");
            File.WriteAllText($"dec-student_data.txt", decryptedData);
        }
        public static void DecryptAllDAtaInFileAndSplit(string path)
        {
            string encryptedData = File.ReadAllText(path);
            Console.WriteLine(encryptedData);
            string decryptedData = Decryptor.Decrypt(encryptedData, "mahammad");
            //Console.WriteLine(decryptedData); 
            List<string> lines = decryptedData.Split(
                                    new[] { Environment.NewLine },
                                    StringSplitOptions.None

).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            //EncryptAllDataInList(path, lines);
        }

        public static void EncryptAllDataInList(string path, List<string> data)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string line in data)
            {
                sb.Append(line);
                sb.Append(Environment.NewLine);
            }
            string encryptedData = Encryptor.Encrypt(sb.ToString(),"mahammad");
            File.WriteAllText(path, encryptedData);
        }

    }
}
