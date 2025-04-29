using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Iteration
{
    public class Solution
    {

        public static int SumOfNumbers()
        {
            int x = 0;
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(x);
                x = x + i;
            }
            return x;

        }

        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("You must have a positive number");
            }

            int result = 1;
            int i = 1;

            while (i <= n)
            {
                result *= i;
                i++;
            }
            return result;
        }

        public static void ShowMultiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} X {j} = {i * j}");
                }
            }
        }
        public static int UserInput()
        {

            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }

        public static void FindValidNbr()
        {

            do
            {
                Console.WriteLine("Entre un nombre entre 0 et 10: ");
                UserInput();
            }
            while (UserInput() < 0 || UserInput() > 10);
        }

        public static void FindZero()
        {
            int newNbr = UserInput();
            int lastNbr = newNbr;
            do
            {
                newNbr = UserInput();
                lastNbr = newNbr >= lastNbr  ? lastNbr : newNbr;
                Console.WriteLine("The smallest number is actually: " + lastNbr);
            }
            while (newNbr != 0);

        }
    }
}