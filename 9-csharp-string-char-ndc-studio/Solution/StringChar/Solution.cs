namespace StringChar
{
    public class Solution
    {
        public static string ReversedString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Input string must not be empty");
            }
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string CountVowels(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Input string must not be empty");
            }

            HashSet<char> vf = new HashSet<char>();

            foreach (char c in str.ToLower())
            {
                if ("aeiouy".Contains(c))
                {
                    vf.Add(c);
                }
            }

            return $"Number of vowels:{vf.Count}";
        }


        public static bool isPalindrome(string str)
        {   /* convert string to array *csta (delete specials characters and spaces and convert char array) */
            string csta = new string(str.Where(c => char.IsLetterOrDigit(c)).Select(c => char.ToLower(c)).ToArray());
            /* reverse string * rs (reverse csta char array )*/
            string rs = new string(csta.Reverse().ToArray());
            /* check if csta and rs is the same char array and return string for that */
            if (csta == rs)
            {
                Console.WriteLine("The string is a palindrome.");
                return true;
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
                return false;
            };
        }

        public static char Test_FirstNonRepeatingCharacter(string str)
        {
            /* Create dictionnary for character count the key is a character and the value is the nbr of we retreive this character in the string */
            Dictionary<char, int> cc = new Dictionary<char, int>();
            str = str.ToLower();
            foreach (char c in str)
            {
                /* Ternary statement, if cc not contains the character we create key and increment 1 for the value else we increment the value of existing character. */
                cc[c] = cc.ContainsKey(c) ? cc[c] + 1 : 1;
            };
            /* Return the first char with 1 like value */
            foreach (char c in str)
            {
                if (cc[c] == 1)
                {
                    return c;
                }
            };
            return '\0';
        }
    }
}
