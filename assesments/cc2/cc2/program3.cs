using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc2
{
    class program3
    {
        static void ProcessNumber(int num)
        {
            if (num < 0)
            {
                throw new ArgumentException("Entered Number is Negative.");
            }
            Console.WriteLine("Number  is valid and can be processed.");
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                ProcessNumber(inputNumber);
                Console.WriteLine("Entered Number is Positive.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not in a valid format.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error: {e.Message}");
            }
            Console.Read();
        }
    }

}

