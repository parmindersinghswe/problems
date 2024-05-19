namespace Problems.Library.Easy.Palidrome.NumberPalindrome
{
    /// <summary>
    /// Checks if given input is Valid Palindrome or not.
    /// </summary>
    public class ValidPalindromeSolution
    {
        /// <summary>
        /// Helper method to convert lower case letter to upper case letter
        /// </summary>
        /// <param name="c">Input character to convert to upper case.</param>
        /// <returns></returns>
        private char Upper(char c)
        {
            if (c >= 97 && c <= 122)
            {
                return (char)(c - 32);
            }
            return c;
        }
        /// <summary>
        /// Return true if given input string is valid palindrome otherwise false after removing all the non-alphanumeric characters and ignoring the character case.
        /// </summary>
        /// <param name="s">Input string value.</param>
        /// <returns></returns>
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
