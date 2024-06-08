namespace Problems.Library.Medium.NextPermutation
{
    /// <summary>
    /// Class to solve the problem of finding the next lexicographical permutation of a sequence.
    /// </summary>
    public class NextPermutationSolution
    {
        /// <summary>
        /// Rearranges numbers into the lexicographically next greater permutation of numbers.
        /// </summary>
        /// <param name="nums">An array of integers to find the next permutation for.</param>
        public void NextPermutation(int[] nums)
        {
            int length = nums.Length;
            int i = length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = length - 1;
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1, length - 1);
        }

        /// <summary>
        /// Swaps the values at two specified indices in an array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="i">The first index.</param>
        /// <param name="j">The second index.</param>
        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        /// <summary>
        /// Reverses the order of elements in a portion of an array.
        /// </summary>
        /// <param name="nums">The array of integers.</param>
        /// <param name="start">The starting index of the portion to reverse.</param>
        /// <param name="end">The ending index of the portion to reverse.</param>
        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                Swap(nums, start, end);
                start++;
                end--;
            }
        }
    }
}
