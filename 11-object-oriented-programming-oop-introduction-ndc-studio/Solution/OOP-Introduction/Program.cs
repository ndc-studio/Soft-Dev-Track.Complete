using System.Security.Cryptography.X509Certificates;

namespace OOP_Introduction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Test for the 1st exercise */
            var book = new Book("John Doe", "How to learn C#", 100);
            Console.WriteLine($"{book.Display()}\n ");

            /* Test for the 2nd exercise */
            var john = new Person("John", 23);
            var hector = new Person("Hector", 12);
            Console.WriteLine(john.Display());
            Console.WriteLine($"Is adult: {john.IsAdult()}\n");

            Console.WriteLine(hector.Display());
            Console.WriteLine($"Is adult: {hector.IsAdult()}\n");

            /* Test for the 3rd exercise */
            var rectangle = new RectangleEx(4d, 2d);
            Console.WriteLine($"{rectangle.CalculateArea()}\n");

            /* Exiting the terminal */
            Console.WriteLine("Press any key for exiting!");
            Console.ReadKey();
        }
    }
}
