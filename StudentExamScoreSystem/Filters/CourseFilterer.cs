using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class CourseFilterer : IFilterer
	{
		private int filterCourse;

		public CourseFilterer(int filterCourse)
		{
			this.filterCourse = filterCourse;
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>();

			foreach (IStudent student in students)
			{
				if (student.GetCourse() == filterCourse)
				{
					filteredList.Add(student);
				}
			}

			return filteredList;
		}
	}
}
