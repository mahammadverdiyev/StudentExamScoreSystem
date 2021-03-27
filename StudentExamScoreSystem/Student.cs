using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExamScoreSystem
{
    public abstract class Student
    {
        protected string name, surname;
        protected int course, id;
    }

    public class BEUStudent : Student, BEUStudentInter
    {
        // exam scores
        int sdf1, sdf2, sdf3, attendance, final;
        

        public Dictionary<string,int> GetScores()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            
            scores.Add("sdf1", this.sdf1);
            scores.Add("sdf2", this.sdf2);
            scores.Add("sdf3", this.sdf3);
            scores.Add("final", this.final);
            scores.Add("average", this.calculateAverage());

            return scores;
        }

        public string GetName()
        {
            return base.name;
        }
        public string GetSurname()
        {
            return base.surname;
        }
        public int GetCourse()
        {
            return base.course;
        }
        public int GetId()
        {
            return base.id;
        }

        public BEUStudent(string name, string surname, int course, int id, int sdf1, int sdf2, int sdf3, int final)
        {
            base.name = name;
            base.surname = surname;
            base.course = course;
            base.id = id;
            this.sdf1 = sdf1;
            this.sdf2 = sdf2;
            this.sdf3 = sdf3;
            this.attendance = 100;
            this.final = final;
        }

        public int calculateAverage()
        {
            return (int)Math.Floor((sdf1 + sdf2 + sdf3 + 100 + 100) * 0.1 + final * 0.5);
        }
    }

    interface BEUStudentInter
    {
        int calculateAverage();
    }
}
