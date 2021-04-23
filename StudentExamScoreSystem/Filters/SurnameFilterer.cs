using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class SurnameFilterer : IFilterer
	{
		private string filterSurname;

		public SurnameFilterer(string filterSurname)
		{
			this.filterSurname = filterSurname.Trim();
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>();

			foreach (IStudent student in students)
			{
				if (student.GetSurname() == filterSurname)
				{
					filteredList.Add(student);
				}
			}

			return filteredList;
		}
	}
}
