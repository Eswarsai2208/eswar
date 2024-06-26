using System;
using System.Collections.Generic;

namespace cc1
{
    public class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exchange First and Last character in a given string");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine(First_Last("Eswarsai"));
            Console.WriteLine(First_Last("V"));
            Console.WriteLine(First_Last("iswarsaE"));
            Console.Read();
        }
        public static string First_Last(string ustr)
        {
            return ustr.Length > 1
               ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
               : ustr;
           
        }
    }
}