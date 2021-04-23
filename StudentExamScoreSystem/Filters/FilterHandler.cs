using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentExamScoreSystem.Filters
{
	public static class FilterHandler
	{
		private static StudentExamScoreSys system;
		public static StudentExamScoreSys System { set => system = value; }

		private static HashSet<IFilterer> filterers = new HashSet<IFilterer>();

		public static void ToggleAllFilters()
		{
			ToggleNameFilter();
			ToggleSurnameFilter();
			ToggleSelectedCourseFilter();
			ToggleFirstExamFilter();
			ToggleSecondExamFilter();
			ToggleThirdExamFilter();
			ToggleFinalExamFilter();
			ToggleAverageScoreFilter();
		}

		public static void ToggleNameFilter()
		{
			if (string.IsNullOrEmpty(system.FindNameTextBox.Text))
			{
				IFilterer searchedNameFilter = HashSetContainsItem(typeof(NameFilterer));

				if (searchedNameFilter != null)
				{
					filterers.Remove(searchedNameFilter);
				}
			}
			else
				filterers.Add(new NameFilterer(system.FindNameTextBox.Text));
		}

		public static void ToggleSurnameFilter()
		{
			if (string.IsNullOrEmpty(system.FindSurnameTextBox.Text))
			{
				IFilterer searchedSurnameFilterer = HashSetContainsItem(typeof(SurnameFilterer));

				if (searchedSurnameFilterer != null)
				{
					filterers.Remove(searchedSurnameFilterer);
				}
			}
			else
				filterers.Add(new SurnameFilterer(system.FindSurnameTextBox.Text));
		}

		public static void ToggleFirstExamFilter()
		{
			if (system.FindFirstExamNumeric.Value == 0)
			{
				IFilterer searchedFirstExamFilterer = HashSetContainsItem(typeof(FirstExamFilterer));

				if (searchedFirstExamFilterer != null)
				{
					filterers.Remove(searchedFirstExamFilterer);
				}
			}
			else
				filterers.Add(new FirstExamFilterer((int)system.FindFirstExamNumeric.Value));
		}

		public static void ToggleSecondExamFilter()
		{
			if (system.FindSecondExamNumeric.Value == 0)
			{
				IFilterer searchedSecondExamFilterer = HashSetContainsItem(typeof(SecondExamFilterer));

				if (searchedSecondExamFilterer != null)
				{
					filterers.Remove(searchedSecondExamFilterer);
				}
			}
			else
				filterers.Add(new SecondExamFilterer((int)system.FindSecondExamNumeric.Value));
		}

		public static void ToggleThirdExamFilter()
		{
			if (system.FindThirdExamNumeric.Value == 0)
			{
				IFilterer searchedThirdExamFilterer = HashSetContainsItem(typeof(ThirdExamFilterer));

				if (searchedThirdExamFilterer != null)
				{
					filterers.Remove(searchedThirdExamFilterer);
				}
			}
			else
				filterers.Add(new ThirdExamFilterer((int)system.FindThirdExamNumeric.Value));
		}

		public static void ToggleFinalExamFilter()
		{
			if (system.FindFinalExamNumeric.Value == 0)
			{
				IFilterer searchedFinalExamFilterer = HashSetContainsItem(typeof(FinalExamFilterer));

				if (searchedFinalExamFilterer != null)
				{
					filterers.Remove(searchedFinalExamFilterer);
				}
			}
			else
				filterers.Add(new FinalExamFilterer((int)system.FindFinalExamNumeric.Value));
		}

		public static void ToggleSelectedCourseFilter()
		{
			if (system.FindCourseComboBox.SelectedItem == null)
			{
				IFilterer searchedSelectedCourseFilter = HashSetContainsItem(typeof(CourseFilterer));

				if (searchedSelectedCourseFilter != null)
				{
					filterers.Remove(searchedSelectedCourseFilter);
				}
			}
			else
				filterers.Add(new CourseFilterer((int)system.FindCourseComboBox.SelectedItem));
		}

		public static void ToggleAverageScoreFilter()
		{
			if (system.FindAverageScoreNumeric.Value == 0)
			{
				IFilterer searchedAverageScoreFilterer = HashSetContainsItem(typeof(AverageScoreFilterer));

				if (searchedAverageScoreFilterer != null)
				{
					filterers.Remove(searchedAverageScoreFilterer);
				}
			}
			else
				filterers.Add(new AverageScoreFilterer((int)system.FindAverageScoreNumeric.Value));
		}

		public static IFilterer HashSetContainsItem(Type filterType)
		{
			if (filterers.Count == 0) return null;

			foreach (IFilterer filterer in filterers)
			{
				if (filterer.GetType() == filterType)
				{
					return filterer;
				}
			}

			return null;
		}

		public static List<IStudent> GetFilteredStudentList()
		{
			List<IStudent> studentListToDisplay;

			if (filterers.Count == 1)
			{
				IFilterer filterer = filterers.ElementAt(0);

				studentListToDisplay = filterer.Filter(system.GetStudentList());
			}
			else
			{
				IFilterer filterer = new AdvancedFilterer(filterers.ToList());
				studentListToDisplay = filterer.Filter(system.GetStudentList());
			}

			return studentListToDisplay;
		}
	}
}
