using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 2, 1, 2, 2 };

            var list2D = groupSort(array);

            var array2D = ConvertTo2D(list2D);

            PrintArray(array2D);

            Console.ReadLine();
        }

        public static List<List<int>> groupSort(List<int> arr)
        {
            List<List<int>> array = new List<List<int>>();
            bool hasNumber = false;

            foreach (var number in arr)
            {
                int index = 0;
                foreach (var arrayy in array)
                {
                    if (arrayy[0] == number)
                    {
                        int count = array[index][1];
                        count++;
                        array[index][1] = count;
                        hasNumber = true;
                    }
                    index++;
                }
                index = 0;

                if (!hasNumber)
                {
                    array.Add(new List<int> {number, 1 });
                }
                // else
                // {
                //     int num = 
                // }

                hasNumber = false;

            }
            return array;
        }

        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) // rows
            {
                for (int j = 0; j < array.GetLength(1); j++) // columns
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine(); // new line after each row
            }
        }

        static int[,] ConvertTo2D(List<List<int>> list)
        {

            // Get dimensions
            int rows = list.Count;
            int cols = list[0].Count;

            // Initialize 2D array
            int[,] array = new int[rows, cols];

            // Copy values
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = list[i][j];
                }
            }

            return array;

        }
    }
}
