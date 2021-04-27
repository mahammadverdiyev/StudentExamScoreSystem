using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class FirstExamFilterer : IFilterer
	{
		private int filterFirstExamScore;
		public FirstExamFilterer(int filterFirstExamScore)
		{
			this.filterFirstExamScore = filterFirstExamScore;
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>();

			foreach (IStudent student in students)
			{
				if (student.GetExamScores().Sdf1 == filterFirstExamScore)
				{
					filteredList.Add(student);
				}
			}

			return filteredList;
		}
	}
}
