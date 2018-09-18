using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simpson_Assign1;

namespace Assignment2
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Course> courses = InitializeCourses();
            List<Student> students = InitializeStudents();
            List<string> majors = InitializeMajors();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        #region InitializeCourses
        //loads a list of course objects from the input file ordered by department code then course number
        private static List<Course> InitializeCourses()
        {
            var sortedCourses = new List<Course>();
            // check opening file successfully
            try
            {
                var courses = new List<Course>();
                var file = File.ReadAllLines("Courses.txt");
                foreach (var line in file)
                {
                    var fields = line.Split(',');
                    var course = new Course(fields[0], Convert.ToUInt32(fields[1]), fields[2], Convert.ToUInt16(fields[3]), Convert.ToUInt16(fields[4]));
                    courses.Add(course);
                }
                sortedCourses = courses.OrderBy(x => x.DepartmentCode)
                    .ThenBy(x => x.CourseNumber)
                    .ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Can't read Courses.txt file.");
            }

            return sortedCourses;
        }
        #endregion
        #region InitializeStudents
        //loads a list of student objects from the input file ordered by zID
        private static List<Student> InitializeStudents()
        {
            var sortedStudents = new List<Student>();
            // check opening file successfully
            try
            {
                var students = new List<Student>();
                var file = File.ReadAllLines("Students.txt");
                foreach (var line in file)
                {
                    var fields = line.Split(',');
                    var student = new Student(Convert.ToUInt32(fields[0]), fields[1], fields[2], fields[3], Convert.ToInt32(fields[4]), float.Parse(fields[5]));
                    students.Add(student);
                }
                sortedStudents = students.OrderBy(x => x.ZId).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Can't read Students.txt file.");
                return null;
            }
            return sortedStudents;
        }
        #endregion
        #region InitializeMajors
        //loads a list of Majors from the input file in alphabetical order
        private static List<string> InitializeMajors()
        {
            var sortedMajors = new List<string>();
            // check opening file successfully
            try
            {
                var majors = new List<string>();
                var file = File.ReadAllLines("Majors.txt");
                foreach (var line in file)
                {
                    majors.Add(line);
                }
                sortedMajors = majors.OrderBy(x => x).ToList();
            }
            catch (Exception)
            {
                Console.WriteLine("Can't read Students.txt file.");
                return null;
            }
            return sortedMajors;
        }
        #endregion
    }
}
