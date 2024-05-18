using Problems.Library.Models;

namespace Problems.Test.Services
{
    public static class TreeService
    {
        public static TreeNode? CreateTree(int?[] values)
        {
            if (values.Length == 0 || values[0] == null) return null;

            TreeNode root = new TreeNode(values[0]!.Value);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int i = 1;

            while (queue.Count > 0 && i < values.Length)
            {
                TreeNode current = queue.Dequeue();

                if (i < values.Length && values[i] != null)
                {
                    current.left = new TreeNode(values[i]!.Value);
                    queue.Enqueue(current.left);
                }
                i++;

                if (i < values.Length && values[i] != null)
                {
                    current.right = new TreeNode(values[i]!.Value);
                    queue.Enqueue(current.right);
                }
                i++;
            }

            return root;
        }
    }
}
