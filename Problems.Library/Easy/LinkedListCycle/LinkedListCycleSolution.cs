using Problems.Library.Models;

namespace Problems.Library.Easy.LinkedListCycle
{
    /// <summary>
    /// Solutions related to detecting cycles in a linked list.
    /// </summary>
    public class LinkedListCycleSolution
    {
        /// <summary>
        /// Checks if a cycle exists in the given linked list.
        /// </summary>
        /// <param name="head">The head node of the linked list.</param>
        /// <returns>True if a cycle is detected; otherwise, false.</returns>
        public bool HasCycle(ListNode? head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode? ptr1 = head;
            ListNode? ptr2 = head.next;
            while (ptr2 != null && ptr2.next != null)
            {
                ptr1 = ptr1!.next;
                ptr2 = ptr2.next;
                if (ptr2 != null)
                {
                    ptr2 = ptr2.next;
                }
                if (ptr1 == ptr2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
