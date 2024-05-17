namespace Problems.Library.Easy.SearchInsertPosition
{
    public class SearchInsertPositionSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int length = nums.Length;
            return Search(0, length - 1, nums, target);
        }
        // Private method to perform binary search recursively
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
