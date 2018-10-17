using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructExercise();
            //AverageExercise();
            //ReverseStringExercise();
            //KthSmallestExercise();
            //LargestDifference();
            //NestedParanthesesExercise();
        }

        private static void NestedParanthesesExercise()
        {
            StringCollection strings = new StringCollection();
            strings.Add("a(())b()");
            strings.Add("(()1()");
            strings.Add("((a(b))c)");
            strings.Add(")a(a(p))(");

            foreach (string stringWithParantheses in strings)
            {
                if (stringWithParantheses.Where(x => x == '(').Count() == stringWithParantheses.Where(x => x == ')').Count())
                {
                    int nestedCount = 0;

                    foreach (char character in stringWithParantheses)
                    {
                        if (character == ')')
                        {
                            Console.WriteLine(nestedCount);
                            break;
                        }
                        else if (character == '(')
                        {
                            nestedCount++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }

        private static void ReverseStringExercise()
        {
            StringCollection strings = new StringCollection();
            strings.Add("abcad");
            strings.Add("a0b c1d");

            foreach (string stringToReverse in strings)
            {
                Console.WriteLine(
                    stringToReverse[0].ToString() + 
                    HelperFunctions.ReverseString(stringToReverse.Substring(1, stringToReverse.Length -2)) +
                    stringToReverse[stringToReverse.Length - 1].ToString());  
            }
        }

        private static void LargestDifference()
        {
            int[][] numbers = new int[2][];
            numbers[0] = new int[] { 3, 2, 9, 5 };
            numbers[1] = new int[] { 1, 1, 1, 1 };

            foreach (int[] array in numbers)
            {
                double maxDifference = double.NegativeInfinity;
                for (int i = 1; i < array.Length; i++)
                {
                    maxDifference = Math.Max(maxDifference, array[i] - array[i - 1]);
                }

                Console.WriteLine("Largest differences : " + maxDifference);
            }
        }

        private static void KthSmallestExercise()
        {
            int[][] numbers = new int[2][];
            numbers[0] = new int[] { 2, 1, 4 };
            numbers[1] = new int[] { 7, 2, 1, 6, 1 };

            foreach (int[] array in numbers)
            {
                Console.WriteLine(HelperFunctions.KthSmallest(array, 3));
            }
        }

        private static void AverageExercise()
        {
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 3, 1, 1 };
            numbers[1] = new int[] { -3, 2 };
            numbers[2] = new int[] { -2, 4, -1, 6 };

            foreach (int[] array in numbers)
            {
                double average = HelperFunctions.GetAverage(array);
                double averageRounded = Math.Round(average);
                double decimalPortion = Math.Round(Math.Abs( - average), 2);

                double solution = decimalPortion == 0.5 ?
                    averageRounded % 2 == 0 ? averageRounded : averageRounded - 1
                    : averageRounded;

                Console.WriteLine("Solution : " + solution);
            }
        }

        private static void StructExercise()
        {
            Student[] students = new Student[6];
            StringCollection studentNames = new StringCollection { "Joey", "Chandler", "Monica", "Rachel", "Ross", "Phoebe" };

            Random random = new Random();
            int counter = 0;

            foreach (string name in studentNames)
            {
                students[counter] = new Student(name, random.Next(20, 30));
                counter++;
            }

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name}, Age: {student.Age}");
            }
        }
    }
}
