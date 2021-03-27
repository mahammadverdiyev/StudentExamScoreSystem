using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace StudentExamScoreSystem
{
	public partial class StudentExamScoreSystem : Form
	{
		private List<BEUStudent> students;

		private InputValidator inputValidator;

		public Label NameValidateLabel => label_validate_name;
		public Label SurnameValidateLabel => label_validate_surname;
		public Label CourseValidateLabel => label_validate_course;
		public TextBox NameTextbox => txtbox_name;
		public TextBox SurnameTextbox => txtbox_surname;
		public ComboBox CourseComboBox => comboBox_course;

		public StudentExamScoreSystem()
		{
			InitializeComponent();
		}

		private void StudentExamScoreSystem_Load(object sender, EventArgs e)
		{
			students = new List<BEUStudent>();
			inputValidator = new InputValidator(this);

			ResetLabels();

			students.Add(new BEUStudent("Mahammad", "Verdiyev", 2, 456465, new ExamScore(53, 87, 69, 74)));
			students.Add(new BEUStudent("Kamil", "Abiyev", 3, 784394, new ExamScore(85, 71, 65, 77)));
			students.Add(new BEUStudent("Elnur", "Veliyev", 1, 279246, new ExamScore(70, 89, 76, 85)));
			students.Add(new BEUStudent("Nihad", "Adigozelov", 4, 975473, new ExamScore(66, 79, 73, 90)));
			students.Add(new BEUStudent("Orxan", "Aslanov", 1, 972948, new ExamScore(63, 46, 70, 88)));
		}

		private void ResetLabels()
		{
			label_validate_name.Text = "";
			label_validate_surname.Text = "";
			label_validate_sdf1.Text = "";
			label_validate_sdf2.Text = "";
			label_validate_sdf3.Text = "";
			label_validate_final.Text = "";
			label_validate_course.Text = "";
			label_validate_does_exist.Text = "";
		}

		private void ResetInputFields()
		{
			txtbox_name.Clear();
			txtbox_surname.Clear();
			comboBox_course.SelectedIndex = -1;
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

			string name = CapitalizeFirstLetter(txtbox_name.Text);
			string surname = CapitalizeFirstLetter(txtbox_surname.Text);
			int course = int.Parse((comboBox_course.SelectedItem.ToString()));

			int sdf1 = int.Parse(numericUpDown_Sdf1.Text);
			int sdf2 = int.Parse(numericUpDown_Sdf2.Text);
			int sdf3 = int.Parse(numericUpDown_Sdf3.Text);
			int final = int.Parse(numericUpDown_Final.Text);

			int id = Math.Abs((name + surname + course.ToString()).GetHashCode());
			id = int.Parse(id.ToString().Substring(0, 6));

			bool doesExist = students.Any<BEUStudent>(std => std.Id == id);

			if (doesExist)
			{
				label_validate_does_exist.Text = "You have already added this student.";
				return;
			}
			else
				label_validate_does_exist.Text = "";

			BEUStudent student = new BEUStudent(name, surname, course, id, new ExamScore(sdf1, sdf2, sdf3, final));

			students.Add(student);

			MessageBox.Show($"Student {name} {surname} was successfully registrated.");
			ResetInputFields();
		}

		private void PrintStudentList(List<BEUStudent> studentList)
		{
			foreach (var student in studentList)
			{
				PrintSingleStudent(student);
			}
		}

		private void PrintSingleStudent(BEUStudent student)
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(string.Format("{1,-12} ", "NAME:", student.Name))
			  .Append(string.Format("{1,-12} ", "SURNAME:", student.Surname))
			  .Append(string.Format("{1,-7} ", "COURSE:", student.Course))
			  .Append(string.Format("{1,-7} ", "ID:", student.Id))
			  .Append(string.Format("{1,-6} ", "SDF1:", student.ExamScore.Sdf1))
			  .Append(string.Format("{1,-6} ", "SDF2:", student.ExamScore.Sdf2))
			  .Append(string.Format("{1,-6} ", "SDF3:", student.ExamScore.Sdf3))
			  .Append(string.Format("{1,-7} ", "FINAL:", student.ExamScore.Final))
			  .Append(string.Format("{1,7} ", "AVERAGE:", student.ExamScore.CalculateAverage().ToString()))
			  .Append("\r\n");

			txtbox_console.AppendText(sb.ToString());
		}

		private void SortButton_Click(object sender, EventArgs e)
		{
			WriteDefaultTextToConsole();

			bool reversed = checkBox_reversed.Checked;

			string selectedSortType = comboBox_sort.SelectedItem.ToString();

			List<BEUStudent> sortedStudentList;

			Func<BEUStudent, int> sortParameter = SortParameterFactory.GetSortParameter(selectedSortType);

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

		private List<BEUStudent> SortBy(Func<BEUStudent, int> sortParameter)
		{
			return (List<BEUStudent>)students.OrderBy(sortParameter);
		}

		private List<BEUStudent> ReverseSortBy(Func<BEUStudent, int> sortParameter)
		{
			return (List<BEUStudent>)students.OrderByDescending(sortParameter);
		}

		private void ShowAllButton_Click(object sender, EventArgs e)
		{
			WriteDefaultTextToConsole();

			PrintStudentList(students);
		}

		private void WriteDefaultTextToConsole()
		{
			txtbox_console.Text = String.Format("{0,-12} {1,-12} {2,-7} {3,-7} {4,-6} {5,-6} {6,-6} {7,-7} {8,7}", "NAME", "SURNAME", "COURSE", "ID", "SDF1", "SDF2", "SDF3", "FINAL", "AVERAGE");
			txtbox_console.AppendText(Environment.NewLine);
			txtbox_console.AppendText("------------------------------------------------------------------------------");
			txtbox_console.AppendText(Environment.NewLine);
		}

		private bool HandleValueRange(int score, string op, string key, Dictionary<string, int> scores)
		{
			bool valid = false;

			if (op.Equals("="))
			{
				if (scores[key] == score)
					valid = true;
			}
			else if (op.Equals("<"))
			{
				if (scores[key] < score)
					valid = true;
			}
			else
			{
				if (scores[key] > score)
					valid = true;
			}

			return valid;
		}

		private void FindStudentButton_Click(object sender, EventArgs e)
		{
			WriteDefaultTextToConsole();

			string name = CapitalizeFirstLetter(txtbox_find_name.Text);
			string surname = CapitalizeFirstLetter(txtbox_find_surname.Text);
			string course = "";
			if (comboBox_find_course.SelectedItem != null)
				course = comboBox_find_course.SelectedItem.ToString();

			List<BEUStudent> studentsWeSearch = new List<BEUStudent>();

			int sdf1 = -4818, sdf2 = -4818, sdf3 = -4818, final = -4818, average = -4818;

			string op_sdf1 = null, op_sdf2 = null, op_sdf3 = null, op_final = null, op_average = null;

			if (int.TryParse(txtbox_find_sdf1.Text, out int _sdf1))
			{
				sdf1 = _sdf1;
				if (comboBox_find_sdf1.SelectedItem != null)
					op_sdf1 = comboBox_find_sdf1.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_sdf2.Text, out int _sdf2))
			{
				sdf2 = _sdf2;
				if (comboBox_find_sdf2.SelectedItem != null)
					op_sdf2 = comboBox_find_sdf2.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_sdf3.Text, out int _sdf3))
			{
				sdf3 = _sdf3;
				if (comboBox_find_sdf3.SelectedItem != null)
					op_sdf3 = comboBox_find_sdf3.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_final.Text, out int _final))
			{
				final = _final;
				if (comboBox_find_final.SelectedItem != null)
					op_final = comboBox_find_final.SelectedItem.ToString();
			}
			if (int.TryParse(txtbox_find_average.Text, out int _average))
			{
				average = _average;
				if (comboBox_find_average.SelectedItem != null)
					op_average = comboBox_find_average.SelectedItem.ToString();
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
					if (!student.Name.StartsWith(name))
						continue;
				}
				if (surname != null && surname.Trim().Length != 0)
				{
					if (!student.Surname.StartsWith(surname))
						continue;
				}
				if (course != null && course.Trim().Length != 0)
				{
					if (!student.Course.ToString().StartsWith(course))
						continue;
				}
				if (op_sdf1 != null && sdf1 != -4818)
				{
					bool isValid = HandleValueRange(sdf1, op_sdf1, "sdf1", student.GetScores());

					if (!isValid)
						continue;
				}
				if (op_sdf2 != null && sdf2 != -4818)
				{
					bool isValid = HandleValueRange(sdf2, op_sdf2, "sdf2", student.GetScores());

					if (!isValid)
						continue;
				}
				if (op_sdf3 != null && sdf3 != -4818)
				{
					bool isValid = HandleValueRange(sdf3, op_sdf3, "sdf3", student.GetScores());

					if (!isValid)
						continue;
				}
				if (op_final != null && final != -4818)
				{
					bool isValid = HandleValueRange(final, op_final, "final", student.GetScores());

					if (!isValid)
						continue;
				}
				if (op_average != null && average != -4818)
				{
					bool isValid = HandleValueRange(average, op_average, "average", student.GetScores());

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
	}
}
