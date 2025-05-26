namespace GenericSpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Test Box<T> */
            var intBox = new Box<int>(42);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\n[ TEST Box<T> Class ]\n");
            Console.WriteLine(intBox.DisplayValue());
            Console.WriteLine("\n----------------------------------");


            /* Test Swap<T> */
            var utility = new Utility();
            var x = new Box<int>(10);
            var y = new Box<int>(20);
            Console.WriteLine("\n[ TEST Swap<T> Method ]");
            Console.WriteLine($"\nx = {x}, y = {y} above the swap");
            utility.Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y} after the swap");
            Console.WriteLine("\n----------------------------------\n");

            /* Test MyList<T> */
            Console.WriteLine("\n[ TEST MyList<T> Class ]");
            var list = new MyList<string>();
            list.Add("Hello");
            list.Add("Firstname");
            list.Add("Lastname");
            list.Add("Dob");
            try
            {
                Console.WriteLine("\n[ TEST index [0] ]");
                Console.WriteLine(list.Get(0));
                Console.WriteLine("\n[ TEST index [1] ]");
                Console.WriteLine(list.Get(1));
                Console.WriteLine("\n[ TEST index [2] ]");
                Console.WriteLine(list.Get(2));
                Console.WriteLine("\n[ TEST index [3] ]");
                Console.WriteLine(list.Get(3));
                Console.WriteLine("\n[ TEST index [4] ]");
                Console.WriteLine(list.Get(4));
            }
            catch (Exception e)
            {
                Console.WriteLine($"SCRIPT_ERROR: {e.Message}");
            }
            Console.WriteLine("\n----------------------------------\n");

            /* Test Greeter<T> */
            Console.WriteLine("\n[ TEST Greet method with Ganeric Greeter class and Interface ]");
            var greeter = new Greeter<Person>();
            var person1 = new Person("Jean");
            var person2 = new Person("Stephan");
            var person3 = new Person("Lizzie");
            var person4 = new Person("Jhon");

            Console.WriteLine(greeter.Greet(person1));
            Console.WriteLine(greeter.Greet(person2));
            Console.WriteLine(greeter.Greet(person3));
            Console.WriteLine(greeter.Greet(person4));
            Console.WriteLine("\n----------------------------------\n");

            /* Test LINQ */
            Console.WriteLine("\n[ TEST Generics with LINQ ]");
            var names = new List<string> { person1.Name, person2.Name, person3.Name, person4.Name };
            var filter = FilterUtility.Filter(names, name => name.StartsWith("J"));

            foreach (var name in filter)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n----------------------------------\n");

            /* EXIT */
            Console.WriteLine("\n[ Press any key to exit! ]");
            Console.ReadKey();
        }
    }
}