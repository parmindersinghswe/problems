using Problems.Library.Models;
using System.Collections.Generic;

namespace Problems.Library.Easy.BinaryTreeTraversal
{
    /// <summary>
    /// Solutions for Binary Tree Traversal.
    /// </summary>
    public class BinaryTreeTraversalSolution
    {
        private readonly IList<int> Traversed = new List<int>();
        /// <summary>
        /// Performs a post-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>A list of node values in post-order.</returns>
        public IList<int> PostorderTraversal(TreeNode? root)
        {
            if (root != null)
            {
                PostorderTraversal(root.left);
                PostorderTraversal(root.right);
                Traversed.Add(root.val);
            }
            return Traversed;
        }

        /// <summary>
        /// Performs a pre-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>A list of node values in pre-order.</returns>
        public IList<int> PreorderTraversal(TreeNode? root)
        {
           if(root != null)
            {
                Traversed.Add(root.val);
                PreorderTraversal(root.left);
                PreorderTraversal(root.right);
            }
            return Traversed;
        }
        /// <summary>
        /// Performs a in-order traversal of the binary tree.
        /// </summary>
        /// <param name="root">The root node of the binary tree.</param>
        /// <returns>A list of node values in pre-order.</returns>
        public IList<int> InorderTraversal(TreeNode? root)
        {
            if (root != null)
            {
                InorderTraversal(root.left);
                Traversed.Add(root.val);
                InorderTraversal(root.right);
            }
            return Traversed;
        }
    }
}
