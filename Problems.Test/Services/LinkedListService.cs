using Problems.Library.Models;
namespace Problems.Test.Services
{
    /// <summary>
    /// Linked List Helper Class To Do the basic operations.
    /// </summary>
    public static class LinkedListService
    {
        /// <summary>
        /// Return the head node of the linked list created with the given array of integers.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static ListNode? CreateLinkedList(int[] values)
        {
            return CreateLinkedList(values, -1);
        }

        /// <summary>
        /// Create LinkedList with Cycle from last node to the in between node that is at the given position.
        /// </summary>
        /// <param name="values">All the elements of the linked list.</param>
        /// <param name="pos">Postion of element where the last node points to and create cycle.</param>
        /// <returns></returns>
        public static ListNode? CreateLinkedList(int[] values, int pos)
        {
            if (values.Length == 0) return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            ListNode? cycleNode = null;

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
        /// <summary>
        /// Compare two linked lists and return true if both are same otherwise false.
        /// </summary>
        /// <param name="l1">First linked list head node.</param>
        /// <param name="l2">Second linked list head node.</param>
        /// <returns></returns>
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
        /// <summary>
        /// Returns the list of integers converted from linked list values.
        /// </summary>
        /// <param name="head">Input Head node of linked list.</param>
        /// <returns></returns>
        public static List<int> ConvertToList(ListNode? head)
        {
            List<int> result = new List<int>();
            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }
            return result;
        }
    }
}
