namespace Problems.Library.Easy.RomanToInteger
{
    /// <summary>
    /// Solution for converting Roman numerals to integer values.
    /// </summary>
    public class RomanToInteger
    {
        /// <summary>
        /// Converts a Roman numeral string to its integer value.
        /// </summary>
        /// <param name="s">The Roman numeral string.</param>
        /// <returns>The integer value of the Roman numeral.</returns>
        public int RomanToInt(string s)
        {
            Dictionary<char, int> romanIntegers = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            char prev = '\0';
            int total = 0;

            foreach (char c in s)
            {
                if (prev != '\0' && romanIntegers[c] > romanIntegers[prev])
                {
                    total -= 2 * romanIntegers[prev];
                }
                total += romanIntegers[c];
                prev = c;
            }

            return total;
        }
    }
}
