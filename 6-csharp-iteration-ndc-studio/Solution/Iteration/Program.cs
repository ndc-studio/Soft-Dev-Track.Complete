using System.Security.Cryptography.X509Certificates;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.SumOfNumbers());
            try
            {
                int result = Solution.Factorial(-5);
                Console.WriteLine(result);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"SCRIPT_ERROR: {ex.Message}");
            }

            Solution.ShowMultiplication();

            Solution.FindZero();
        }
    }
}
