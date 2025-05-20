using System;

namespace TwoDimension
{
    public readonly struct Rectangle
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public string CalculateArea()
        {
            double area = Width * Height;
            return $"The area's rectangle is : {area}";
        }
    }
}