using System;

namespace Methods
{
    public class Solution
    {
        /* Sum of n1 + */
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }
        /* Return a sentence with a parameters */
        public static string Whos(string fname, string lname, int age)
        {
            return $"Firstname : {fname}\nLastname : {lname}\nAge : {age}";
        }
        /* Return the sum and product of n1 & n2 */
        public static void SumAndProduct(int n1, int n2, out int sum, out int prod)
        {
            sum = n1 + n2;
            prod = n1 * n2;
        }
        /* Return quotien and reminder of a division of n1 / n2 */
        public static (int quotient, int remainder) QuotientAndRemainder(int n1, int n2)
        {
            int quotient = n1 / n2;
            int remainder = n1 % n2;
            return (quotient, remainder);
        }
        /* Return (n * 2) or (2 * 10) by default */
        public static int MethodWithDefaultValue(int n = 10)
        {
            return n * 2;
        }
    }
}
