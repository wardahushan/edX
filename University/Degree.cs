using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Degree
    {
        private string degreeName;

        private List<Course> courses = new List<Course>();

        public string DegreeName
        {
            get
            {
                return degreeName;
            }
            set
            {
                degreeName = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return courses;
            }
            set
            {
                courses = value;
            }
        }

        public Degree(string degreeName)
        {
            this.DegreeName = degreeName;
        }

        public List<Course> AddCourses(List<Course> coursesToAdd)
        {
            foreach (Course course in coursesToAdd)
            {
                Console.WriteLine($"Add course {course.CourseName} to degree {degreeName}?");
                string selection = Console.ReadLine();

                if (selection.ToUpper() == "Y")
                {
                    courses.Add(course);
                }
            }

            return courses;
        }

    }
}
