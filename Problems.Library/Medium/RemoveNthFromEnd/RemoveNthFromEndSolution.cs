using Problems.Library.Models;

namespace Problems.Library.Medium.RemoveNthFromEnd
{
    /// <summary>
    /// Solution to remove the N-th node from the end of a linked list.
    /// </summary>
    public class RemoveNthFromEndSolution
    {
        /// <summary>
        /// Removes the N-th node from the end of the list and returns the head of the modified list.
        /// </summary>
        /// <param name="head">The head of the linked list.</param>
        /// <param name="n">The position from the end of the list of the node to remove.</param>
        /// <returns>The head of the modified linked list.</returns>
        public ListNode? RemoveNthFromEnd(ListNode? head, int n)
        {
            if (head == null || n <= 0) return head;
            ListNode dummy = new ListNode(0, head);
            ListNode? first = dummy;
            ListNode? second = dummy;
            for (int i = 0; i <= n; i++)
            {
                if (first == null) return head;
                first = first.next;
            }
            while (first != null)
            {
                first = first.next;
                second = second!.next;
            }

            if (second?.next != null)
            {
                second.next = second.next.next;
            }
            return dummy.next;
        }
    }
}
