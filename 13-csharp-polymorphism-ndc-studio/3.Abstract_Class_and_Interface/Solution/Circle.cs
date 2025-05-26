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

        public override string CalculateArea()
        {
            return $"The size of the area's circle is : {Math.PI * (Radius * Radius)}\n";
        }

        public override string Paint(string color)
        {
            return $"The circle has been painted in {color}";
        }
    }
}