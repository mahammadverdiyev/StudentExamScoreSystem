using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using StudentExamScoreSystem.Filters;

namespace StudentExamScoreSystem
{
	public partial class StudentExamScoreSys : Form
	{
		private List<IStudent> students;
		private CurrentUserInfo currentUserInfo;
		private InputValidator inputValidator;
		public Label NameValidatorLabel => nameValidatorLabel;
		public Label SurnameValidatorLabel => surnameValidatorLabel;
		public Label CourseValidaterLabel => courseValidatorLabel;
		public TextBox NameTextbox => nameTextBox;
		public TextBox SurnameTextbox => surnameTextBox;
		public ComboBox CourseComboBox => courseComboBox;

		private HashSet<IFilterer> filterers;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
						 int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public StudentExamScoreSys()
        {
            InitializeComponent();
        }

		private void StudentExamScoreSystem_Load(object sender, EventArgs e)
		{

			students = new List<IStudent>();
			filterers = new HashSet<IFilterer>();
			StudentFileUtil.ReadStudentDataFromFile(students);

			inputValidator = new InputValidator(this);
            
            ResetLabels();
		}

		private void ResetLabels()
		{
			nameValidatorLabel.Text = "";
			surnameValidatorLabel.Text = "";
			courseValidatorLabel.Text = "";
			label_validate_does_exist.Text = "";
		}

		private void ResetInputFields()
		{
			nameTextBox.Clear();
			surnameTextBox.Clear();
			courseComboBox.SelectedIndex = -1;
		}

		private string CapitalizeFirstLetter(string text)
		{
			text = text.Trim();

			if (text == null || text.Length == 0)
				return null;
			else if (text.Trim().Length == 1)
				return text.ToUpper();
			else
				return char.ToUpper(text[0]) + text.Substring(1).ToLower();
		}

		private void AddStudentButton_Click(object sender, EventArgs e)
		{
			if (!inputValidator.AreAllInputsValid())
				return;

			string name = CapitalizeFirstLetter(nameTextBox.Text);
			string surname = CapitalizeFirstLetter(surnameTextBox.Text);
			int course = int.Parse((courseComboBox.SelectedItem.ToString()));

			int sdf1 = int.Parse(sdf1NumericUpDown.Text);
			int sdf2 = int.Parse(sdf2NumericUpDown.Text);
			int sdf3 = int.Parse(sdf3NumericUpDown.Text);
			int final = int.Parse(FinalNumericUpDown.Text);

			int id = Math.Abs((name + surname + course.ToString()).GetHashCode());
			id = int.Parse(id.ToString().Substring(0, 6));

			bool doesExist = students.Any(std => std.GetId() == id);

			if (doesExist)
			{
				label_validate_does_exist.Text = "You have already added this student.";
				return;
			}
			else
				label_validate_does_exist.Text = "";

			IStudent student = new BEUStudent(name, surname, course, id, new ExamScore(sdf1, sdf2, sdf3, final));

			students.Add(student);

			MessageBox.Show($"Student {name} {surname} was successfully registrated.");
			ResetInputFields();
		}

		private void PrintStudentList(List<IStudent> studentList)
		{
			foreach (var student in studentList)
			{
				PrintSingleStudent(student);
			}
		}

		private void PrintSingleStudent(IStudent student)
		{
			StringBuilder consoleTextBuilder = new StringBuilder();

			consoleTextBuilder.Append(string.Format("{1,-12} ", "NAME:", student.GetName()))
			  .Append(string.Format("{1,-12} ", "SURNAME:", student.GetSurname()))
			  .Append(string.Format("{1,-7} ", "COURSE:", student.GetCourse()))
			  .Append(string.Format("{1,-7} ", "ID:", student.GetId()))
			  .Append(string.Format("{1,-6} ", "SDF1:", student.GetExamScores().Sdf1))
			  .Append(string.Format("{1,-6} ", "SDF2:", student.GetExamScores().Sdf2))
			  .Append(string.Format("{1,-6} ", "SDF3:", student.GetExamScores().Sdf3))
			  .Append(string.Format("{1,-7} ", "FINAL:", student.GetExamScores().Final))
			  .Append(string.Format("{1,7} ", "AVERAGE:", student.GetExamScores().CalculateAverage().ToString()))
			  .Append("\r\n");

			consoleTextBox.AppendText(consoleTextBuilder.ToString());
		}

