using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();


            int length = word.Length;
            Console.WriteLine($"Length of the word '{word}' is: {length}");
        }
    }
}