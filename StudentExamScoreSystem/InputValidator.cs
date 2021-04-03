using System.Linq;

namespace StudentExamScoreSystem
{
	public class InputValidator : IValidator
	{
		StudentExamScoreSys system;

		public InputValidator(StudentExamScoreSys system)
		{
			this.system = system;
		}

		public bool AreAllInputsValid()
		{
			bool isThereAnyInvalidInput = false;

			if (!NameInputIsValid())
				isThereAnyInvalidInput = true;

			if (!SurnameInputIsValid())
				isThereAnyInvalidInput = true;

			if (!IsCourseValid())
				isThereAnyInvalidInput = true;

			if (isThereAnyInvalidInput)
				return false;

			return true;
		}

		public bool NameInputIsValid()
		{
			if (NameIsCorrect())
			{
				system.NameValidatorLabel.Text = "You should enter your name";
				return false;
			}

			system.NameValidatorLabel.Text = "";
			return true;
		}

		private bool NameIsCorrect() => system.NameTextbox.Text.Trim().Length == 0 || system.NameTextbox.Text.Any(char.IsDigit);

		public bool SurnameInputIsValid()
		{
			if (SurnameIsCorrect())
			{
				system.SurnameValidatorLabel.Text = "You should enter your surname";
				return false;
			}

			system.SurnameValidatorLabel.Text = "";
			return true;
		}

		private bool SurnameIsCorrect() => system.SurnameTextbox.Text.Trim().Length == 0 || system.SurnameTextbox.Text.Any(char.IsDigit);

		public bool IsCourseValid()
		{
			if (system.CourseComboBox.SelectedItem == null)
			{
				system.CourseValidaterLabel.Text = "You should enter you course";
				return false;
			}

			system.CourseValidaterLabel.Text = "";
			return true;
		}

	}
}
