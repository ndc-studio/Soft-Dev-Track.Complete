using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public class Solution
    {
        public static string UserInput()
        {
            return Console.ReadLine();
        }

        public static int[] CreateRandNumbers(string str)
        {

            List<int> an = new List<int>(); // Array of numbers
            try
            {
                Random r = new Random(); // Create random
                int psti = int.Parse(str); // Parsed String To Int
                for (int i = 0; i < psti; i++)
                {
                    int ri = r.Next(1, 11); // random int
                    an.Add(ri);
                }
                int[] result = an.ToArray();
                Console.WriteLine(string.Join(", ", result));
                return result;
            }
            catch (FormatException)
            {
                throw new FormatException("Please enter a number between 1 and 10");
            }
        }

        public static int Sum(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }

        public static double Average(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum / (double)n.Length;
        }

        public static void MaxAndMin(int[] n, out int maxNbr, out int minNbr)
        {
            maxNbr = n[0];
            minNbr = n[0];
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] > maxNbr)
                {
                    maxNbr = n[i];
                }

                if (n[i] < minNbr)
                {
                    minNbr = n[i];
                }
            }
        }

        public static int[] SortAndArray(int[] n)
        {
            Array.Sort(n);
            return n;
        }

        public static string Palindrome(int[] a)
        {
            int[] ra = a.Reverse().ToArray();

            if (a.SequenceEqual(ra)) {
                return "The array is a palindrome";
            } else {
                return "The array is not a palindrome";
            }
        }

    }
}
