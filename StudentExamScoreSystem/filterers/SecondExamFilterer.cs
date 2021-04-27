using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class SecondExamFilterer : IFilterer
	{
		private int filterSecondExamScore;
		public SecondExamFilterer(int filterSecondExamScore)
		{
			this.filterSecondExamScore = filterSecondExamScore;
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>();

			foreach (IStudent student in students)
			{
				if (student.GetExamScores().Sdf2 == filterSecondExamScore)
				{
					filteredList.Add(student);
				}
			}

			return filteredList;
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}
			return true;
		}

		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}
	}
}