		private void SortButton_Click(object sender, EventArgs e)
		{
			WriteDefaultTextToConsole();

			bool reversed = reversedCheckBox.Checked;

			if (sortStudentsComboBox.SelectedItem == null) return;

			string selectedSortingTypeInString = (string) sortStudentsComboBox.SelectedItem;

			SortingParameterFactory.SortingType selectedSortingType = (SortingParameterFactory.SortingType)Enum.Parse(
				typeof(SortingParameterFactory.SortingType),
				selectedSortingTypeInString
				);

			List<IStudent> sortedStudentList;

			Func<IStudent, int> sortParameter = SortingParameterFactory.GetSortParameter(selectedSortingType);

			if (reversed)
			{
				sortedStudentList = ReverseSortBy(sortParameter);
			}
			else
			{
				sortedStudentList = SortBy(sortParameter);
			}

			PrintStudentList(sortedStudentList);
		}

		private List<IStudent> SortBy(Func<IStudent, int> sortParameter)
		{
			return students.OrderBy(sortParameter).ToList();
		}

		private List<IStudent> ReverseSortBy(Func<IStudent, int> sortParameter)
		{
			return students.OrderByDescending(sortParameter).ToList();
		}

		private void ShowAllButton_Click(object sender, EventArgs e)
		{
			WriteDefaultTextToConsole();

			PrintStudentList(students);
		}

		private void WriteDefaultTextToConsole()
		{
            consoleTextBox.Text = string.Format("{0,-12} {1,-12} {2,-7} {3,-7} {4,-6} {5,-6} {6,-6} {7,-7} {8,7}", "NAME", "SURNAME", "COURSE", "ID", "SDF1", "SDF2", "SDF3", "FINAL", "AVERAGE");
            consoleTextBox.AppendText(Environment.NewLine);
            consoleTextBox.AppendText("------------------------------------------------------------------------------");
            consoleTextBox.AppendText(Environment.NewLine);
		}


		private void FindStudentButton_Click(object sender, EventArgs e)
		{
			consoleTextBox.Clear();
			HandleNameFilter();
			HandleSurnameFilter();
			HandleSelectedCourseFilter();
			HandleFirstExamFilter();
			HandleSecondExamFilter();
			HandleThirdExamFilter();
			HandleFinalExamFilter();
			HandleAverageScoreFilter();

			List<IStudent> studentListToDisplay = GetFilteredStudentList();

			PrintStudentList(studentListToDisplay);
		}

		private List<IStudent> GetFilteredStudentList()
		{
			List<IStudent> studentListToDisplay;

			if (filterers.Count == 1)
			{
				IFilterer filterer = filterers.ElementAt(0);

				studentListToDisplay = filterer.Filter(students);
			}
			else
			{
				IFilterer filterer = new AdvancedFilterer(filterers.ToList());
				studentListToDisplay = filterer.Filter(students);
			}

			return studentListToDisplay;
		}

		private void HandleAverageScoreFilter()
		{
			if (averageScoreNumeric.Value == 0)
			{
				IFilterer searchedAverageScoreFilterer = HashSetContainsItem(typeof(AverageScoreFilterer));

				if (searchedAverageScoreFilterer != null)
				{
					filterers.Remove(searchedAverageScoreFilterer);
				}
			}
			else
				filterers.Add(new AverageScoreFilterer((int)averageScoreNumeric.Value));
		}

		private void HandleFinalExamFilter()
		{
			if (finalExamNumeric.Value == 0)
			{
				IFilterer searchedFinalExamFilterer = HashSetContainsItem(typeof(FinalExamFilterer));

				if (searchedFinalExamFilterer != null)
				{
					filterers.Remove(searchedFinalExamFilterer);
				}
			}
			else
				filterers.Add(new FinalExamFilterer((int)finalExamNumeric.Value));
		}

