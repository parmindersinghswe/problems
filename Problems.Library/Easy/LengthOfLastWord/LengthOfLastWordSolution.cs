namespace Problems.Library.Easy.LengthOfLastWord
{
    /// <summary>
    /// To find the length of word that exists at the end of the given string.
    /// </summary>
    public class LengthOfLastWordSolution
    {
        /// <summary>
        /// Returns the length of the string that present at the end of the string.
        /// </summary>
        /// <param name="s">input string</param>
        /// <returns></returns>
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
