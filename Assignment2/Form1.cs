using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simpson_Assign1;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void StudentSelected(object sender, EventArgs e)
        {
            Student student = (Student) Student_ListBox.SelectedValue;
            var studentCourses = new BindingList<Course>();

            foreach (var course in Program.m_courses)
            {
                if (course.EnrolledStudents.Contains(student.ZId))
                {
                    studentCourses.Add(course);
                }
            }

            var builder = new StringBuilder();
            builder.Append(student);
            builder.Append(Environment.NewLine);
            builder.Append("-----------------------------------------------------------------------------------------------------------------------------------");
            builder.Append(Environment.NewLine);

            if (!studentCourses.Any())
            {
                builder.Append("Student is not enrolled in any courses!");
            }
            else
            {
                foreach (var course in studentCourses)
                {
                    var courseString = string.Format("{0} {1}-{2}", course.DepartmentCode, course.CourseNumber, course.SectionNumber);
                    builder.Append(courseString);
                    builder.Append(Environment.NewLine);
                }
            }

            Output_TextBox.Text = builder.ToString();
        }

        private void PrintCourseClicked(object sender, EventArgs e)
        {
            Course course = (Course) Course_ListBox.SelectedValue;
            var builder = new StringBuilder();

            builder.Append(course);
            builder.Append(Environment.NewLine);
            builder.Append("-----------------------------------------------------------------------------------------------------------------------------------");
            builder.Append(Environment.NewLine);

            if (!course.EnrolledStudents.Any())
            {
                builder.Append("There are no students currently enrolled in this course.");
            }
            else
            {
                foreach (var student in Program.m_students)
                {
                    if (course.EnrolledStudents.Contains(student.ZId))
                    {
                        var rosterString = string.Format("{0} {1}, {2} {3}", student.ZId, student.LastName, student.FirstName, student.Major);
                        builder.Append(rosterString);
                        builder.Append(Environment.NewLine);
                    }
                }
            }

            Output_TextBox.Text = builder.ToString();
        }

        public void LoadData()
        {
            Course_ListBox.DataSource = Program.m_courses;
            Student_ListBox.DataSource = Program.m_students;

            foreach (string mj in Program.m_majors)
            {
                AddMajor_ComboBox.Items.Add(mj);
            }
            
            foreach (string ay in Program.m_years)
            {
                AddYear_ComboBox.Items.Add(ay);
            }

            foreach (Course crs in Program.m_courses)
            {
                if(!AddDept_ComboBox.Items.Contains(crs.DepartmentCode))
                    AddDept_ComboBox.Items.Add(crs.DepartmentCode);
            }

            Output_TextBox.Text = null;
        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            //if any of the fields are empty, print error and return immediately
            if (AddName_TextBox.Text.Length == 0 ||
                AddZid_TextBox.Text.Length == 0 ||
                AddMajor_ComboBox.SelectedIndex == -1 ||
                AddYear_ComboBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Error: Please provide the student's name, Z-ID, Major and Academic Year";
                return;
            }

            string lastName = "";
            string firstName = "";
            string name = AddName_TextBox.Text.ToLower();
            string zid = AddZid_TextBox.Text.ToLower();
            string major = (string)AddMajor_ComboBox.SelectedItem;
            int year = AddYear_ComboBox.SelectedIndex;

            if (name.Contains(","))
            {
                var name2 = name.Split(',');
                if (name2.Count() > 1 && !string.IsNullOrEmpty(name2[1]))
                {
                    name2[0] = name2[0].Trim();
                    name2[1] = name2[1].Trim();
                    lastName = Char.ToUpper(name2[0].First()) + name2[0].Substring(1);
                    firstName = Char.ToUpper(name2[1].First()) + name2[1].Substring(1);
                }
                else
                {
                    Output_TextBox.Text = "Error: First name is missing";
                    return;
                }
            }
            else
            {
                Output_TextBox.Text = "Error: Please separate student's last and first name with comma!";
                return;
            }

            if (zid[0] == 'z')
            {
                zid = zid.Substring(1);
            }
            uint zidNum = 0;
            if(!uint.TryParse(zid, out zidNum) || zid.Length != 7 )
            {
                Output_TextBox.Text = "Please enter seven digits Z-ID!";
                return;
            }

            if (Program.m_students.Any(x => x.ZId == zidNum))
            {
                var outputText = string.Format("Error: A student with Z - ID '{0}' already exists", zidNum);
                Output_TextBox.Text = outputText;
            }
            else
            {
                Program.m_students.Add(new Student(zidNum, lastName, firstName, major, year, null));
                Output_TextBox.Text = "1 student added.";
            }
            
        }

        private void AddCourse_Button_Click(object sender, EventArgs e)
        {
            if (AddDept_ComboBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select a Department!";
                return;
            }
            string Dept = AddDept_ComboBox.SelectedItem.ToString();

            if(!Regex.IsMatch(AddCourse_TextBox.Text, @"[0-9]{3,3}")) {
                Output_TextBox.Text = "Please provide a valid 3 digits course number!";
                return;
            }
            int crs = Int32.Parse(AddCourse_TextBox.Text);

            if (!AddSection_TextBox.Text.All(c => Char.IsLetterOrDigit(c)) || AddSection_TextBox.Text.Length < 4)
            {
                Output_TextBox.Text = "Please provide a valid 4 alphannumeric section number!";
                return;
            }
            string sect = AddSection_TextBox.Text.ToUpper();

            ushort capc = (ushort) AddCapacity_NumericUpDown.Value;

            Program.m_courses.Add(new Course(Dept, (uint)crs, sect, 3, capc)); //assume class will be 3 credit hours
            Output_TextBox.Text = "1 course added.";
        }
        
        private void EnrollStudent_Button_Click(object sender, EventArgs e)
        {
            if(Student_ListBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select a student to enroll!";
                return;
            }
            Student student = (Student) Student_ListBox.SelectedItem;

            if (Course_ListBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select a course to enroll!";
                return;
            }
            Course course = (Course) Course_ListBox.SelectedItem;

            var response = student.Enroll(course);
            var output = string.Empty;
            switch (response)
            {
                case 0:
                    output = string.Format("Student z{0} successfully enrolled in course {1}, {2}-{3}.", student.ZId, course.DepartmentCode, course.CourseNumber, course.SectionNumber);
                    break;
                case 5:
                    output = string.Format("Error: {0} {1}-{2} is already at maximum capacity.", course.DepartmentCode, course.CourseNumber, course.SectionNumber);
                    break;
                case 10:
                    output = string.Format("Error: z{0} is already enrolled in {1} {2}-{3}.", student.ZId, course.DepartmentCode, course.CourseNumber, course.SectionNumber);
                    break;
                case 15:
                    output = string.Format("Error: z{0} already has a full schedule.", student.ZId);
                    break;
            }

            Output_TextBox.Text = output;
        }
        
         private void DropStudent_Button_Click(object sender, EventArgs e)
        {
            if (Student_ListBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select a student to drop!";
                return;
            }
            Student student = (Student)Student_ListBox.SelectedItem;

            if (Course_ListBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select a course to drop!";
                return;
            }
            Course course = (Course)Course_ListBox.SelectedItem;

            var response = student.Drop(course);
            var output = string.Empty;
            if (response == 0)
            {
                output = string.Format("Student z{0} successfully dropped from {1} {2}-{3}.", student.ZId, course.DepartmentCode, course.CourseNumber, course.SectionNumber);
            }
            else
            {
                output = string.Format("Error: z{0} is not currently enrolled in {1} {2}-{3}.", student.ZId, course.DepartmentCode, course.CourseNumber, course.SectionNumber);
            }

            Output_TextBox.Text = output;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Student_ListBox.DataSource = Program.m_students;
            Course_ListBox.DataSource = Program.m_courses;
            Output_TextBox.Text = "";

            //If zID and course input are both empty assign original list to listbox and return from function
            if (searchStudent_TextBox.Text.Length == 0 && FilterCourse_TextBox.Text.Length == 0)
            {
                Output_TextBox.Text = "Error: No search criteria hase been provided.";
                return;
            }

            if (searchStudent_TextBox.Text.Length > 0)
            {
               FilterStudents();
            }
            if (FilterCourse_TextBox.Text.Length > 0)
            {
                FilterCourses();
            }
        }

        private void FilterStudents()
        {
            //if user added the z at the beginning strip it
            var input = searchStudent_TextBox.Text;
            if (input[0] == 'z')
            {
                input = input.Substring(1);
            }

            //if any characters after the leading z is stripped are not a digit then throw an error and return
            if (!input.All(x => char.IsDigit(x)))
            {
                Output_TextBox.Text = "Error: Please enter a valid Z-ID";
                Output_TextBox.AppendText(Environment.NewLine);
                return;
            }

            //Now we actually filter the list
            List<Student> studentList = Program.m_students.ToList();
            List<Student> filteredStudents = studentList.FindAll(x => x.ZId.ToString().StartsWith(input));
            BindingList<Student> bindedStudents = new BindingList<Student>(filteredStudents);

            if (bindedStudents.Any())
            {
                Student_ListBox.DataSource = bindedStudents;
                Output_TextBox.Clear();
            }
            else
            {
                Student_ListBox.DataSource = Program.m_students;
                Output_TextBox.Text = "No students match your search criteria.";
                Output_TextBox.AppendText(Environment.NewLine);
            }
        }

        private void FilterCourses()
        {
            var departmentCode = FilterCourse_TextBox.Text;
            List<Course> courses = Program.m_courses.ToList();
            List<Course> filteredCourses = courses.FindAll(x => x.DepartmentCode == departmentCode);
            BindingList<Course> bindedCourses = new BindingList<Course>(filteredCourses);

            if (bindedCourses.Any())
            {
                Course_ListBox.DataSource = bindedCourses;
            }
            else
            {
                Course_ListBox.DataSource = Program.m_courses;
                Output_TextBox.Text += "No courses match your search criteria.";
            }
        }
    }
}
