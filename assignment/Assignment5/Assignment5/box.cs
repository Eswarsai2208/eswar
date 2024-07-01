using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
public class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }
        public static Box Add(Box box1, Box box2)
        {
            double combinedLength = box1.Length + box2.Length;
            double combinedBreadth = box1.Breadth + box2.Breadth;
            return new Box(combinedLength, combinedBreadth);
        }
        public void Display()
        {
            Console.WriteLine($"Box Dimensions - Length: {Length}, Breadth: {Breadth}");
        }
    }
    public class box
    {
        public static void Main()
        { 
            Box box1 = new Box(10.0, 15.0);
            Box box2 = new Box(12.0, 24.0);
            Box box3 = Box.Add(box1, box2);
            Console.WriteLine("Dimensions of Box 1:");
            box1.Display();
            Console.WriteLine("\nDimensions of Box 2:");
            box2.Display();
            Console.WriteLine("\nDimensions of Box 3 (Result of addition):");
            box3.Display();
            Console.Read();
        }
    }
}
