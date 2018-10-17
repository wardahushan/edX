using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            Student ross =  new Student("Ross");
            Student chandler = new Student("Chandler");
            Student joey = new Student("Joey");

            ross.AddGrade(100); ross.AddGrade(80); ross.AddGrade(95); ross.AddGrade(99); ross.AddGrade(75);
            joey.AddGrade(10); joey.AddGrade(50); joey.AddGrade(43); joey.AddGrade(30); joey.AddGrade(21);
            chandler.AddGrade(56); chandler.AddGrade(80); chandler.AddGrade(91); chandler.AddGrade(65); chandler.AddGrade(80);

            students.Add(ross); students.Add(chandler); students.Add(joey);

            foreach (Student student in students)
            {
                Console.Write($"{student.Name}: ");

                foreach (double grade in student.GetGrades())
                {
                    Console.Write($"{grade} ");
                }

                Console.WriteLine("\n");
            }
        }
    }
}

