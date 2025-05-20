using System;

namespace GenericSpace
{
    public class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public void DisplayValue()
        {
            Console.WriteLine(Value);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}