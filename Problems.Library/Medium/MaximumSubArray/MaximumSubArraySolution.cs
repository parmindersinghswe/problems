namespace Problems.Library.Medium.MaximumSubArray
{
    /// <summary>
    /// Solution for finding the subarray with the largest sum in a given integer array.
    /// </summary>
    public class MaximumSubArraySolution
    {
        /// <summary>
        /// Finds the subarray with the largest sum and returns its sum.
        /// </summary>
        /// <param name="nums">The input array of integers.</param>
        /// <returns>The sum of the subarray with the largest sum.</returns>
        public int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                throw new ArgumentException("Array must contain at least one element");
            }
            int maxSum = nums[0];
            int currentSum = maxSum;
            for (int i = 1; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                maxSum = Math.Max(currentSum, maxSum);
            }
            return maxSum;
        }
    }
}
