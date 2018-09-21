using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
