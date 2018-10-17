using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise some students(using user input from the console)
            Student myStudent1 = new Student
            {
                Address = "22 Domplein"
            };

            Student myStudent2 = new Student(); // This student has no address

            Student myStudent3 = new Student
            {
                Address = "Cape Town" // This student's address has been updated
            };

            myStudent3.Address = "Hyde Park";

            Student myStudent4 = new Student
            {
                Address = "Bellville"
            };

            // Initialise University Program with degrees (using user input from console): 
            UProgram UniversityProgram = new UProgram();

            // Add Courses to the degrees 
            foreach (Degree degree in UniversityProgram.Degrees)
            {
                degree.AddCourses(UniversityProgram.Courses);
            }

            // Create list of students for each course:
            List<Student> mphilOnlyStudents = new List<Student>
            {
                myStudent1,
                myStudent2,
                myStudent4
            };

            List<Student> frmOnlyStudents = new List<Student>
            {
                myStudent3
            };


            foreach (Degree degree in UniversityProgram.Degrees)
            {
                if (degree.DegreeName == "FRM")
                {
                    foreach (Course course in degree.Courses)
                    {
                        course.AddStudents(frmOnlyStudents);
                    }
                }
                else if (degree.DegreeName == "MPHIL")
                {
                    foreach (Course course in degree.Courses)
                    {
                        course.AddStudents(mphilOnlyStudents);
                    }
                }

            }

            // Initialise some teachers (based on the constructor)
            Teacher david = new Teacher("Prof David Taylor", "AIFRM");
            Teacher tom = new Teacher("Prof Tom McWalter", "UJ");
            Teacher obeid = new Teacher("Mr Obeid Mahomed", "Standard Bank");
            Teacher ralph = new Teacher("Dr Ralph Rudd", "AIFRM");
            Teacher copierre = new Teacher("Dr Co-Pierre George", "Finance");
            Teacher natasha = new Teacher("Ms Natasha Gray", "Old Mutual");

            // Add the teachers to each course
            foreach (Course course in UniversityProgram.Courses)
            {
                switch (course.CourseName)
                {
                    case "SC":
                        course.AddTeachers(david);
                        break;
                    case "IFD":
                        course.AddTeachers(david);
                        course.AddTeachers(obeid);
                        break;
                    case "NMF":
                        course.AddTeachers(tom);
                        course.AddTeachers(ralph);
                        break;
                    case "RMD":
                        course.AddTeachers(obeid);
                        break;
                    case "SAFM":
                        course.AddTeachers(natasha);
                        break;
                    case "DISS":
                        course.AddTeachers(david);
                        break;
                    case "PROJECT":
                        course.AddTeachers(copierre);
                        break;
                    default:
                        break;
                }
            }


            // Now print the entrire structure
            Console.Clear();

            Console.WriteLine("Printing University Structure Details: ..... \n");

            Console.WriteLine($"Name of program: {UniversityProgram.ProgramName}\n");

            Console.WriteLine($"Degrees and courses available in program:");
            Console.WriteLine($"\n");

            int counter = 1;
            foreach (Degree degree in UniversityProgram.Degrees)
            {
                Console.WriteLine($"{counter}. {degree.DegreeName}");

                char enumerator = 'a';
                foreach (Course course in degree.Courses)
                {
                    Console.WriteLine($"({enumerator.ToString()}) {course.CourseName}; {course.CourseCredits} credits");
                    enumerator++;                        
                }
                counter++; 
            }

            Console.WriteLine($"\nPrinting course students and teachers:");
            foreach (Course course in UniversityProgram.Courses)
            {
                Console.WriteLine($"\nCourse name: {course.CourseName}");

                Console.WriteLine($"Course contains students:");
                foreach (Student student in course.Students)
                {
                    Console.WriteLine($"-- {student.FullName}");
                }

                Console.WriteLine($"Course contains teachers:");
                foreach (Teacher teacher in course.Teachers)
                {
                    Console.WriteLine($"-- {teacher.FullName}");
                }
            }
        }
    }
}