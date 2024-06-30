namespace Problems.Library.Easy.Isomorphic
{
    /// <summary>
    /// Solution class for checking if two strings are isomorphic.
    /// </summary>
    public class IsomorphicSolution
    {
        /// <summary>
        /// Determines if two strings are isomorphic.
        /// </summary>
        /// <param name="s">The first input string.</param>
        /// <param name="t">The second input string.</param>
        /// <returns>True if the strings are isomorphic; otherwise, false.</returns>
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> mapS = new Dictionary<char, char>();
            Dictionary<char, char> mapT = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];
                if (mapS.ContainsKey(sChar))
                {
                    if (mapS[sChar] != tChar)
                    {
                        return false;
                    }
                }
                else
                {
                    mapS[sChar] = tChar;
                }
                if (mapT.ContainsKey(tChar))
                {
                    if (mapT[tChar] != sChar)
                    {
                        return false;
                    }
                }
                else
                {
                    mapT[tChar] = sChar;
                }
            }

            return true;
        }
    }
}
