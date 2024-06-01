using Problems.Library.Models;
namespace Problems.Library.Medium.SwapPairs
{
    /// <summary>
    /// Solution to swap adjacent nodes in a linked list.
    /// </summary>
    public class SwapPairsSolution
    {
        /// <summary>
        /// Swaps every two adjacent nodes in the linked list and returns the modified list's head.
        /// </summary>
        /// <param name="head">The head of the linked list.</param>
        /// <returns>The head of the modified linked list after swapping adjacent nodes.</returns>
        public ListNode? SwapPairs(ListNode? head)
        {
           
            if (head != null && head.next != null)
            {
                ListNode? fptr = head;
                head = fptr.next;
                fptr.next = head.next;
                head.next = fptr;
                ListNode? sptr = fptr.next;
                while (sptr != null && sptr.next != null)
                {
                    fptr.next = sptr.next;
                    fptr = fptr.next;
                    sptr.next = fptr.next;
                    fptr.next = sptr;
                    fptr = sptr;
                    sptr = sptr.next;
                }

            }
            return head;
        }
    }
}
