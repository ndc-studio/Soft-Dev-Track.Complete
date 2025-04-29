using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Solution
    {
        public static string IsAdult(int x)
        {
            return x >= 18 ? "You are an adult" : "You are a child";
        }
        public static string EvenOrOdd(int y)
        {
            return y % 2 == 0 ? "Even" : "Odd";
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Max(int c, int d)
        {
            return c > d ? c : d;
        }
    }
}
