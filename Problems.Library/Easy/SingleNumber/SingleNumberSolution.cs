namespace Problems.Library.Easy.SingleNumber
{
    /// <summary>
    /// To find the single number present in the list.
    /// </summary>
    public class SingleNumberSolution
    {
        /// <summary>
        /// Return the number that has no duplicate in the array of integers.
        /// </summary>
        /// <param name="nums">Array of integer values.</param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }
    }
}
