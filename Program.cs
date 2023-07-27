using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_Assignment_17
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(8);
            Rectangle rectangle = new Rectangle(9, 6);
            Triangle triangle = new Triangle(3, 5, 7);

            Console.WriteLine("Circle Info:");
            circle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Rectangle Info:");
            rectangle.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Triangle Info:");
            triangle.PrintInfo();
            Console.ReadKey();
        }
    }
}

