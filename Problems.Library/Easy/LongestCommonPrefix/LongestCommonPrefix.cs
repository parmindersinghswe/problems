namespace Problems.Library.Easy.LongestCommonPrefix
{
    /// <summary>
    /// Solution to find the common prefix at the start of the given array of strings.
    /// </summary>
    public class LongestCommonPrefix
    {
        /// <summary>
        /// Returns the common prefix at the start of the given array of strings.
        /// </summary>
        /// <param name="strs">The input array of strings.</param>
        /// <returns>The longest common prefix.</returns>
        public string Solve(string[] strs)
        {
            int length = strs.Length;
            // Use the first string as the initial common prefix
            string common = strs[0];
            // Iterate through the rest of the strings
            for (int i = 1; i < length; i++)
            {
                // If the current string does not start with the common prefix
                if (!strs[i].StartsWith(common))
                {
                    // If the common prefix starts with the current string, update the common prefix
                    if (common.StartsWith(strs[i]))
                    {
                        common = strs[i];
                    }
                    else
                    {
                        // Determine the shorter length between the common prefix and the current string
                        int shortLength = common.Length > strs[i].Length ? strs[i].Length : common.Length;
                        int j = 0;
                        // Compare characters of the common prefix with the current string
                        for (; j < shortLength; j++)
                        {
                            if (common[j] != strs[i][j])
                            {
                                break;
                            }
                        }
                        // Update the common prefix to the matched portion
                        common = common.Substring(0, j);
                    }
                }
            }
            return common;
        }
    }
}
