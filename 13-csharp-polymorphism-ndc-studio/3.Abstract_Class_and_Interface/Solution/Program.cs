using System;

namespace ShapeSpace
{
    public class Program
    {
        public static List<Circle> CircleList = [];

        public static List<Square> SquareList = [];

        public static List<Shape> ShapeList = [];

        public static void Main(string[] args)
        {

            string colorCircle = "blue";
            string colorSquare = "red";

            // Ajout a CircleList
            Circle circle = new Circle(2);
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(9);
            CircleList.Add(circle);
            CircleList.Add(circle1);
            CircleList.Add(circle2);

            // Ajout a SquareList
            Square square = new Square(2);
            Square square1 = new Square(5);
            Square square2 = new Square(9);
            SquareList.Add(square);
            SquareList.Add(square1);
            SquareList.Add(square2);

            // Ajout a ShapeList
            ShapeList.Add(circle);
            ShapeList.Add(circle1);
            ShapeList.Add(circle2);
            ShapeList.Add(square);
            ShapeList.Add(square1);
            ShapeList.Add(square2);

            foreach (var shape in ShapeList)
            {
                Console.Write("=============================\n");
                Console.WriteLine(shape.CalculateArea());
                Console.WriteLine("=============================\n");
            }

            foreach (var c in CircleList)
            {
                Console.Write("=============================\n");
                Console.WriteLine(c.Paint(colorCircle));
                Console.WriteLine("=============================\n");
            }

            foreach (var s in SquareList)
            {
                Console.Write("=============================\n");
                Console.WriteLine(s.Paint(colorSquare));
                Console.WriteLine("=============================\n");
            }

            Console.WriteLine("\n\nPress any key for exiting the session...!\n");
            Console.ReadKey();
        }
    }
}