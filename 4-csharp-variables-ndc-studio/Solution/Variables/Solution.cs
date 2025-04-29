using System;

namespace Variables
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }
        public static float AgeToFloat(int nbr)
        {
            float floatNumber = (nbr / 2f);
            return floatNumber;
        }

        public static decimal CelciusToFarenheit(decimal decimNbr)
        {
            decimal farenheit = (decimNbr * 9m / 5m) + 32m;
            return farenheit;
        }

        public static double KilometersToMiles(double km)
        {
            double miles = km * 0.6;
            return miles;
        }
    }
}
