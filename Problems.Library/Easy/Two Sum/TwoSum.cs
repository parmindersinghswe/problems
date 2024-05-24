namespace Problems.Library.TwoSum
{
    /// <summary>
    /// Solution to find two numbers in an array whose sum equals a given target.
    /// </summary>
    public class TwoSumSolution
    {
        /// <summary>
        /// Finds the indices of the two integers in the array that sum up to the given target value.
        /// </summary>
        /// <param name="nums">Array of integers.</param>
        /// <param name="target">The target sum value.</param>
        /// <returns>An array containing the indices of the two integers that sum up to the target value.</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                if (!map.ContainsKey(nums[i]))
                {
                    map[nums[i]] = i;
                }
            }
            return new int[] { };
        }
    }
}
