using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{
    public class program5
    {
        public static void Main()
        {
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int i, n;
            Console.Write("\n\nCopy the elements from one array into another array:\n");
            Console.Write("------------------------------------------------------\n");
            Console.Write("Input the number of elements to be stored in the array: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input {0} elements in the array:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.Write("\nThe elements stored in the first array are:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\nThe elements copied into the second array are:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }

            Console.Write("\n\n");
        }
    }

}


