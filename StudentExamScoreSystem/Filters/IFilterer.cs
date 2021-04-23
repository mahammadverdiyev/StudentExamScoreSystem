using System.Collections.Generic;

namespace StudentExamScoreSystem.Filters
{
	public interface IFilterer
	{
		List<IStudent> Filter(List<IStudent> students);
	}
}
