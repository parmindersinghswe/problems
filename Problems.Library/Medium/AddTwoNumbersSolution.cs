using Problems.Library.Models;

namespace Problems.Test.Medium
{
    /// <summary>
    /// Add Two Big Integer Numbers
    /// </summary>
    public class AddTwoNumbersSolution
    {
        /// <summary>
        /// Return the Addition of Two Big Integer Numbers in reverse order with digits repredented in two different Linked Lists in reverse order.
        /// </summary>
        /// <param name="l1">Input of first list of digits</param>
        /// <param name="l2">Input of second list of digits</param>
        /// <returns></returns>
        public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;
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
