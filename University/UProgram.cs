using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class UProgram
    {
        private string programmeName;

        private List<Degree> degrees = new List<Degree>();

        private List<Course> courses = new List<Course>();

        public string ProgramName
        {
            get
            {
                return programmeName;
            }
            private set
            {
                if (value == null)
                {
                    Console.WriteLine("Enter name of the program: ");
                    programmeName = Console.ReadLine();
                }
            }
        }

        public List<Degree> Degrees
        {
            get
            {
                return degrees;
            }
            set
            {
                value = degrees;
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
                value = courses;
            }
        }


        public UProgram()
        {
            this.ProgramName = programmeName;

            AddDegreeToProgram(degrees);
            AddCoursesToProgram(courses);

            this.Degrees = degrees;
            this.Courses = courses;
        }

        private static void AddDegreeToProgram(List<Degree> degrees)
        {
            Console.WriteLine("Enter degree name. To Quit press N.");
            string degreeOrQuit = Console.ReadLine();

            while (degreeOrQuit.ToUpper() != "N")
            {
                Degree degree = new Degree(degreeOrQuit);   
                degrees.Add(degree);

                Console.WriteLine("Enter degree name. To Quit press N.");
                degreeOrQuit = Console.ReadLine();
            }
        }

        public static void AddCoursesToProgram(List<Course> courses)
        {
            Console.WriteLine("Press Y to enter details for a new course.");
            string courseOrQuit = Console.ReadLine();

            while (courseOrQuit.ToUpper() == "Y")
            {
                Course Course = new Course();
                courses.Add(Course);

                Console.WriteLine($"Press Y to enter a new course.");
                courseOrQuit = Console.ReadLine();
            }
        }

    }
}
