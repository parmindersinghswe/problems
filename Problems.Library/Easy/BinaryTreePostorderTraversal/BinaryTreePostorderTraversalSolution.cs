using Problems.Library.Models;

namespace Problems.Library.Easy.BinaryTreePostorderTraversal
{
    public class BinaryTreePostorderTraversalSolution
    {
        public IList<int> PostorderTraversal(TreeNode? root)
        {
            IList<int> result = new List<int>();
            if (root != null)
            {
                TraversePostOrder(root, result);
            }
            return result;
        }

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
