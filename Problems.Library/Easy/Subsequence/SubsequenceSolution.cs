namespace Problems.Library.Easy.Subsequence
{
    /// <summary>
    /// Solution to check if one string is a subsequence of another string.
    /// </summary>
    public class SubsequenceSolution
    {
        /// <summary>
        /// Determines whether the string s is a subsequence of string t.
        /// </summary>
        /// <param name="s">The subsequence string to check.</param>
        /// <param name="t">The main string to check against.</param>
        /// <returns><c>true</c> if s is a subsequence of t; otherwise, <c>false</c>.</returns>
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            for (int j = 0; j < t.Length && i < s.Length; j++)
            {
                if (s[i] == t[j])
                {
                    i++;
                }
            }
            return (i >= s.Length);
        }
    }
}
