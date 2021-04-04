using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentExamScoreSystem
{
    class UserFileUtil
    {
        private static readonly string PASSWORD = "mahammad";

        private static readonly string USER_DATA_PATH = "user_data.txt";

        public static List<string> GetAllUserData()
        {
            if (!File.Exists(USER_DATA_PATH))
            {
                File.Create(USER_DATA_PATH);
                return new List<string>(); 
            }
            if(new FileInfo(USER_DATA_PATH).Length == 0)
            {
                return new List<string>();
            }

            string encryptedData = ReadDataFromFile(USER_DATA_PATH);

            string decryptedData = DecryptData(encryptedData, PASSWORD);

            List<string> lines = SplitDataIntoLines(decryptedData);
            return lines;
        }


        // written for testing
        private static void PrintDataInList(List<string> lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        private static List<string> SplitDataIntoLines(string data)
        {
            return data.Split( new[] { Environment.NewLine }, StringSplitOptions.None).ToList();

        }
        private static string DecryptData(string encryptedData, string password)
        {
            return Decryptor.Decrypt(encryptedData, password);
        }
        private static string ReadDataFromFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static void EncryptAllDataInList()
        {
            EncryptAllDataInList(GetAllUserData());
        }

        public static void EncryptAllDataInList(List<string> data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in data)
            {
                sb.Append(line);
                sb.Append(Environment.NewLine);
            }
            string encryptedData = Encryptor.Encrypt(sb.ToString(), PASSWORD);
            File.WriteAllText(USER_DATA_PATH, encryptedData);
        }
    }
}
