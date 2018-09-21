﻿using System;
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
            builder.Append(student.ToString());
            builder.Append(Environment.NewLine);
            builder.Append("-----------------------------------------------------------------------------------------------------------------------------------");
            builder.Append(Environment.NewLine);

            if (!studentCourses.Any())
            {
                builder.Append("Student is not enrolled in any courses!");
            }

            Output_TextBox.Text = builder.ToString();
        }
    }

    
}
