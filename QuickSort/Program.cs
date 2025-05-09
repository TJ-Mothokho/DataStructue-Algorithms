using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 7, 8, 9, 1, 5 };
            QuickSort(array, 0, array.Length - 1);

            Console.WriteLine("Sorted array: " + string.Join(", ", array));
            Console.ReadLine();
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(array, low, high);

                // Recursively sort elements before and after partition
                QuickSort(array, low, pivotIndex - 1);   // Left side
                QuickSort(array, pivotIndex + 1, high);  // Right side
            }
        }

        static int Partition(int[] array, int low, int high)
         {
            int pivot = array[high]; // Choose the last element as pivot
            int i = low - 1;         // Index of smaller element

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    // Swap array[i] and array[j]
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Swap the pivot element with the element at i+1
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1; // Return the pivot index
        }
    }
}
