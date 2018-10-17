using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Course
    {
        private string courseName;

        private int courseCredits;

        private List<Student> students = new List<Student>();

        private List<Teacher> teachers = new List<Teacher>();

        public string CourseName
        {
            get
            {
                return courseName;
            }
            private set
            {
                if (value == null)
                {
                    Console.WriteLine("Enter the course name: ");
                    courseName = Console.ReadLine();
                }
            }
        }

        public int CourseCredits
        {
            get
            {
                return courseCredits;
            }
            private set
            {
                if (value == 0)
                {
                    Console.WriteLine("Enter the course credits: ");
                    courseCredits = Int32.Parse(Console.ReadLine());
                }
            }
        }

        public List<Student> Students
        {
            get
            {
                return students;
            }
            set
            {
                students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
            set
            {
                teachers = value;
            }
        }

        public Course()
        {
            this.CourseName = courseName;
            this.CourseCredits = courseCredits;
        }

        public List<Teacher> AddTeachers(Teacher teachersToAdd)
        {
            teachers.Add(teachersToAdd);
            return teachers;
        }

        public List<Student> AddStudents(List<Student> studentsToAdd)
        {
            foreach (Student student in studentsToAdd)
            {
                students.Add(student);
            }

            return students;
        }
    }
}
