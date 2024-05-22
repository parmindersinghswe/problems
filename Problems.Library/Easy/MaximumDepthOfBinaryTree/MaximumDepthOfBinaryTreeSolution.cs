using Problems.Library.Models;
namespace Problems.Library.Easy.MaximumDepthOfBinaryTree
{
    public class MaximumDepthOfBinaryTreeSolution
    {
        public int MaxDepth(TreeNode? root)
        {
            if (root == null) return 0;
            int leftDepth = MaxDepth(root.left);
            int rightDepth = MaxDepth(root.right);
            return (leftDepth > rightDepth ? leftDepth : rightDepth) + 1;
        }
    }
}
