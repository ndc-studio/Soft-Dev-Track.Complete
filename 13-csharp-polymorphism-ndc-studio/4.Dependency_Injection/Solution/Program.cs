using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace EngineSpace
{
    public class Program
    {
        // Create List
        public static List<Car> Cars = [];

        public static void Main(string[] args)
        {
            // CreateEngines
            DieselEngine diesel = new DieselEngine();
            GasolineEngine gas = new GasolineEngine();

            // Create Cars
            Car car = new Car(diesel);
            Car car1 = new Car(diesel);
            Car car2 = new Car(diesel);
            Car car3 = new Car(gas);
            Car car4 = new Car(gas);
            Car car5 = new Car(gas);

            // Add cars into the list
            Cars.Add(car);
            Cars.Add(car1);
            Cars.Add(car2);
            Cars.Add(car3);
            Cars.Add(car4);
            Cars.Add(car5);

            // Test Start method
            foreach (var c in Cars)
            {
                c.Start();
            }

            // Exit
            Console.WriteLine("\n\nPress any key for exiting the session...!\n");
            Console.ReadKey();
        }
    }
}