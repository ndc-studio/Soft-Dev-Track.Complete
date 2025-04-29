using System;
using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace Selection
{
    public class Solution
    {
        public static string UserInput()
        {
            return Console.ReadLine();
        }

        public static int GetValidatedAge(string str)
        {
            try
            {
                int parseNbr = int.Parse(str);
                if (parseNbr > 119)
                {
                    throw new FormatException("Invalid Age");
                }
                return parseNbr;
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Age");
            }
        }

        public static string CanEnterInTheCasino()
        {
            while (true)
            {
                string input = UserInput();
                try
                {
                    int userInput = GetValidatedAge(input);

                    if (userInput >= 18)
                    {
                        return "You can enter! Be welcome!";
                    }
                    else
                    {
                        return "Sorry, you can't enter! Be patient!";
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"SCRIPT_ERROR: {ex.Message}");
                    Console.WriteLine("Please enter a valid number:");
                }
            }
        }

        // 1ST VERSION OF SWITCH METHOD

        //       public static string SignOfNumber(int nbr)
        //       {
        //           switch (nbr)
        //           {
        //               case int n when n > 0:
        //                   return "The number is positive.";
        //               case int n when n < 0:
        //                   return "The number is negative.";
        //               case 0:
        //                   return "The number is zero.";
        //               default:
        //                   return "Unknown.";
        //            }
        //        }

        // BUT I FIND THAT (switch expression)   ^^

        public static string SignOfNumber(int nbr)
        {
            return nbr switch
            {
                > 0 => "The number is positive.",
                < 0 => "The number is negative.",
                0 => "The number is zero."
            };
        }

        public static double DiscountPriceCalculator(int discountMode, double price)
        {


            if (discountMode >= 1 && discountMode <= 3)
            {
                return discountMode switch
                {
                    1 => price - (price * 0.1), // Student
                    2 => price - (price * 0.05), // Member
                    3 => price - (price * 0.2) // Sale products
                };
            }
            else
            {
                throw new ArgumentException("Invalid choice. Please enter a number between 1 and 3.");
            }
        }

        public static string TriangleClassification(int c1, int c2, int c3)
        {
            if (c1 == c2 && c2 == c3)
            {
                return "The triangle is equilateral.";
            }
            else if (c1 == c2 || c2 == c3 || c1 == c3)
            {
                return "The triangle is isosceles.";
            }
            else
            {
                return "The triangle is scalene.";
            }
        }
    }
}
