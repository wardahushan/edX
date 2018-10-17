using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Student : Person
    {
        private string fullName; 
        private DateTime studentDOB;
        private static int numberOfStudents;

        public static int GetTotalStudents()
        {
            return numberOfStudents;
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            private set
            {
                if (FullName == null)
                {
                    Console.WriteLine("New student details are being added.\n");
                    Console.WriteLine("Enter student full name:");
                    fullName = Console.ReadLine();
                }
            }
        }

        public DateTime StudentDOB
        {
            get
            {
                return studentDOB;
            }
            private set
            {
                if (StudentDOB == DateTime.MinValue)
                {
                    Console.WriteLine("Enter student DOB in format DD/MM/YYYY:");
                    string studentDOBasString = Console.ReadLine();
                    ValidateStudentBirthday(studentDOBasString);
                    studentDOB = DateTime.Parse(studentDOBasString);
                }
            }
        }

        public Student() : base()
        {
            this.FullName = fullName;
            this.StudentDOB = studentDOB;
            numberOfStudents++;
        }

        public static void PrintStudentDetails(Student student)
        {
            if (student.Address == null)
            {
                Console.WriteLine("{0} {1} was born on {2}. Address has not been provided.", student.FullName, student.studentDOB);
            }
            else
            {
                Console.WriteLine("{0} {1} was born on {2} and lives at {3}.", student.FullName, student.studentDOB, student.Address);
            }
            
        }

        private static void ValidateStudentBirthday(string studentDOBAsBirthday)
        {
            try
            {
                DateTime studentDOB = DateTime.Parse(studentDOBAsBirthday);
                Console.WriteLine("Student details added successfully.\n");
            }
            catch
            {
                throw new InvalidCastException("DOB not entered in correct format.");
            }
        }
    }
}