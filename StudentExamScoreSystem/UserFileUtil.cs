using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StudentExamScoreSystem
{
    class UserFileUtil
    {
        private static readonly string PASSWORD = "Star Gazers";
        private static readonly string USER_DATA_PATH = "user_data.txt";
        public static readonly string CURRENT_USER_DATA_PATH = "current_user_data.txt";

        public static List<string> GetAllUserData()
        {
            if (!File.Exists(USER_DATA_PATH))
            {
                // soon we'll read data from file, so
                // in order to get rid of
                // "being used another process" exception
                // we have to close FileStream object
                using (var fileStream = File.Create(USER_DATA_PATH))
                {

                }
                
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

        public static string EncryptAllDataInList(List<string> data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string line in data)
            {
                sb.Append(line);
                sb.Append(Environment.NewLine);
            }
            string encryptedData = Encryptor.Encrypt(sb.ToString(), PASSWORD);

            return encryptedData;
        }

        public static void WriteEncryptedDataToFile(string encryptedData)
        {
            File.WriteAllText(USER_DATA_PATH, encryptedData);
        }

        public static bool UsernameExists(string username)
        {
            List<string> allUserData = GetAllUserData();
            return UsernameExists(allUserData, username);
        }

        private static bool UsernameExists(List<string> lines, string username)
        {

            foreach (string line in lines)
            {
                string[] splitted = line.Split(' ');
                if (splitted[0].Equals(username))
                    return true;
            }
            return false;
        }

        public static bool UsernamePasswordMatches(string username,string password)
        {
            List<string> lines = GetAllUserData();
            foreach (string line in lines)
            {
                string[] splitted = line.Split(' ');
                string uName = splitted[0];
                
                if (uName.Equals(username))
                {
                    string passwordInFile = splitted[3];
                    if (passwordInFile.Equals(password))
                        return true;
                }
            }
            return false;
        }

        public static string GetUserData(string username,bool includePassword)
        {
            List<string> lines = GetAllUserData();
            foreach (string line in lines)
            {
                string[] splitted = line.Split(' ');
                string uName = splitted[0];

                if (uName.Equals(username))
                {
                    if (includePassword)
                        return line;
                    else
                        return $"{splitted[0]} {splitted[1]} {splitted[2]}";
                }
            }
            return null;
        }

        public static void WriteCurrentUserDataToFile(string userData)
        {
            File.WriteAllText(CURRENT_USER_DATA_PATH, userData);
        }
        
        public static void ClearCurrentUserData()
        {
            File.WriteAllText(CURRENT_USER_DATA_PATH, String.Empty);
        }
    }
}