		private void HandleThirdExamFilter()
		{
			if (thirdExamNumeric.Value == 0)
			{
				IFilterer searchedThirdExamFilterer = HashSetContainsItem(typeof(ThirdExamFilterer));

				if (searchedThirdExamFilterer != null)
				{
					filterers.Remove(searchedThirdExamFilterer);
				}
			}
			else
				filterers.Add(new ThirdExamFilterer((int)thirdExamNumeric.Value));
		}

		private void HandleSecondExamFilter()
		{
			if (secondExamNumeric.Value == 0)
			{
				IFilterer searchedSecondExamFilterer = HashSetContainsItem(typeof(SecondExamFilterer));

				if (searchedSecondExamFilterer != null)
				{
					filterers.Remove(searchedSecondExamFilterer);
				}
			}
			else
				filterers.Add(new SecondExamFilterer((int)secondExamNumeric.Value));
		}

		private void HandleFirstExamFilter()
		{
			if (firstExamNumeric.Value == 0)
			{
				IFilterer searchedFirstExamFilterer = HashSetContainsItem(typeof(FirstExamFilterer));

				if (searchedFirstExamFilterer != null)
				{
					filterers.Remove(searchedFirstExamFilterer);
				}
			}
			else
				filterers.Add(new FirstExamFilterer((int)firstExamNumeric.Value));
		}

		private void HandleSelectedCourseFilter()
		{
			if (findCourseComboBox.SelectedItem == null)
			{
				IFilterer searchedSelectedCourseFilter = HashSetContainsItem(typeof(CourseFilterer));

				if (searchedSelectedCourseFilter != null)
				{
					filterers.Remove(searchedSelectedCourseFilter);
				}
			}
			else
				filterers.Add(new CourseFilterer((int)findCourseComboBox.SelectedItem));
		}

		private void HandleSurnameFilter()
		{
			if (string.IsNullOrEmpty(findSurnameTextBox.Text))
			{
				IFilterer searchedSurnameFilterer = HashSetContainsItem(typeof(SurnameFilterer));

				if (searchedSurnameFilterer != null)
				{
					filterers.Remove(searchedSurnameFilterer);
				}
			}
			else
				filterers.Add(new SurnameFilterer(findSurnameLabel.Text));
		}

		private void HandleNameFilter()
		{
			if (string.IsNullOrEmpty(findNameTextBox.Text))
			{
				IFilterer searchedNameFilter = HashSetContainsItem(typeof(NameFilterer));

				if (searchedNameFilter != null)
				{
					filterers.Remove(searchedNameFilter);
				}
			}
			else
				filterers.Add(new NameFilterer(findNameTextBox.Text));
		}

		private IFilterer HashSetContainsItem(Type filterType)
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

		private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

        private void ExitButton_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			WindowState = FormWindowState.Minimized;
		}

        private void InitializeCurrentUserInfo()
        {
			currentUserInfo = new CurrentUserInfo();
        }

		private void UserInfoButton_Click(object sender, EventArgs e)
        {
			InitializeCurrentUserInfo();
			currentUserInfo.ShowDialog();
        }

		private void ClearUserData()
        {
			UserFileUtil.ClearCurrentUserData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			string dialogMessage =
				"Are you sure you want to sign out ?";

			DialogResult dialogResult = MessageBox.Show(dialogMessage, "Sign out", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
				Close();
			}

		}

        private void StudentExamScoreSys_FormClosed(object sender, FormClosedEventArgs e)
        {
			ClearUserData();
			StudentFileUtil.WriteStudentDataToDefaultFile(students);
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "Save as |*.txt";
			
			if(dialog.ShowDialog() == DialogResult.OK)
            {
				StudentFileUtil.WriteStudentDataToFile(dialog.FileName,students);
            }
        }
	}
}
