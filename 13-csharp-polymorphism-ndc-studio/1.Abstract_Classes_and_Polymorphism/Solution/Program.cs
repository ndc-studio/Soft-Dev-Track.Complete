using System;

namespace VehicleSpace
{
    public class Program
    {
        public static List<Vehicle> Vehicles = new List<Vehicle>();

        public static void Main(string[] args)
        {

            Motorcycle kawazaki = new Motorcycle();
            Motorcycle suzuki = new Motorcycle();
            Car toyota = new Car();
            Car citroen = new Car();
            Motorcycle harley = new Motorcycle();
            Car dacia = new Car();

            Vehicles.Add(kawazaki);
            Vehicles.Add(suzuki);
            Vehicles.Add(toyota);
            Vehicles.Add(citroen);
            Vehicles.Add(harley);
            Vehicles.Add(dacia);

            foreach (var veh in Vehicles)
            {
                Console.WriteLine(veh.Start());
            }

            Console.WriteLine("\n\nPress any key for exiting the session...!\n");
            Console.ReadLine();
        }
    }
}