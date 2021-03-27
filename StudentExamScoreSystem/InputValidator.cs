using System.Linq;

namespace StudentExamScoreSystem
{
	public class InputValidator
	{
		StudentExamScoreSystem system;
		public InputValidator(StudentExamScoreSystem system)
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
			if (NameIsValid())
			{
				system.NameValidateLabel.Text = "You should enter your name";
				return false;
			}

			return true;
		}

		private bool NameIsValid() => system.NameTextbox.Text.Trim().Length == 0 || system.NameTextbox.Text.Any(char.IsDigit);

		public bool SurnameInputIsValid()
		{
			if (SurnameIsValid())
			{
				system.SurnameValidateLabel.Text = "You should enter your surname";
				return false;
			}

			return true;
		}

		private bool SurnameIsValid() => system.SurnameTextbox.Text.Trim().Length == 0 || system.SurnameTextbox.Text.Any(char.IsDigit);

		public bool IsCourseValid()
		{
			if (system.CourseComboBox.SelectedItem != null)
			{
				return true;
			}

			return false;
		}

	}
}
