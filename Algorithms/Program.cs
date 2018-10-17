using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 8, 7, 6, 2, 1, 5};

            int index = SearchAlgos.BinarySearch(numbers, -1);
        }
    }
}
