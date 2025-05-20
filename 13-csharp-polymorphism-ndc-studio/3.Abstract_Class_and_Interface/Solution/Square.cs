using System;

namespace ShapeSpace
{
    public class Square : Shape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public override void CalculateArea()
        {
            Console.WriteLine($"The size of the area's square is : {Side * Side}\n");
        }

        public override void Paint(string color)
        {
            Console.WriteLine($"The square has been painted in {color}");
        }
    }
}