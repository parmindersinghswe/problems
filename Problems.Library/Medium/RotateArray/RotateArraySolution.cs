namespace Problems.Library.Medium.RotateArray
{
    /// <summary>
    /// Solution to rotate an array to the right by a given number of steps.
    /// </summary>
    public class RotateArraySolution
    {
        /// <summary>
        /// Rotates the array to the right by the specified number of steps.
        /// </summary>
        /// <param name="nums">The array of integers to rotate.</param>
        /// <param name="k">The number of steps to rotate the array.</param>
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (k == 0 || nums.Length <= 1) return;

            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        /// <summary>
        /// Reverses the elements in the specified portion of the array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="start">The starting index of the portion to reverse.</param>
        /// <param name="end">The ending index of the portion to reverse.</param>
        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
