namespace Problems.Library.TwoSum
{
    /// <summary>
    /// To find the two values their sum is the target
    /// </summary>
    public class TwoSumSolution
    {
        /// <summary>
        /// Return the indexes of two integers their sum is equal to the given target value.
        /// </summary>
        /// <param name="nums">Array of integers.</param>
        /// <param name="target">Target value.</param>
        /// <returns></returns>
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