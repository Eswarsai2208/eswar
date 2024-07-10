using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc4
{
    class Program
    {
        public delegate int calculatedelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App \n");
            calculatedelegate addition = Add;
            calculatedelegate subtraction = Subtract;
            calculatedelegate multiplication = Multiply;
            calculatedelegate division = Division;
            PerformOperation(addition, "Addition", 5, 5);
            PerformOperation(subtraction, "Subtraction", 20, 10);
            PerformOperation(multiplication, "Multiplication", 10, 1);
            PerformOperation(division, "Division", 50, 5);
            Console.ReadKey();
        }
        static void PerformOperation(calculatedelegate operation, string operationName, int a, int b)
        {
            int result = operation(a, b);
            Console.WriteLine($"{operationName} of {a} and {b} is: {result}");
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static int Division(int a, int b)
        {
            return a / b;
        }
    }
}

