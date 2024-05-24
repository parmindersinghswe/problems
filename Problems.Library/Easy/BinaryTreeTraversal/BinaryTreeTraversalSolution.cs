using Problems.Library.Models;

namespace Problems.Library.Easy.BinaryTreeTraversal
{
    /// <summary>
    /// Solutions for Binary Tree Traversal.
    /// </summary>
    public class BinaryTreeTraversalSolution
    {
        /// <summary>
        /// Performs a post-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>A list of node values in post-order.</returns>
        public IList<int> PostorderTraversal(TreeNode? root)
        {
            IList<int> result = new List<int>();
            if (root != null)
            {
                TraversePostOrder(root, result);
            }
            return result;
        }

        /// <summary>
        /// Performs a pre-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>A list of node values in pre-order.</returns>
        public IList<int> PreorderTraversal(TreeNode? root)
        {
            IList<int> list = new List<int>();
            if (root != null)
            {
                TraversePreOrder(root, list);
            }
            return list;
        }

        /// <summary>
        /// Helper method for performing pre-order traversal.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <param name="list">A list to store the visited node values.</param>
        private void TraversePreOrder(TreeNode root, IList<int> list)
        {
            list.Add(root.val);
            if (root.left != null)
            {
                TraversePreOrder(root.left, list);
            }
            if (root.right != null)
            {
                TraversePreOrder(root.right, list);
            }
        }

        /// <summary>
        /// Helper method for performing post-order traversal.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <param name="list">A list to store the visited node values.</param>
        private void TraversePostOrder(TreeNode root, IList<int> list)
        {
            if (root.left != null)
            {
                TraversePostOrder(root.left, list);
            }
            if (root.right != null)
            {
                TraversePostOrder(root.right, list);
            }
            list.Add(root.val);
        }
    }
}
