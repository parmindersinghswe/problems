namespace Problems.Library.Medium.RemoveDuplicatesFromSortedArray
{
    /// <summary>
    /// Solution to remove duplicates from a sorted array allowing at most two occurrences of each element.
    /// </summary>
    public class RemoveDuplicatesFromSortedArraySolution
    {
        /// <summary>
        /// Removes duplicates from a sorted array, allowing at most two occurrences of each element.
        /// </summary>
        /// <param name="nums">The sorted array of integers.</param>
        /// <returns>The length of the array after removing the duplicates.</returns>
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;
            if (length <= 2) return length;

            int duplicate = 1;
            int currentIndex = 1;

            for (int i = 1; i < length; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    duplicate++;
                }
                else
                {
                    duplicate = 1;
                }

                if (duplicate <= 2)
                {
                    nums[currentIndex++] = nums[i];
                }
            }
            return currentIndex;
        }
    }
}
