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
        public bool IsMirror(TreeNode? root, TreeNode? mirror)
        {
            // If either subtree is null, both must be null to be mirrors
            if (root == null || mirror == null)
            {
                return root == mirror;
            }
            // Check if the current nodes have the same value and their children are mirrors
            return root.val == mirror.val && IsMirror(root.left, mirror.right) && IsMirror(root.right, mirror.left);
        }
    }

}
