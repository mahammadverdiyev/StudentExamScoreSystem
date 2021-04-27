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
				if (student.GetName().ToLower().StartsWith(filterName.ToLower()))
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
