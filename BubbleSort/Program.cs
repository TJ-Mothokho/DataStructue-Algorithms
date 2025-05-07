using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90, 5 };

            bool swapped;
            int count = 0;

            for(int i = 0; i < array.Length-1; i++)
            {
                swapped = false;
                
                for(int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j+1];
                        array[j+1] = array[j];
                        array[j] = temp;

                        swapped = true;
                    }
                }

                count++;

                if (!swapped)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", array));

            Console.ReadLine();
        }
    }
}
