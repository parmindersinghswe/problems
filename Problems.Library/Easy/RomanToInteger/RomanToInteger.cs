namespace Problems.Library.Easy.RomanToInteger
{
    /// <summary>
    /// Conversion from Roman to Integer value.
    /// </summary>
    public class RomanToInteger
    {
        /// <summary>
        /// Return the integer value for the given roman input.
        /// </summary>
        /// <param name="s">Roman input value.</param>
        /// <returns></returns>
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
                    total = total - 2 * romanIntegers[prev];
                }
                total = total + romanIntegers[c];
                prev = c;
            }
            return total;
        }
    }
}
