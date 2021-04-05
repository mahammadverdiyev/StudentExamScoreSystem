using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using System.Drawing;
using System.Threading;

namespace StudentExamScoreSystem
{
	public partial class StudentExamScoreSys : Form
	{
		private List<IStudent> students;
		private CurrentUserInfo currentUserInfo;
		private InputValidator inputValidator;
		private PrivateFontCollection pfc;
		public Label NameValidatorLabel => nameValidatorLabel;
		public Label SurnameValidatorLabel => surnameValidatorLabel;
		public Label CourseValidaterLabel => courseValidatorLabel;
		public TextBox NameTextbox => nameTextBox;
		public TextBox SurnameTextbox => surnameTextBox;
		public ComboBox CourseComboBox => courseComboBox;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd,
						 int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();


		public StudentExamScoreSys()
        {
            Thread trd = new Thread(new ThreadStart(RunLoadingScreen));
            trd.Start();
            Thread.Sleep(12000);
			InitializeComponent();
            trd.Abort();
        }
		private void RunLoadingScreen()
		{
			Application.Run(new LoadingScreen());
		}

		private void InitializeCustomFont()
        {
			pfc = new PrivateFontCollection();

			int fontLength = Properties.Resources.Meslo_LG_M.Length;

			byte[] fontdata = Properties.Resources.Meslo_LG_M;

			IntPtr data = Marshal.AllocCoTaskMem(fontLength);

			Marshal.Copy(fontdata, 0, data, fontLength);

			pfc.AddMemoryFont(data, fontLength);

			consoleTextBox.Font = new Font(pfc.Families[0], consoleTextBox.Font.Size);
		}
		private void StudentExamScoreSystem_Load(object sender, EventArgs e)
		{

			InitializeCustomFont();
			this.WindowState = FormWindowState.Minimized;
			this.WindowState = FormWindowState.Normal;
			this.Focus(); this.Show();


			students = new List<IStudent>();
			inputValidator = new InputValidator(this);
            
			//this.MaximumSize = new System.Drawing.Size(1233, 585);

            ResetLabels();

			students.Add(new BEUStudent("Mahammad", "Verdiyev", 2, 456465, new ExamScore(53, 87, 69, 74)));
			students.Add(new BEUStudent("Kamil", "Abiyev", 3, 784394, new ExamScore(85, 71, 65, 77)));
			students.Add(new BEUStudent("Elnur", "Veliyev", 1, 279246, new ExamScore(70, 89, 76, 85)));
			students.Add(new BEUStudent("Nihad", "Adigozelov", 4, 975473, new ExamScore(66, 79, 73, 90)));
			students.Add(new BEUStudent("Orxan", "Aslanov", 1, 972948, new ExamScore(63, 46, 70, 88)));
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

			if(sortStudentsComboBox.SelectedItem == null)
            {
				return;
            }

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

		private bool HandleValueRange(int score, string op, int examResult)
		{
			bool valid = false;

			if (op.Equals("="))
			{
				if (examResult == score)
					valid = true;
			}
			else if (op.Equals("<"))
			{
				if (examResult < score)
					valid = true;
			}
			else
			{
				if (examResult > score)
					valid = true;
			}

			return valid;
		}

		private void FindStudentButton_Click(object sender, EventArgs e)
		{
			WriteDefaultTextToConsole();

			string name = CapitalizeFirstLetter(findNameTextBox.Text);
			string surname = CapitalizeFirstLetter(findSurnameTextBox.Text);
			string course = "";
			if (findCourseComboBox.SelectedItem != null)
				course = findCourseComboBox.SelectedItem.ToString();

			List<IStudent> studentsWeSearch = new List<IStudent>();

			int sdf1 = -4818, sdf2 = -4818, sdf3 = -4818, final = -4818, average = -4818;

			string op_sdf1 = null, op_sdf2 = null, op_sdf3 = null, op_final = null, op_average = null;

			if (int.TryParse(txtbox_find_sdf1.Text, out int _sdf1))
			{
				sdf1 = _sdf1;
				if (findSdf1ComboBox.SelectedItem != null)
					op_sdf1 = findSdf1ComboBox.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_sdf2.Text, out int _sdf2))
			{
				sdf2 = _sdf2;
				if (findSdf2ComboBox.SelectedItem != null)
					op_sdf2 = findSdf2ComboBox.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_sdf3.Text, out int _sdf3))
			{
				sdf3 = _sdf3;
				if (findSdf3ComboBox.SelectedItem != null)
					op_sdf3 = findSdf3ComboBox.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_final.Text, out int _final))
			{
				final = _final;
				if (findFinalComboBox.SelectedItem != null)
					op_final = findFinalComboBox.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_average.Text, out int _average))
			{
				average = _average;
				if (findAverageComboBox.SelectedItem != null)
					op_average = findAverageComboBox.SelectedItem.ToString();
			}

			int emptyFieldCount = 0;

			// count empty fields
			if (name == null || name.Trim().Length == 0)
				emptyFieldCount++;
			if (surname == null || surname.Trim().Length == 0)
				emptyFieldCount++;
			if (course == null || course.Trim().Length == 0)
				emptyFieldCount++;
			if (op_sdf1 == null || sdf1 == -4818)
				emptyFieldCount++;
			if (op_sdf2 == null || sdf2 == -4818)
				emptyFieldCount++;
			if (op_sdf3 == null || sdf3 == -4818)
				emptyFieldCount++;
			if (op_final == null || final == -4818)
				emptyFieldCount++;
			if (op_average == null || average == -4818)
				emptyFieldCount++;

			foreach (var student in students)
			{
				if (name != null && name.Trim().Length != 0)
				{
					if (!student.GetName().StartsWith(name))
						continue;
				}
				if (surname != null && surname.Trim().Length != 0)
				{
					if (!student.GetSurname().StartsWith(surname))
						continue;
				}
				if (course != null && course.Trim().Length != 0)
				{
					if (!student.GetCourse().ToString().StartsWith(course))
						continue;
				}
				if (op_sdf1 != null && sdf1 != -4818)
				{
					bool isValid = HandleValueRange(sdf1, op_sdf1, student.GetExamScores().Sdf1);

					if (!isValid)
						continue;
				}
				if (op_sdf2 != null && sdf2 != -4818)
				{
					bool isValid = HandleValueRange(sdf2, op_sdf2, student.GetExamScores().Sdf2);

					if (!isValid)
						continue;
				}
				if (op_sdf3 != null && sdf3 != -4818)
				{
					bool isValid = HandleValueRange(sdf3, op_sdf3, student.GetExamScores().Sdf3);

					if (!isValid)
						continue;
				}
				if (op_final != null && final != -4818)
				{
					bool isValid = HandleValueRange(final, op_final, student.GetExamScores().Final);

					if (!isValid)
						continue;
				}
				if (op_average != null && average != -4818)
				{
					bool isValid = HandleValueRange(average, op_average, student.GetExamScores().CalculateAverage());

					if (!isValid)
						continue;
				}

				if (emptyFieldCount != 8)
				{
					studentsWeSearch.Add(student);
				}
			}

			PrintStudentList(studentsWeSearch);
		}

        private void button_whoisare_Click(object sender, EventArgs e)
        {

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
			ClearUserData();
			pfc.Dispose();
			Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			this.WindowState = FormWindowState.Minimized;
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
				ClearUserData();
				pfc.Dispose();
				this.Close();
			}

		}
    }
}
