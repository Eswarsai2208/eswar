using System;


namespace cc1
{
    public class Program
    {
        public static void Main(String[] args)
        {
            int i = 0, n = 5, product;
            do
            {
                product = (n * i);
                Console.WriteLine("{0} * {1} = {2}", n, i, product);
                i++;
            }
            while (i <= 10);
            Console.Read();

        }
    }
}