using Problems.Library.Models;

namespace Problems.Library.Easy.SymmetricTree
{
    public class SymmetricTreeSolution
    {
        // Method to check if a tree is symmetric
        public bool IsSymmetric(TreeNode root)
        {
            // If the tree is empty, it's symmetric by definition
            return root == null || IsMirror(root.left, root.right);
        }

        // Helper method to check if two subtrees are mirror images of each other
        public bool IsMirror(TreeNode? left, TreeNode? right)
        {
            // If either subtree is null, both must be null to be mirrors
            if (left == null || right == null)
            {
                return left == right;
            }
            // Check if the current nodes have the same value and their children are mirrors
            return left.val == right.val && IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        }
    }

}
