namespace Problems.Library.Hard.ValidNumber
{
    /// <summary>
    /// Solution to validate if a string is a valid number.
    /// </summary>
    public class ValidNumberSolution
    {
        /// <summary>
        /// Determines whether the given string is a valid number.
        /// </summary>
        /// <param name="s">The string to validate.</param>
        /// <returns><c>true</c> if the string is a valid number; otherwise, <c>false</c>.</returns>
        public bool IsNumber(string s)
        {
            s = s.Trim();
            bool seenDigit = false;
            bool seenExponent = false;
            bool seenDecimal = false;
            int length = s.Length;

            for (int i = 0; i < length; i++)
            {
                char currentChar = s[i];

                if (char.IsDigit(currentChar))
                {
                    seenDigit = true;
                }
                else if (currentChar == '.')
                {
                    if (seenDecimal || seenExponent)
                    {
                        return false;
                    }
                    seenDecimal = true;
                }
                else if (currentChar == 'e' || currentChar == 'E')
                {
                    if (seenExponent || !seenDigit)
                    {
                        return false;
                    }
                    seenExponent = true;
                    seenDigit = false;
                }
                else if (currentChar == '+' || currentChar == '-')
                {
                    if (i > 0 && s[i - 1] != 'e' && s[i - 1] != 'E')
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return seenDigit;
        }
    }
}
