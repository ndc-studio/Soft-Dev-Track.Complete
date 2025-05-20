using System.Text.RegularExpressions;

using System;

namespace ShapeSpace
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            double result = Math.Round(Math.PI * Math.Sqrt(Radius), 2);

            Console.WriteLine($"The size of the area's circle is : {result}\n");
        }

        public override void Paint(string color)
        {
            Console.WriteLine($"The circle has been painted in {color}");
        }
    }
}