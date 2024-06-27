using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class Scholarship
    {
        public decimal Merit(int marks, decimal fees)
        {
            decimal scholarshipAmount = 0;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.2m * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.3m * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.5m * fees;
            }

            return scholarshipAmount;
        }
    }
    class Program4
    {
        static void Main()
        {
            Scholarship scholarshipCalculator = new Scholarship();
            int marks1 = 77;
            decimal fees1 = 10000;
            decimal scholarshipAmount1 = scholarshipCalculator.Merit(marks1, fees1);
            Console.WriteLine($"Scholarship amount for marks {marks1}: {scholarshipAmount1}");
            int marks2 = 88;
            decimal fees2 = 12000;
            decimal scholarshipAmount2 = scholarshipCalculator.Merit(marks2, fees2);
            Console.WriteLine($"Scholarship amount for marks {marks2}: {scholarshipAmount2}");
            int marks3 = 99;
            decimal fees3 = 15000;
            decimal scholarshipAmount3 = scholarshipCalculator.Merit(marks3, fees3);
            Console.WriteLine($"Scholarship amount for marks {marks3}: {scholarshipAmount3}");
            int marks4 = 66;
            decimal fees4 = 8000;
            decimal scholarshipAmount4 = scholarshipCalculator.Merit(marks4, fees4);
            Console.WriteLine($"Scholarship amount for marks {marks4}: {scholarshipAmount4}");
            Console.Read();
        }
    }

}
