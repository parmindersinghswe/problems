namespace Problems.Library.Models
{
    /// <summary>
    /// Represents a node in a binary tree.
    /// </summary>
    public class TreeNode
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public int val;

        /// <summary>
        /// The left child node.
        /// </summary>
        public TreeNode? left;

        /// <summary>
        /// The right child node.
        /// </summary>
        public TreeNode? right;

        /// <summary>
        /// Initializes a new instance of the TreeNode class with a specified value and optional references to the left and right child nodes.
        /// </summary>
        /// <param name="val">The value to store in the node.</param>
        /// <param name="left">The left child node (optional).</param>
        /// <param name="right">The right child node (optional).</param>
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
