using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_Assignment_17
{
    // Base class representing a shape
    class Shape
    {
        public string ShapeType { get; set; }

        public virtual double Area { get; }
        public virtual double Perimeter { get; }

        public Shape(string shapeType)
        {
            ShapeType = shapeType;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Shape Type: " + ShapeType);
            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Perimeter: " + Perimeter);
        }
    }


}
