using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class SearchAlgos
    {
        public static int LinearSearch(int[] searchArray, int valueToSearch)
        {
            int i = 0;

            while (i < searchArray.Length && searchArray[i] != valueToSearch)
            {
                i++;
            }

            return i == searchArray.Length ? -1 : i;
        }

        public static int BinarySearch(int[] searchArray, int valueToSearch)
        {
            SortAlgos.InsertionSort(searchArray); // requires a sorted array

            int leftIndex = 0;
            int rightIndex = searchArray.Length - 1;
            int middleIndex = (rightIndex + leftIndex) / 2;

            while (searchArray[middleIndex] != valueToSearch)
            {
                if (rightIndex - leftIndex == 1)
                {
                    if (searchArray[rightIndex] == valueToSearch)
                    {
                        return rightIndex;
                    }
                    else if (searchArray[leftIndex] == valueToSearch)
                    {
                        return leftIndex;
                    }
                    else
                    {
                        return -1;
                    }
                }
                else if (searchArray[middleIndex] > valueToSearch)
                {
                    rightIndex = middleIndex;
                }
                else
                {
                    leftIndex = middleIndex;
                }

                middleIndex = (rightIndex + leftIndex) / 2;
            }

            return middleIndex;
        }
    }
}
