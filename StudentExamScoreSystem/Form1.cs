using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentExamScoreSystem;

namespace StudentExamScoreSystem
{

    public partial class Form1 : Form
    {

        List<BEUStudent> students;
        List<BEUStudent> lastPrintedStudentList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<BEUStudent>();
            lastPrintedStudentList = new List<BEUStudent>();
            ResetLabels();

            // dummy data 
            students.Add(new BEUStudent("Mahammad", "Verdiyev", 2, 456465, 53, 87, 69, 74));
            students.Add(new BEUStudent("Kamil", "Abiyev", 3, 784394, 85, 71, 65, 77));
            students.Add(new BEUStudent("Elnur", "Veliyev", 1, 279246, 70, 89, 76, 85));
            students.Add(new BEUStudent("Nihad", "Adigozelov", 4, 975473, 66, 79, 73, 90));
            students.Add(new BEUStudent("Orxan", "Aslanov", 1, 972948, 63, 46, 70, 88));
            // I'll implement read/write operation soon.

        }

        private void ResetLabels()
        {
            label_validate_name.Text = "";
            label_validate_surname.Text = "";
            label_validate_sdf1.Text = "";
            label_validate_sdf2.Text = "";
            label_validate_sdf3.Text = "";
            label_validate_final.Text = "";
            label_validate_age.Text = "";
            label_validate_does_exist.Text = "";
        }

        private void ResetInputFields()
        {
            txtbox_name.Clear();
            txtbox_surname.Clear();
            comboBox_course.SelectedIndex = -1;
            txtbox_sdf1.Clear();
            txtbox_sdf2.Clear();
            txtbox_sdf3.Clear();
            txtbox_final.Clear();
        }

        // Returns true if 
        // given field is valid
        private bool NameSurnameValidator(TextBox textField)  
        {
            string nameOrSurname = textField.Text;
            Label messageLabel = 
                textField.Name.Equals("txtbox_name") ?
                label_validate_name : label_validate_surname;

            bool isValid = false;

            if (nameOrSurname.Trim().Length == 0)
            {
                messageLabel.Text = "Field should not be empty!";
            }
            else if (nameOrSurname.Any(char.IsDigit))
            {
                messageLabel.Text = "Enter only text";
            }
            else
            {
                messageLabel.Text = "";
                isValid = true;
            }
            
            return isValid;
        }

        private bool ScoreValidator(TextBox textField, Label message, Label label)
        {
            bool isValid = false;
            string value = textField.Text.Trim();

            if(value.Length == 0)
            {
                message.Text = $"Enter {label.Text.Remove(label.Text.IndexOf(":"))} score";
            }
            else if(value.Any(char.IsLetter))
            {
                message.Text = "Enter only number";
            }
            else if(int.TryParse(value, out int score))
            {
                if (score > 100 || score < 0)
                    message.Text = "Enter correct score";
                else
                {
                    message.Text = "";
                    isValid = true;
                }
            }

            return isValid;
        }

        public bool CourseValidator(ComboBox boxField, Label message)
        {
            bool isValid = false;
            string value = "";

            if(boxField.SelectedItem != null)
                value = boxField.SelectedItem.ToString();


            if(int.TryParse(value, out int age))
            {
                if(age < 0)
                {
                    message.Text = "Enter only positive value";
                }
                else
                {
                    message.Text = "";
                    isValid = true;
                }
            }
            else
            {
                message.Text = "Enter course";
            }

            return isValid;
        }

