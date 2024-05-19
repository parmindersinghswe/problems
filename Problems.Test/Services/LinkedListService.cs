using Problems.Library.Models;
namespace Problems.Test.Services
{
    public static class LinkedListService
    {
        public static ListNode? CreateLinkedList(int[] values)
        {
            if (values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }
            return head;
        }

        public static bool CompareLinkedLists(ListNode? l1, ListNode? l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val) return false;
                l1 = l1.next;
                l2 = l2.next;
            }
            return l1 == null && l2 == null;
        }
        public static ListNode CreateLinkedList(int[] values, int pos)
        {
            if (values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            ListNode cycleNode = null;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
                if (i == pos)
                {
                    cycleNode = current;
                }
            }

            if (pos >= 0)
            {
                current.next = cycleNode ?? head;
            }

            return head;
        }
    }
}
