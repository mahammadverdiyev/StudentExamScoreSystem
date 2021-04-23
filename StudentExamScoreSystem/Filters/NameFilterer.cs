using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class NameFilterer : IFilterer
	{
		private string filterName;
		public NameFilterer(string filterName)
		{
			this.filterName = filterName;
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>();

			foreach (IStudent student in students)
			{
				if (student.GetName() == filterName)
				{
					filteredList.Add(student);
				}
			}

			return filteredList;
		}
	}
}
