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

            BubbleSortArray(array);

            //Custom class example

            var students = new List<Student>
            {
                new Student { Name = "Alice", Age = 21 },
                new Student { Name = "Bob", Age = 19 },
                new Student { Name = "Charlie", Age = 23 }
            };

            BubbleSortStudentsByAge(students);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Age}");
            }

            Console.ReadLine();
        }

        static void BubbleSortStudentsByAge(List<Student> students)
        {
            int n = students.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (students[j].Age > students[j + 1].Age)
                    {
                        // Swap students
                        var temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }
        }

        static void BubbleSortArray(int[] array)
        {
            bool swapped;
            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                swapped = false;

                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
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
        }
    }
}
