using System;

namespace ShapeSpace
{
    public class Program
    {
        public static List<Shape> ShapeList = [];

        public static void Main(string[] args)
        {

            string colorCircle = "blue";
            string colorSquare = "red";

            // Create Shapes
            Circle circle = new Circle(2);
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(9);
            Square square = new Square(2);
            Square square1 = new Square(5);
            Square square2 = new Square(9);

            // Add shapes into the ShapeList
            ShapeList.Add(circle);
            ShapeList.Add(circle1);
            ShapeList.Add(circle2);
            ShapeList.Add(square);
            ShapeList.Add(square1);
            ShapeList.Add(square2);

            foreach (var shape in ShapeList)
            {
                Console.Write("=============================\n");
                shape.CalculateArea();

                if (shape is Circle)
                {
                    shape.Paint(colorCircle);
                }
                else if (shape is Square)
                {

                    shape.Paint(colorSquare);
                }
                Console.WriteLine("=============================\n");

            }

            Console.WriteLine("\n\nPress any key for exiting the session...!\n");
            Console.ReadKey();
        }
    }
}