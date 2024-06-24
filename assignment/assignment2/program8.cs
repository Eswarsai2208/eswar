using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            bool areSame = string.Equals(word1, word2, StringComparison.OrdinalIgnoreCase);

            if (areSame)
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
            }
            else
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are different.");
            }
        }
    }


}

