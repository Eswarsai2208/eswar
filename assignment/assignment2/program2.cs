using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    public class maxmin
    {
        public static void Main()
        {
            int[] arr1 = new int[100];
            int i, Max, Min, n;

            Console.Write("\n\nFind maximum and minimum element in an array :\n");
            Console.Write("--------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Max = arr1[0];
            Min = arr1[0];
            for (i = 1; i < n; i++)
            {
                if (arr1[i] > Max)
                {
                    Max = arr1[i];
                }

                if (arr1[i] < Min)
                {
                    Min = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", Max);
            Console.Write("Minimum element is : {0}\n\n", Min);
        }
    }

}