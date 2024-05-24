namespace Problems.Library.Medium.StringToInteger
{
    /// <summary>
    /// Solution to convert a string to an integer.
    /// </summary>
    public class StringToIntegerSolution
    {
        /// <summary>
        /// Converts the first integer value found in the string, ignoring leading spaces and considering an optional leading sign character.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The converted integer value, or zero if no valid conversion can be performed.</returns>
        public int MyAtoi(string s)
        {
            int i = 0;
            int returnValue = 0;
            int totalChars = s.Length;
            int sign = 1;

            // Ignore leading whitespaces
            while (i < totalChars && s[i] == ' ')
            {
                i++;
            }

            // Check for sign
            if (i < totalChars)
            {
                if (s[i] == '-')
                {
                    sign = -1;
                    i++;
                }
                else if (s[i] == '+')
                {
                    i++;
                }

                // Convert digits to integer
                while (i < totalChars && s[i] >= '0' && s[i] <= '9')
                {
                    int newDigit = CharToInt(s[i]);

                    // Check for overflow
                    if (returnValue > (Int32.MaxValue - newDigit) / 10)
                    {
                        return sign == 1 ? Int32.MaxValue : Int32.MinValue;
                    }

                    returnValue = returnValue * 10 + newDigit;
                    i++;
                }
            }

            return returnValue * sign;
        }

        /// <summary>
        /// Converts a character to its integer value.
        /// </summary>
        /// <param name="ch">The input character.</param>
        /// <returns>The integer value of the character.</returns>
        private int CharToInt(char ch)
        {
            return ch - '0';
        }
    }
}
