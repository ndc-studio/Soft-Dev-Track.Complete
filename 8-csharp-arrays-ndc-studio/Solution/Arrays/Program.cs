namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you need? : ");
            int[] an = Solution.CreateRandNumbers(Solution.UserInput());

            // display sum of all array values
            Console.WriteLine("Sum: " + Solution.Sum(an));

            // display average
            Console.WriteLine("Average: " + Solution.Average(an));

            // try to catch min and max num in array
            Solution.MaxAndMin(an, out int max, out int min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);

            // Sort and display array
            int[] sortedArray = Solution.SortAndArray(an);
            Console.WriteLine("Sorted Array: " + string.Join(", ", sortedArray));

            // Palindrome test
            string palindromeResult = Solution.Palindrome(an);
            Console.WriteLine(palindromeResult);


            Console.ReadLine();
        }
    }
}
