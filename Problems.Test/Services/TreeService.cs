using Problems.Library.Models;

namespace Problems.Test.Services
{
    /// <summary>
    /// Tree Helper Class To Do the basic operations.
    /// </summary>
    public static class TreeService
    {
        /// <summary>
        /// Return Root node after creating binary tree from given array of integer values.
        /// </summary>
        /// <param name="values">Array of integer values.</param>
        /// <returns></returns>
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
