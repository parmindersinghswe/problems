using Problems.Library.Models;

namespace Problems.Library.Easy.PathSum
{
    /// <summary>
    /// Solutions of the Path Sum of the tree
    /// </summary>
    public class PathSumSolution
    {
        /// <summary>
        /// Return true if any path of the tree nodes sum is equal to the target Sum.
        /// </summary>
        /// <param name="root">Input root node of the binary tree.</param>
        /// <param name="targetSum">Input target sum.</param>
        /// <returns></returns>
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
