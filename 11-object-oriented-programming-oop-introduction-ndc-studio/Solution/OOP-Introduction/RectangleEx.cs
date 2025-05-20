namespace OOP_Introduction
{
    public class RectangleEx
    {
        public double _length;
        public double _width;

        public double Length
        {
            get => _length;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Length cannot be zero or negative.");
                }
                _length = value;
            }
        }

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Width cannot be zero or negative.");
                }
                _width = value;
            }
        }

        public RectangleEx() {}

        public RectangleEx(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return this.Length * this.Width;
        }
    }
}
