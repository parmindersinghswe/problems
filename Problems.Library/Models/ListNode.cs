namespace Problems.Library.Models
{
    /// <summary>
    /// Represents a node in a singly linked list.
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// The value stored in the node.
        /// </summary>
        public int val;

        /// <summary>
        /// The next node in the linked list.
        /// </summary>
        public ListNode? next;

        /// <summary>
        /// Initializes a new instance of the ListNode class with a specified value and an optional reference to the next node.
        /// </summary>
        /// <param name="val">The value to store in the node.</param>
        /// <param name="next">The next node in the linked list (optional).</param>
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
