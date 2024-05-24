using Problems.Library.Models;

namespace Problems.Library.Easy.PathSum
{
    /// <summary>
    /// Solutions for the Path Sum problem in a binary tree.
    /// </summary>
    public class PathSumSolution
    {
        /// <summary>
        /// Determines if there is a path in the binary tree where the sum of the node values equals the target sum.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <param name="targetSum">The target sum to check against.</param>
        /// <returns>True if such a path exists, otherwise false.</returns>
        public bool HasPathSum(TreeNode? root, int targetSum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null)
            {
                return root.val == targetSum;
            }
            return HasPathSum(root.left, targetSum - root.val) ||
                   HasPathSum(root.right, targetSum - root.val);
        }
    }
}
