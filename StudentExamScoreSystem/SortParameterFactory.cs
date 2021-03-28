using System;

namespace StudentExamScoreSystem
{
	public static class SortParameterFactory
	{
		public static Func<BEUStudent, int> GetSortParameter(string sortType)
		{
			Func<BEUStudent, int> sortParameter = default;

			switch (sortType)
			{
				case "COURSE":
					sortParameter = std => std.Course;
					break;
				case "SDF1":
					sortParameter = std => std.ExamScore.Sdf1;
					break;
				case "SDF2":
					sortParameter = std => std.ExamScore.Sdf2;
					break;
				case "SDF3":
					sortParameter = std => std.ExamScore.Sdf3;
					break;
				case "FINAL":
					sortParameter = std => std.ExamScore.Final;
					break;
				case "AVERAGE":
					sortParameter = std => std.ExamScore.CalculateAverage();
					break;
				case "TIME CREATED":
					break;
			}

			return sortParameter;
		}
	}
}