        public bool CustomValidator()
        {
            int counter = 0;
            // Name validation

            // name
            if (!NameSurnameValidator(txtbox_name))
                counter++;

            // surname
            if (!NameSurnameValidator(txtbox_surname))
                counter++;

            // age
            if (!CourseValidator(comboBox_course, label_validate_age))
                counter++;

            // SDF1
            if (!ScoreValidator(txtbox_sdf1, label_validate_sdf1, label_sdf1))
                counter++;

            // SDF2
            if (!ScoreValidator(txtbox_sdf2, label_validate_sdf2, label_sdf2))
                counter++;
            
            // SDF3
            if (!ScoreValidator(txtbox_sdf3, label_validate_sdf3, label_sdf3))
                counter++;
            
            // Final
            if (!ScoreValidator(txtbox_final, label_validate_final, label_final))
                counter++;
            
            if (counter > 0)
                return false;
            
            return true;
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

        private void button_add_student_Click(object sender, EventArgs e)
        {
            // validation
            if (!CustomValidator())
                return;

            string name = CapitalizeFirstLetter(txtbox_name.Text);
            string surname = CapitalizeFirstLetter(txtbox_surname.Text);
            int course  = int.Parse((string)(comboBox_course.SelectedItem.ToString()));
            int sdf1 = int.Parse(txtbox_sdf1.Text);
            int sdf2 = int.Parse(txtbox_sdf2.Text);
            int sdf3 = int.Parse(txtbox_sdf3.Text);
            int final = int.Parse(txtbox_final.Text);
            int id = Math.Abs((name + surname + course.ToString()).GetHashCode());
            id = int.Parse(id.ToString().Substring(0,6));

            bool doesExist = students.Any<BEUStudent>(std => std.GetId() == id);

            if (doesExist)
            {
                label_validate_does_exist.Text = "You have already added this student.";
                return;
            }
            else
                label_validate_does_exist.Text = "";

            BEUStudent student = new BEUStudent(name,surname,course,id,sdf1,sdf2,sdf3,final);

            students.Add(student);

            MessageBox.Show($"Student {name} {surname} was successfully registrated.");
            ResetInputFields();
        }

        private List<BEUStudent> CustomSorting(List<BEUStudent> studentList, Func<BEUStudent, int> function, bool reversed)
        {
            List<BEUStudent> sortedStudentList = null;

            if (reversed)
                sortedStudentList = studentList.OrderByDescending(function).ToList();
            else
                sortedStudentList = studentList.OrderBy(function).ToList();

            return sortedStudentList;
        }
        private List<BEUStudent> StudentSortHandler(List<BEUStudent> studentList, int index, bool reversed)
        {
            List<BEUStudent> sortedStudentList;
            
            if (index == 0)
                sortedStudentList = CustomSorting(studentList,std => std.GetCourse(), reversed);

            else if (index == 1)
                sortedStudentList = CustomSorting(studentList,std => std.GetScores()["sdf1"], reversed);

            else if (index == 2)
                sortedStudentList = CustomSorting(studentList,std => std.GetScores()["sdf2"], reversed);

            else if (index == 3)
                sortedStudentList = CustomSorting(studentList,std => std.GetScores()["sdf3"], reversed);

            else if (index == 4)
                sortedStudentList = CustomSorting(studentList,std => std.GetScores()["final"], reversed);

            else if (index == 5)
                sortedStudentList = CustomSorting(studentList,std => std.calculateAverage(), reversed);
            else
                sortedStudentList = studentList;


            return sortedStudentList;
        }



        private void PrintToConsole(BEUStudent student, TextBox field)
        {
            StringBuilder sb = new StringBuilder();

            Dictionary<string, int> scores = student.GetScores();

          sb.Append(String.Format("{1,-12} ", "NAME:", student.GetName()))
            .Append(String.Format("{1,-12} ", "SURNAME:", student.GetSurname()))
            .Append(String.Format("{1,-7} ", "COURSE:", student.GetCourse()))
            .Append(String.Format("{1,-7} ", "ID:", student.GetId()))
            .Append(String.Format("{1,-6} ", "SDF1:", scores["sdf1"]))
            .Append(String.Format("{1,-6} ", "SDF2:", scores["sdf2"]))
            .Append(String.Format("{1,-6} ", "SDF3:", scores["sdf3"]))
            .Append(String.Format("{1,-7} ", "FINAL:", scores["final"]))
            .Append(String.Format("{1,7} ", "AVERAGE:", student.calculateAverage().ToString()))
            .Append("\r\n");

            field.AppendText(sb.ToString());
        }

        private void PrintListToConsole(List<BEUStudent> studentList,TextBox field)
        {   
            foreach(var student in studentList)
            {
                PrintToConsole(student, field);
            }
        }

        private void button_show_all_Click(object sender, EventArgs e)
        {
            txtbox_console.Text = String.Format("{0,-12} {1,-12} {2,-7} {3,-7} {4,-6} {5,-6} {6,-6} {7,-7} {8,7}", "NAME", "SURNAME", "COURSE", "ID", "SDF1", "SDF2", "SDF3", "FINAL", "AVERAGE");
            txtbox_console.AppendText(Environment.NewLine);
            txtbox_console.AppendText("------------------------------------------------------------------------------");
            txtbox_console.AppendText(Environment.NewLine);

            lastPrintedStudentList = students;

            PrintListToConsole(students, txtbox_console);
        }

        private bool HandleValueRange(int score,string op,string key, Dictionary<string,int> scores)
        {
            bool valid = false;

            if (op.Equals("="))
            {
                if (scores[key] == score)
                    valid = true;
            }
            else if(op.Equals("<"))
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


        // searching students according to given parameters
        private void button_find_student_Click(object sender, EventArgs e)
        {
            txtbox_console.Text = String.Format("{0,-12} {1,-12} {2,-7} {3,-7} {4,-6} {5,-6} {6,-6} {7,-7} {8,7}", "NAME", "SURNAME", "COURSE", "ID", "SDF1", "SDF2", "SDF3", "FINAL", "AVERAGE");
            txtbox_console.AppendText(Environment.NewLine);
            txtbox_console.AppendText("------------------------------------------------------------------------------");
            txtbox_console.AppendText(Environment.NewLine);

            string name = CapitalizeFirstLetter(txtbox_find_name.Text);
            string surname = CapitalizeFirstLetter(txtbox_find_surname.Text);
            string course = "";
            if(comboBox_find_course.SelectedItem != null)
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
                if(name != null && name.Trim().Length != 0)
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
                    bool isValid = HandleValueRange(sdf1,op_sdf1, "sdf1", student.GetScores());

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

                if(emptyFieldCount != 8)
                {
                    studentsWeSearch.Add(student);
                }
            }

            lastPrintedStudentList = studentsWeSearch;

            PrintListToConsole(studentsWeSearch, txtbox_console);
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            txtbox_console.Text = String.Format("{0,-12} {1,-12} {2,-7} {3,-7} {4,-6} {5,-6} {6,-6} {7,-7} {8,7}", "NAME", "SURNAME", "COURSE", "ID", "SDF1", "SDF2", "SDF3", "FINAL", "AVERAGE");
            txtbox_console.AppendText(Environment.NewLine);
            txtbox_console.AppendText("------------------------------------------------------------------------------");
            txtbox_console.AppendText(Environment.NewLine);

            bool reversed = checkBox_reversed.Checked;
            int index = comboBox_sort.SelectedIndex;

            List<BEUStudent> sortedStudentList =
                StudentSortHandler(lastPrintedStudentList, index, reversed);

            PrintListToConsole(sortedStudentList, txtbox_console);
        }

        private void button_whoisare_Click(object sender, EventArgs e)
        {
            // not implemented due to lack of time
            // TODO: Implement this method


            MessageBox.Show("Coming soon!");
        }
    }
}
