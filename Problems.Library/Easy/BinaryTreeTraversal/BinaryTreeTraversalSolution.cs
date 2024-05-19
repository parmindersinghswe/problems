using Problems.Library.Models;

namespace Problems.Library.Easy.BinaryTreeTraversal
{
    public class BinaryTreeTraversalSolution
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
        public IList<int> PreorderTraversal(TreeNode? root)
        {
            IList<int> list = new List<int>();
            if (root != null)
            {
                TraversePreOrder(root, list);
            }
            return list;
        }
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
