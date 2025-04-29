namespace Selection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, what is your age?");
            //Console.WriteLine(Solution.CanEnterInTheCasino());
            //Console.WriteLine("Enter discount mode between 1 to 3\nStudent [1]: discount 10%\nMember [2]: discount 5%\nSale product [3]: discount 20% ");
            //int inputMode = int.Parse(Solution.UserInput());
            //Console.WriteLine("Enter the price will be reduce");
            //double inputPrice = double.Parse(Solution.UserInput());
            //try
            //{
            //Console.WriteLine(Solution.DiscountPriceCalculator(inputMode, inputPrice));
            //}

            //catch (ArgumentException ex)
            //{
            //   Console.WriteLine($"SCRIPT_ERROR: {ex.Message}");
            //   Console.ReadLine();
            //}

            Console.WriteLine(Solution.TriangleClassification(10, 10, 10));
            Console.ReadLine();
        }
    }
}
