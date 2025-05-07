using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90, 5 };

            InsertionSort(array);

            Console.ReadLine();
        }

        static void InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int j = i - 1;
                int current = array[i];

                // Shift elements greater than current to the right
                while (j >= 0 && array[j] > current)
                {

                    array[j + 1] = array[j];

                    j--;
                }

                // Place current element in its correct position
                array[j + 1] = current;
            }
            
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
