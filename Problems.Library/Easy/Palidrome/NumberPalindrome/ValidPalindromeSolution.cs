namespace Problems.Library.Easy.Palidrome.NumberPalindrome
{
    /// <summary>
    /// Solution to determine if a given input is a valid palindrome.
    /// </summary>
    public class ValidPalindromeSolution
    {
        /// <summary>
        /// Helper method to convert a lowercase letter to an uppercase letter.
        /// </summary>
        /// <param name="c">The input character to convert to uppercase.</param>
        /// <returns>The converted uppercase character.</returns>
        private char Upper(char c)
        {
            if (c >= 97 && c <= 122)
            {
                return (char)(c - 32);
            }
            return c;
        }

        /// <summary>
        /// Determines if the given input string is a valid palindrome after removing all non-alphanumeric characters and ignoring character case.
        /// </summary>
        /// <param name="s">The input string to check.</param>
        /// <returns>True if the input string is a valid palindrome, otherwise false.</returns>
        public bool IsPalindrome(string s)
        {
            if (s == null || s == "")
            {
                return true;
            }
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                char startChar = Upper(s[start]);
                char endChar = Upper(s[end]);
                if ((startChar < 65 || startChar > 90) && !(startChar >= 48 && startChar <= 57))
                {
                    start++;
                    continue;
                }
                if ((endChar < 65 || endChar > 90) && !(endChar >= 48 && endChar <= 57))
                {
                    end--;
                    continue;
                }
                if (startChar != endChar)
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
