using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2 
{
   public class Student
    {
        private int rollNo;
        private string name;
        private string className;
        private int semester;
        private string branch;
        private int[] marks = new int[5];
        public Student(int roll, string stuName, string clsName, int sem, string br)
        {
            rollNo = roll;
            name = stuName;
            className = clsName;
            semester = sem;
            branch = br;
        }
        public void GetMarks()
        {
            Console.WriteLine($"Enter marks for student {name} (Roll No: {rollNo}):");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Enter marks for Subject {i + 1}: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void DisplayResult()
        {
            double average = CalculateAverage();

            Console.WriteLine($"\nStudent Name: {name}");
            Console.WriteLine($"Roll Number: {rollNo}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
            Console.WriteLine("\nMarks:");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Subject {i + 1}: {marks[i]}");
            }
            Console.WriteLine($"\nAverage Marks: {average}");
            if (marks.Any(m => m < 35))
            {
                Console.WriteLine("Result: Failed (Marks of at least one subject is less than 35)");
            }
            else if (average < 50)
            {
                Console.WriteLine("Result: Failed (Average marks is less than 50)");
            }
            else
            {
                Console.WriteLine("Result: Passed");
            }
        }
        private double CalculateAverage()
        {
            if (marks.Length == 0)
                return 0;

            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }
        public void DisplayData()
        {
            Console.WriteLine($"\nStudent Name: {name}");
            Console.WriteLine($"Roll Number: {rollNo}");
            Console.WriteLine($"Class: {className}");
            Console.WriteLine($"Semester: {semester}");
            Console.WriteLine($"Branch: {branch}");
        }
    }
    class MainProgram
    {
        static void Main()
        {
            Student student = new Student(1035498, "leo", "12th", 1st, "Biology");
            student.GetMarks();
            student.DisplayData();
            student.DisplayResult();
            Console.Read();
        }
    }
}

