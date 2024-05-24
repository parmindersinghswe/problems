namespace Problems.Library.Easy.SingleNumber
{
    /// <summary>
    /// Solution to find the single number in a list of integers.
    /// </summary>
    public class SingleNumberSolution
    {
        /// <summary>
        /// Returns the number that appears only once in the array of integers.
        /// </summary>
        /// <param name="nums">Array of integer values.</param>
        /// <returns>The integer value that has no duplicates in the array.</returns>
        public int SingleNumber(int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
