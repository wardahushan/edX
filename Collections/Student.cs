using System.Collections.Generic;

namespace Collections
{
    internal class Student
    {
        private string name;

        private readonly Stack<double> Grades = new Stack<double>();

        public string Name
        {
            get
            { return name; }
        }

        public Student(string name)
        {
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            Grades.Push(grade);
        }

        public Stack<double> GetGrades()
        {
            return Grades;
        }
    }
}