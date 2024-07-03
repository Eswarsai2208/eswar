using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cc3
{
    public class Box
    {
        public double Length { get; set; }
        public double Breath { get; set; }
        public Box(double lenght, double breath)
        {
            Length = lenght;
            Breath = breath;
        }
        public static Box Add(Box box1, Box box2)
        {
            double combinedLength = box1.Length + box2.Length;
            double combinedBreath = box1.Breath + box2.Breath;
            return new Box(combinedLength, combinedBreath);
        }
        public void Display()
        {
            Console.WriteLine($"Box Dimension - Length: {Length}, Breath: {Breath}");
        }
        public class box
        {
            public static void Main()
            {
                Box box1 = new Box(2.0, 2.0);
                Box box2 = new Box(4.0, 8.0);
                Box box3 = Box.Add(box1, box2);
                Console.WriteLine("Dimension of Box 1:");
                box1.Display();
                Console.WriteLine("Dimension of Box 2:");
                box2.Display();
                Console.WriteLine("Dimension of Box 3:");
                box3.Display();
                Console.Read();
            }
        }
    }
}
