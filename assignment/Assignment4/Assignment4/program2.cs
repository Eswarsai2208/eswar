using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class program3
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter the letter to count:");
            char letterToCount = Console.ReadLine()[0]; 

            int count = CountOccurrences(inputString, letterToCount);

            Console.WriteLine($"The letter '{letterToCount}' appears {count} times in the string.");
            Console.Read();
        }
        static int CountOccurrences(string inputString, char letter)
        {
            int count = 0;
            inputString = inputString.ToUpper();
            char upperCaseLetter = char.ToUpper(letter);
            foreach (char c in inputString)
            {
                if (c == upperCaseLetter)
                {
                    count++;
                }
            }

            return count;
        }
    }

}
