using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_7_Assignment_17
{
    // Derived class representing a circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base("Circle")
        {
            Radius = radius;
        }

        public override double Area => Math.PI * Radius * Radius;

        public override double Perimeter => 2 * Math.PI * Radius;
    }

}



