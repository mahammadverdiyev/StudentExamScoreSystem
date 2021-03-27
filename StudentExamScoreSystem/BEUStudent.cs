using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExamScoreSystem
{
	public class BEUStudent
	{
		private string name;
		private string surname;
		private int course;
		private int id;
		public string Name { get => name; set => name = value; }
		public string Surname { get => surname; set => surname = value; }
		public int Course { get => course; set => course = value; }
		public int Id { get => id; set => id = value; }

		private ExamScore examScore;

		public ExamScore ExamScore { get => examScore; }

		public BEUStudent(string name, string surname, int course, int id, ExamScore examScore)
		{
			this.name = name;
			this.surname = surname;
			this.course = course;
			this.id = id;

			this.examScore = examScore;
		}

		public Dictionary<string, int> GetScores()
		{
			Dictionary<string, int> scores = new Dictionary<string, int>();

			scores.Add("sdf1", examScore.Sdf1);
			scores.Add("sdf2", examScore.Sdf2);
			scores.Add("sdf3", examScore.Sdf3);
			scores.Add("final", examScore.Final);
			scores.Add("average", examScore.CalculateAverage());

			return scores;
		}
	}
}
