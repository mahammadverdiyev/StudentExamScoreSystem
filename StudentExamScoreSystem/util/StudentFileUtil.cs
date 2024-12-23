﻿using System.Collections.Generic;
using System.IO;

namespace StudentExamScoreSystem
{
    class StudentFileUtil
    {
        // don't modify
        private static readonly string STUDENT_DATA_PATH = "student_data.txt";

        public static void ReadStudentDataFromFile(List<IStudent> listStudent)
        {
            using (StreamReader reader = new StreamReader(STUDENT_DATA_PATH))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(' ');
                    string name = data[0];
                    string surname = data[1];
                    int course = int.Parse(data[2]);
                    int id = int.Parse(data[3]);
                    int sdf1 = int.Parse(data[4]);
                    int sdf2 = int.Parse(data[5]);
                    int sdf3 = int.Parse(data[6]);
                    int final = int.Parse(data[7]);
                    ExamScore scores = new ExamScore(sdf1, sdf2, sdf3, final);
                    listStudent.Add(new BEUStudent(name, surname, course, id, scores));
                }
            }
        }
        public static void WriteStudentDataToFile(string path,List<IStudent> listStudent)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach(IStudent student in listStudent)
                {
                    string name = student.GetName();
                    string surname = student.GetSurname();
                    int course = student.GetCourse();
                    int id = student.GetId();
                    int sdf1 = student.GetExamScores().Sdf1;
                    int sdf2 = student.GetExamScores().Sdf2;
                    int sdf3 = student.GetExamScores().Sdf3;
                    int final = student.GetExamScores().Final;
                    writer.WriteLine($"{name} {surname} {course} {id} {sdf1} {sdf2} {sdf3} {final}");
                }
            }
        }
        public static void WriteStudentDataToDefaultFile(List<IStudent> listStudent)
        {
            WriteStudentDataToFile(STUDENT_DATA_PATH, listStudent);
        }
    }
}
