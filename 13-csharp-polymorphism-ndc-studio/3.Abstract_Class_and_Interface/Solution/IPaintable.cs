using System;

namespace ShapeSpace
{
    public interface IPaintable
    {
        string Paint(string color);
    }

    public abstract class Shape : IPaintable
    {
        public abstract string Paint(string color);

        public abstract string CalculateArea();
    }
}