using Problems.Library.Models;

namespace Problems.Library.Easy.BinaryTreeTraversal
{
    /// <summary>
    /// Binary Tree Traversal Solutions
    /// </summary>
    public class BinaryTreeTraversalSolution
    {
        /// <summary>
        /// Traverse Binary Tree in Post Order
        /// </summary>
        /// <param name="root">Root of the given tree</param>
        /// <returns></returns>
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
        /// Traverse Binary Tree in Pre Order
        /// </summary>
        /// <param name="root">Root of the given tree</param>
        /// <returns></returns>
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
        /// Pre Order Traversal implementation
        /// </summary>
        /// <param name="root">tree root node</param>
        /// <param name="list">visited elements</param>
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
        /// Post Order Traverse Implementation
        /// </summary>
        /// <param name="root">root of the tree</param>
        /// <param name="list">visited elements</param>
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
