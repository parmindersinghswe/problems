namespace Problems.Library.Easy.FindIndexOfFirstOccurrence
{
    /// <summary>
    /// Solution to find the index of the first occurrence of a substring in a given string.
    /// </summary>
    public class FindIndexOfFirstOccurrenceSolution
    {
        /// <summary>
        /// Returns the index of the first occurrence of the substring in the given string.
        /// </summary>
        /// <param name="haystack">The string to search within.</param>
        /// <param name="needle">The substring to find.</param>
        /// <returns>The index of the first occurrence of the substring, or -1 if not found.</returns>
        public int Find(string haystack, string needle)
        {
            int current = 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                int currentFrom = i;
                while (current < needle.Length && currentFrom < haystack.Length && needle[current] == haystack[currentFrom])
                {
                    currentFrom++;
                    current++;
                }
                if (current == needle.Length)
                {
                    return i;
                }
                current = 0;
            }
            if (haystack != null && needle != null && needle == "")
            {
                return 0;
            }
            return -1;
        }
    }
}
