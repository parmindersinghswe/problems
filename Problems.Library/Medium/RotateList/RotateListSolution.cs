using Problems.Library.Models;

namespace Problems.Library.Medium.RotateList
{
    /// <summary>
    /// Solution to rotate a linked list to the right by a given number of positions.
    /// </summary>
    public class RotateListSolution
    {
        /// <summary>
        /// Rotates the linked list to the right by the given number of positions.
        /// </summary>
        /// <param name="head">The head of the linked list.</param>
        /// <param name="k">The number of positions to rotate the list to the right.</param>
        /// <returns>The new head of the rotated linked list.</returns>
        public ListNode? RotateRight(ListNode? head, int k)
        {
            if (head == null || head.next == null || k == 0) return head;

            ListNode current = head;
            int length = 1;

            while (current.next != null)
            {
                current = current.next;
                length++;
            }

            current.next = head;

            k = k % length;
            int stepsToNewHead = length - k;

            ListNode newTail = head;

            for (int i = 1; i < stepsToNewHead; i++)
            {
                newTail = newTail.next!;
            }

            ListNode newHead = newTail.next!;
            newTail.next = null;

            return newHead;
        }
    }
}
