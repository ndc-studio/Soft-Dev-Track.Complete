using System;

namespace GenericSpace
{
    public class Box<T>
    {
        public T? Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public string DisplayValue()
        {
            return $"{Value}";
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}