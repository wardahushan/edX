using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    internal class HelperFunctions
    {
        internal static double GetAverage(int[] numbers)
        {
            return (double)numbers.Sum() / numbers.Count();
        }

        internal static int KthSmallest(int[] numbers, int k)
        {
            int[] numbersCopy = new int[numbers.Length];
            numbers.CopyTo(numbersCopy, 0);

            return numbersCopy.AsEnumerable().OrderBy(x => x).Distinct().ElementAt(k-1); 
        }

        internal static string ReverseString(string stringToReverse)
        {
            string reversedString = string.Empty;

            for (int i = stringToReverse.Length-1 ; i >= 0; i--)
            {
                reversedString += stringToReverse[i];
            }

            return reversedString;
        }



    }
}
