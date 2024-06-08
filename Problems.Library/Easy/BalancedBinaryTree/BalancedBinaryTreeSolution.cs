using Problems.Library.Models;

namespace Problems.Library.Easy.BalancedBinaryTree
{
    /// <summary>
    /// Solution to check if a binary tree is height-balanced.
    /// </summary>
    public class BalancedBinaryTreeSolution
    {
        /// <summary>
        /// Determines whether the binary tree is height-balanced.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns><c>true</c> if the binary tree is height-balanced; otherwise, <c>false</c>.</returns>
        public bool IsBalanced(TreeNode? root)
        {
            if (root == null)
            {
                return true;
            }
            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);
            return Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right);
        }

        /// <summary>
        /// Computes the height of a binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>The height of the binary tree.</returns>
        private int Height(TreeNode? root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = Height(root.left);
            int rightHeight = Height(root.right);
            return (leftHeight > rightHeight ? leftHeight : rightHeight) + 1;
        }
    }
}
