using Problems.Library.Models;

namespace Problems.Library.Easy.LinkedListCycle
{
    public class LinkedListCycleSolution
    {
        public bool HasCycle(ListNode head)
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
