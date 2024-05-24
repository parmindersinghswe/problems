using Problems.Library.Models;

namespace Problems.Library.Easy.MaximumDepthOfBinaryTree
{
    /// <summary>
    /// Solution to find the maximum depth of a binary tree.
    /// </summary>
    public class MaximumDepthOfBinaryTreeSolution
    {
        /// <summary>
        /// Returns the maximum depth of the binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>The maximum depth of the tree.</returns>
        public int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            return (leftDepth > rightDepth ? leftDepth : rightDepth) + 1;
        }
    }
}
