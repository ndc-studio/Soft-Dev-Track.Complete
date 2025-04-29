namespace StringChar
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Solution.ReversedString("Hello"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"SCRIPT_ERROR: {ex.Message}\n");
            }


            try
            {
                Console.WriteLine(Solution.CountVowels("You are a nice software developer"));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"SCRIPT_ERROR: {ex.Message}\n");
            }

            try
            {
                Solution.isPalindrome("Elu par cette crapule");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"SCRIPT_ERROR: {ex.Message}\n");
            }
            Console.WriteLine(Solution.Test_FirstNonRepeatingCharacter("Stress"));
            Console.ReadLine();
        }
    }
}
