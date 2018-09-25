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
            Student_ListBox.DataSource = Program.m_students;
            Course_ListBox.DataSource = Program.m_courses;

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
        }

        private void AddStudent_Button_Click(object sender, EventArgs e)
        {
            string lastName = "";
            string firstName = "";
            string name = AddName_TextBox.Text.ToLower();
            string zid = AddZid_TextBox.Text.ToLower();
            string major = (string)AddMajor_ComboBox.SelectedItem;
            int year = AddYear_ComboBox.SelectedIndex;

            if (name.Contains(","))
            {
                var name2 = name.Split(',');
                name2[0].Replace(" ", "");
                name2[1].Replace(" ", "");
                lastName = name2[0].First().ToString().ToUpper() + name2[0].Substring(1);
                firstName = name2[1].First().ToString().ToUpper() + name2[1].Substring(1);

            }
            else
            {
                Output_TextBox.Text = "Please separate student's last and first name with comma!";
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

            if(AddMajor_ComboBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select a major!";
                return;
            }

            if (AddYear_ComboBox.SelectedIndex == -1)
            {
                Output_TextBox.Text = "Please select an academic year!";
                return;
            }

            Program.m_students.Add(new Student(zidNum, lastName, firstName, major, year, null));
            Output_TextBox.Text = "1 student added.";
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

            if (!AddSection_TextBox.Text.All(c => Char.IsLetterOrDigit(c)))
            {
                Output_TextBox.Text = "Please provide a valid 4 alphannumeric section number!";
                return;
            }
            string sect = AddSection_TextBox.Text.ToUpper();

            ushort capc = (ushort) AddCapacity_NumericUpDown.Value;

            Program.m_courses.Add(new Course(Dept, (uint)crs, sect, null, capc));
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
            
            if (course.EnrolledStudents.Contains(student.ZId))
            {
                Output_TextBox.Text = "Student " + student.ZId + " already enrolled " + course.ToString();
                return;
            }

            student.Enroll(course);
            Output_TextBox.Text = "Student z" + student.ZId + " successfully enrolled the course " + course.ToString() + ".";
            
            Program.m_courses.ResetBindings();
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
            
            if (!course.EnrolledStudents.Contains(student.ZId))
            {
                Output_TextBox.Text = "Student " + student.ZId + " haven't enrolled " + course.ToString();
                return;
            }

            student.Drop(course);
            Output_TextBox.Text = "Student z" + student.ZId + " successfully dropped the course " + course.ToString() + ".";
            
            Program.m_courses.ResetBindings();
        }
    }
}
