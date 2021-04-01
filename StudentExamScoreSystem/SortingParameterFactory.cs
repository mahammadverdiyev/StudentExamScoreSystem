using System;

namespace StudentExamScoreSystem
{
	public static class SortingParameterFactory
	{
		public enum SortingType
		{
			COURSE,
			SDF1,
			SDF2,
			SDF3,
			FINAL,
			AVERAGE,
			TIMECREATED,
		}
		public static Func<IStudent, int> GetSortParameter(SortingType sortingType)
		{
			Func<IStudent, int> sortParameter = default;

			switch (sortingType)
			{
				case SortingType.COURSE:
					sortParameter = std => std.GetCourse();
					break;
				case SortingType.SDF1:
					sortParameter = std => std.GetExamScores().Sdf1;
					break;
				case SortingType.SDF2:
					sortParameter = std => std.GetExamScores().Sdf2;
					break;
				case SortingType.SDF3:
					sortParameter = std => std.GetExamScores().Sdf3;
					break;
				case SortingType.FINAL:
					sortParameter = std => std.GetExamScores().Final;
					break;
				case SortingType.AVERAGE:
					sortParameter = std => std.GetExamScores().CalculateAverage();
					break;
				case SortingType.TIMECREATED:
					break;
			}

			return sortParameter;
		}
	}
}
