namespace Problems.Library.Medium.Subsets
{
    /// <summary>
    /// Solution to generate all possible subsets of a given array of integers.
    /// </summary>
    public class SubsetsSolution
    {
        /// <summary>
        /// Generates all possible subsets of the given array of integers.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <returns>A list of lists, where each list is a subset of the input array.</returns>
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            GetUniqueSubsets(nums, list, new List<int>(), 0, nums.Length);
            return list;
        }

        /// <summary>
        /// Recursively generates all unique subsets of the given array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="list">The list to store all subsets.</param>
        /// <param name="currentSet">The current subset being constructed.</param>
        /// <param name="currentIndex">The current index in the array.</param>
        /// <param name="length">The length of the array.</param>
        public void GetUniqueSubsets(int[] nums, IList<IList<int>> list, IList<int> currentSet, int currentIndex, int length)
        {
            list.Add(new List<int>(currentSet));
            for (int i = currentIndex; i < length; i++)
            {
                currentSet.Add(nums[i]);
                GetUniqueSubsets(nums, list, currentSet, i + 1, length);
                currentSet.RemoveAt(currentSet.Count - 1);
            }
        }
    }
}
