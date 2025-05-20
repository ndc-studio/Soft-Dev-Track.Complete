using System;

namespace AnimalSpace
{
    public class Program
    {
        public static List<Animal> Animals = new List<Animal>();

        public static void Main(string[] args)
        {

            Dog strike = new Dog();
            Cat clochette = new Cat();
            Dog kayna = new Dog();
            Cat lili = new Cat();
            Dog chop = new Dog();
            Cat calista = new Cat();

            Animals.Add(strike);
            Animals.Add(clochette);
            Animals.Add(kayna);
            Animals.Add(lili);
            Animals.Add(chop);
            Animals.Add(calista);

            foreach (var animal in Animals)
            {
                animal.MakeNoise();
            }

            Console.WriteLine("\n\nPress any key for exiting the session...!\n");
            Console.ReadLine();
        }
    }
}