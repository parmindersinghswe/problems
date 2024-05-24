using Problems.Library.Models;

namespace Problems.Library.Medium.AddTwoNumbers
{
    /// <summary>
    /// Solution to add two large integer numbers represented by linked lists.
    /// </summary>
    public class AddTwoNumbersSolution
    {
        /// <summary>
        /// Adds two large integer numbers represented in reverse order by two different linked lists and returns the sum as a linked list in reverse order.
        /// </summary>
        /// <param name="l1">The first linked list of digits.</param>
        /// <param name="l2">The second linked list of digits.</param>
        /// <returns>A linked list representing the sum of the two numbers.</returns>
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = l1 != null ? l1.val : 0;
                int y = l2 != null ? l2.val : 0;
                int sum = x + y + carry;
                carry = sum / 10;
                current.next = new ListNode(sum % 10);
                current = current.next;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            if (carry > 0)
            {
                current.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
}
