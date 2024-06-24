using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program7
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string reversedWord = ReverseString(word);
            Console.WriteLine($"Reverse of the word '{word}' is: {reversedWord}");
        }
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
