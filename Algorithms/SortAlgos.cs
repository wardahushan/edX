using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    static class SortAlgos
    {
        public static void BubbleSort(int[] numbersToSort)
        {
            bool swapped = false;
            int n = numbersToSort.Length;
                
            while (swapped == false)
            {
                for (int i = 1; i < n; i++)
                {
                    if (numbersToSort[i] < numbersToSort[i - 1])
                    {
                        int temp = numbersToSort[i];
                        numbersToSort[i] = numbersToSort[i - 1];
                        numbersToSort[i - 1] = temp;
                        swapped = true;
                    }
                }

                swapped = !swapped;
            }
        }

        public static void InsertionSort(int[] numbersToSort)
        {
            int n = numbersToSort.Length;

            for (int i = 1; i < n; i++)
            {
                int numberToSort = numbersToSort[i];
                int j = i;

                while (j > 0 && numbersToSort[j - 1] > numberToSort)
                {
                    numbersToSort[j] = numbersToSort[j - 1];
                    j--;
                }

                numbersToSort[j] = numberToSort;
            }
        }

        public static void SelectionSort(int[] numbersToSort)
        {
            int n = numbersToSort.Length;

            for (int i = 0; i < n; i++)
            {
                int minValue = numbersToSort[i];
                int minIndex = i;

                for (int j = i+1; j < n; j++)
                {
                    if (numbersToSort[j] < minValue)
                    {
                        minValue = numbersToSort[j];
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                {
                    numbersToSort[minIndex] = numbersToSort[i];
                    numbersToSort[i] = minValue;
                }
            }
        }
    }
}
