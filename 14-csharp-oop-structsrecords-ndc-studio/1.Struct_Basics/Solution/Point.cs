using System;

namespace TwoDimension
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point point)
        {
            int distanceX = X - point.X;
            int distanceY = Y - point.Y;
            return Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
        }
    }

    public record Shape(Point Center, double Radius);
}