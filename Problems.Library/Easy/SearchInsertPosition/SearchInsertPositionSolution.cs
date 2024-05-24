namespace Problems.Library.Easy.SearchInsertPosition
{
    /// <summary>
    /// Solution to find the position where the given target can be inserted in a sorted list of values.
    /// </summary>
    public class SearchInsertPositionSolution
    {
        /// <summary>
        /// Finds the position of the target value in the array of integers. 
        /// If the target is present, it returns the current position, otherwise, it returns the position where it should be inserted.
        /// </summary>
        /// <param name="nums">Array of integer values.</param>
        /// <param name="target">Target value to find in the array of integers.</param>
        /// <returns>The position of the target value.</returns>
        public int SearchInsert(int[] nums, int target)
        {
            int length = nums.Length;
            return Search(0, length - 1, nums, target);
        }

        /// <summary>
        /// Private method to perform a binary search recursively.
        /// </summary>
        /// <param name="start">The start index.</param>
        /// <param name="end">The end index.</param>
        /// <param name="nums">The array of integers.</param>
        /// <param name="target">The target value to be searched.</param>
        /// <returns>The position of the target value.</returns>
        private int Search(int start, int end, int[] nums, int target)
        {
            int mid = (start + end) / 2;

            if (target == nums[mid])
            {
                return mid;
            }

            if (start >= end)
            {
                return nums[start] > target ? start : start + 1;
            }

            if (target < nums[mid])
            {
                return Search(start, mid, nums, target);
            }

            return Search(mid + 1, end, nums, target);
        }
    }
}
