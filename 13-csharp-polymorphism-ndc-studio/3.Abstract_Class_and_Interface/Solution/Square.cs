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

        public override string CalculateArea()
        {
            return $"The size of the area's square is : {Side * Side}\n";
        }

        public override string Paint(string color)
        {
            return $"The square has been painted in {color}";
        }
    }
}