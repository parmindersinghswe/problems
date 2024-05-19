namespace Problems.Library.Easy.SearchInsertPosition
{
    /// <summary>
    /// To search the postion where the given target can fit in the list of values.
    /// </summary>
    public class SearchInsertPositionSolution
    {
        /// <summary>
        /// Return the position of the target value in the array of integer either present or not. If present then the current postion otherwise where it should be.
        /// </summary>
        /// <param name="nums">Array of integer values.</param>
        /// <param name="target">Target vlaue to find in the array of integers.</param>
        /// <returns></returns>
        public int SearchInsert(int[] nums, int target)
        {
            int length = nums.Length;
            return Search(0, length - 1, nums, target);
        }
        /// <summary>
        /// Private method to perform binary search recursively
        /// </summary>
        /// <param name="start">start index</param>
        /// <param name="end">end index</param>
        /// <param name="nums">array of integers</param>
        /// <param name="target">target value to be searched</param>
        /// <returns></returns>
        private int Search(int start, int end, int[] nums, int target)
        {
            // Calculate the middle index
            int mid = (start + end) / 2;

            // If target is found at mid, return the mid index
            if (target == nums[mid])
            {
                return mid;
            }

            // If start index is greater or equal to end index, determine the insertion point
            if (start >= end)
            {
                // If the number at start index is greater than the target, return start as the insertion point
                if (nums[start] > target)
                {
                    return start;
                }
                else
                {
                    // Otherwise, the target should be inserted just after the start index
                    return start + 1;
                }
            }

            // If target is less than the number at mid, search in the left half
            if (target < nums[mid])
            {
                return Search(start, mid, nums, target);
            }

            // If target is greater than the number at mid, search in the right half
            return Search(mid + 1, end, nums, target);
        }
    }
}
