using System;
using System.Diagnostics;

namespace TwoDimension
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Test DistanceTo
            Point point1 = new Point(9, 9);
            Point point2 = new Point(1, 1);
            Console.WriteLine($"Distance: {point1.DistanceTo(point2)}");

            // Test value-type behavior of Point (struct)
            Point point3 = point1;
            point3.X = 100;

            Console.WriteLine(
                $"\npoint1.X = {point1.X}" +
                $"\npoint3.X = {point3.X}"
            );

            // Test Rectangle (immutable struct with Area method)
            var rectangle = new Rectangle(5, 3);
            Console.WriteLine(rectangle.CalculateArea());

            // Test Person (record with value-based equality)
            var person1 = new Person("Alice", 30);
            var person2 = new Person("Alice", 30);

            Console.WriteLine("\nThe comparison value-based equality is: ");
            Console.WriteLine(person1 == person2);

            // Test Shape (record with a Point struct inside)

            Console.WriteLine("\nThe comparison shapes is: ");
            var shape1 = new Shape(new Point(0, 0), 5);
            var shape2 = new Shape(new Point(0, 0), 5);
            Console.WriteLine(shape1 == shape2); // true

            // Time struct
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Point[] pointsStruct = new Point[1000000];

            for (int i = 0; i < pointsStruct.Length; i++)
            {
                pointsStruct[i] = new Point(i, i);
            }

            stopwatch.Stop();
            Console.WriteLine($"\nTime of struct : {stopwatch.ElapsedMilliseconds} ms");

            // Time record
            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            PointClass[] pointsClass = new PointClass[1000000];

            for (int i = 0; i < pointsClass.Length; i++)
            {
               
                pointsClass[i] = new PointClass(i, i);

            }

            stopwatch1.Stop();
            Console.WriteLine($"Time of class : {stopwatch1.ElapsedMilliseconds} ms");

            // Test record comparison

            var employee = new Employee("Alice", 30, "Dev");
            Console.WriteLine("\nThe comparison between employee Alice and Person Alice is:");
            Console.WriteLine(person1 == employee);

            Console.WriteLine("\n[ QUIT ]\nPress any key to exit the terminal.");
            Console.ReadKey();
        }
    }
}
