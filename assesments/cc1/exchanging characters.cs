using System;
using System.Collections.Generic;

namespace exchanging_characters
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchange First and Last character in a given string");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(First_Last("Eswarsai"));
            Console.WriteLine(First_Last("V"));
            Console.WriteLine(First_Last("iswarsaE"));
        }
        public static string First_Last(string ustr)
        {
            return ustr.Length > 1
               ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
               : ustr;
        }
    }
}
