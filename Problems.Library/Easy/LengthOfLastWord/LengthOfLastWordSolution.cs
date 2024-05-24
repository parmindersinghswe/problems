namespace Problems.Library.Easy.LengthOfLastWord
{
    /// <summary>
    /// Solution to find the length of the last word in the given string.
    /// </summary>
    public class LengthOfLastWordSolution
    {
        /// <summary>
        /// Returns the length of the last word in the input string.
        /// </summary>
        /// <param name="s">The input string.</param>
        /// <returns>The length of the last word.</returns>
        public int Length(string s)
        {
            int i = s.Length - 1;
            int length = 0;
            while (i >= 0 && s[i] == ' ')
            {
                i--;
            }

            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }
            return length;
        }
    }
}
