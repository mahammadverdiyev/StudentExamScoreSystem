﻿using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class ThirdExamFilterer : IFilterer
	{
		private int filterThirdExamScore;
		public ThirdExamFilterer(int filterThirdExamScore)
		{
			this.filterThirdExamScore = filterThirdExamScore;
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>();

			foreach (IStudent student in students)
			{
				if (student.GetExamScores().Sdf3 == filterThirdExamScore)
				{
					filteredList.Add(student);
				}
			}

			return filteredList;
		}
	}
}
