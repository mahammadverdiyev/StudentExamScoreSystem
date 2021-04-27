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
				if (student.GetSurname().ToLower().StartsWith(filterSurname.ToLower()))
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
