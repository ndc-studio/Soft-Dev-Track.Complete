using System;

namespace GenericSpace
{
    public interface IHasName
    {
        public string Name { get; set; }
    }

    public class Greeter<T> where T : IHasName
    {
        public void Greet(T person)
        {
            Console.WriteLine($"Hello {person.Name}");
        }
    }

    public class Person : IHasName
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}