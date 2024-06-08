using Problems.Library.Models;

namespace Problems.Library.Easy.SameTree
{
    /// <summary>
    /// Solution to check if two binary trees are the same.
    /// </summary>
    public class SameTreeSolution
    {
        /// <summary>
        /// Determines whether two binary trees are the same.
        /// </summary>
        /// <param name="p">The root node of the first binary tree.</param>
        /// <param name="q">The root node of the second binary tree.</param>
        /// <returns><c>true</c> if the binary trees are the same; otherwise, <c>false</c>.</returns>
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            if (p == null || q == null)
            {
                return p == q;
            }
            return p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
