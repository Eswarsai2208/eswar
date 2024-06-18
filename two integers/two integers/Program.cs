using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_integers
{
    public class Program
    {
        public static void Main()
        {
            int x, y;
            Console.Write("\n\n");
            Console.Write("check whether two integers are equal or not\n");
            Console.Write("-------------------------------------------");
            Console.Write("\n\n");
            Console.Write("enter the value of x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the value of y:");
            y = Convert.ToInt32(Console.ReadLine());
            if (x == y)
                Console.WriteLine("{0} and {1} are equal.\n", x, y);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", x, y);


        }
    }
}
