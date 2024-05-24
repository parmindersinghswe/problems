namespace Problems.Library.Easy.RemoveElement
{
    /// <summary>
    /// Solution for removing all occurrences of a given input value from an array.
    /// </summary>
    public class RemoveElement
    {
        /// <summary>
        /// Removes all occurrences of the specified value from the array, shifts the remaining elements to the start of the array, and returns the count of remaining elements.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="val">The target value to remove from the array.</param>
        /// <returns>The number of remaining elements after removal.</returns>
        public int Remove(int[] nums, int val)
        {
            int current = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[current++] = nums[i];
                }
            }
            return current;
        }
    }
}
