using System;

namespace ShapeSpace
{
    public interface IPaintable
    {
        void Paint(string color);
    }

    public abstract class Shape : IPaintable
    {
        public abstract void Paint(string color);

        public abstract void CalculateArea();
    }
}