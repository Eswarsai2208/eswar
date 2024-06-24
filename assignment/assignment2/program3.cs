using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3

{
    class program3
    {
        static void Main()
        {
            int[] marks = new int[10];
            Console.WriteLine("Enter ten marks:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter mark {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = CalculateTotal(marks);
            double average = CalculateAverage(marks);
            int minMarks = FindMinimum(marks);
            int maxMarks = FindMaximum(marks);
            Console.WriteLine($"\nTotal marks: {total}");
            Console.WriteLine($"Average marks: {average:F2}");
            Console.WriteLine($"Minimum marks: {minMarks}");
            Console.WriteLine($"Maximum marks: {maxMarks}");
            Console.WriteLine("\nMarks in ascending order:");
            int[] ascendingMarks = SortAscending(marks);
            PrintArray(ascendingMarks);
            Console.WriteLine("\nMarks in descending order:");
            int[] descendingMarks = SortDescending(marks);
            PrintArray(descendingMarks);
        }
        static int CalculateTotal(int[] marks)
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return total;
        }
        static double CalculateAverage(int[] marks)
        {
            return (double)CalculateTotal(marks) / marks.Length;
        }
        static int FindMinimum(int[] marks)
        {
            int min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }
            return min;
        }
        static int FindMaximum(int[] marks)
        {
            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
            }
            return max;
        }
        static int[] SortAscending(int[] marks)
        {
            int[] sortedMarks = new int[marks.Length];
            Array.Copy(marks, sortedMarks, marks.Length);
            Array.Sort(sortedMarks);
            return sortedMarks;
        }
        static int[] SortDescending(int[] marks)
        {
            int[] sortedMarks = new int[marks.Length];
            Array.Copy(marks, sortedMarks, marks.Length);
            Array.Sort(sortedMarks);
            Array.Reverse(sortedMarks);
            return sortedMarks;
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }

}
