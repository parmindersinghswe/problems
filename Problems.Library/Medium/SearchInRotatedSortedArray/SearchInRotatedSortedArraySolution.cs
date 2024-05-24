namespace Problems.Library.Medium.SearchInRotatedSortedArray
{
    /// <summary>
    /// Solution for searching in a rotated sorted array.
    /// </summary>
    public class SearchInRotatedSortedArraySolution
    {
        /// <summary>
        /// Searches for a target value in a rotated sorted array.
        /// </summary>
        /// <param name="nums">The rotated sorted array.</param>
        /// <param name="target">The target value to search for.</param>
        /// <returns>The index of the target value if found; otherwise, -1.</returns>
        public int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            if (nums[start] == target)
            {
                return start;
            }
            else if (nums[end] == target)
            {
                return end;
            }
            return BSearch(nums, target, start, end);
        }

        public int BSearch(int[] nums, int target, int start, int end)
        {
            int mid = (start + end) / 2;
            if (end < start || mid == start || mid == end)
            {
                return -1;
            }
            else if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[start] == target)
            {
                return start;
            }
            else if (nums[end] == target)
            {
                return end;
            }
            int idx = -1;
            if (target < nums[mid])
            {
                idx = BSearch(nums, target, start, mid);
                idx = idx >= 0 ? idx : BSearch(nums, target, mid, end);
            }
            else
            {
                idx = BSearch(nums, target, mid, end);
                idx = idx >= 0 ? idx : BSearch(nums, target, start, mid);
            }
            return idx;
        }
    }
}
