using System;

namespace StudentExamScoreSystem
{
	public class BEUStudent : IStudent
	{
		private string name;
		private string surname;
		private int course;
		private int id;

        public string GetName() => name;
        public string GetSurname() => surname;
		public int GetCourse() => course;
		public int GetId() => id;

		private ExamScore examScore;

		public ExamScore GetExamScores() => examScore;

		public BEUStudent(string name, string surname, int course, int id, ExamScore examScore)
		{
			this.name = name;
			this.surname = surname;
			this.course = course;
			this.id = id;

			this.examScore = examScore;
		}
	}
}
