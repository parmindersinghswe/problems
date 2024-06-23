namespace Problems.Library.Easy.RansomNote
{
    /// <summary>
    /// Solution to the Ransom Note problem.
    /// </summary>
    public class RansomNoteSolution
    {
        /// <summary>
        /// Determines if a ransom note can be constructed using the characters from a given magazine.
        /// </summary>
        /// <param name="ransomNote">The string representing the ransom note.</param>
        /// <param name="magazine">The string representing the magazine.</param>
        /// <returns>True if the ransom note can be constructed from the magazine, otherwise false.</returns>
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length)
            {
                return false;
            }

            var charCount = new Dictionary<char, int>();

            foreach (var c in magazine)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            foreach (var c in ransomNote)
            {
                if (!charCount.ContainsKey(c) || charCount[c] == 0)
                {
                    return false;
                }
                charCount[c]--;
            }

            return true;
        }
    }
}
