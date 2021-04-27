using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public class AdvancedFilterer : IFilterer
	{
		private List<IFilterer> filterers;
		public AdvancedFilterer(List<IFilterer> filterers)
		{
			this.filterers = filterers;
		}
		public List<IStudent> Filter(List<IStudent> students)
		{
			List<IStudent> filteredList = new List<IStudent>(students);

			foreach (IFilterer filterer in filterers)
			{
				filteredList = filterer.Filter(filteredList);
			}

			return filteredList;
		}
	}
}
