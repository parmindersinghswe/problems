using Problems.Library.Models;

namespace Problems.Library.Easy.SortedArrayToBST
{
    /// <summary>
    /// Class to convert a sorted array to a height-balanced binary search tree (BST).
    /// </summary>
    public class SortedArrayToBSTSolution
    {
        /// <summary>
        /// Converts a sorted array to a height-balanced BST.
        /// </summary>
        /// <param name="nums">The sorted array of integers.</param>
        /// <returns>The root node of the height-balanced BST.</returns>
        public TreeNode? SortedArrayToBST(int[] nums)
        {
            return GetNode(nums, 0, nums.Length - 1);
        }

        /// <summary>
        /// Recursively constructs the BST from the sorted array.
        /// </summary>
        /// <param name="nums">The sorted array of integers.</param>
        /// <param name="left">The left boundary index.</param>
        /// <param name="right">The right boundary index.</param>
        /// <returns>The root node of the subtree.</returns>
        private TreeNode? GetNode(int[] nums, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;
                return new TreeNode(nums[mid], GetNode(nums, left, mid - 1), GetNode(nums, mid + 1, right));
            }
            return null;
        }
    }
}
