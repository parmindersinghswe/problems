using Problems.Library.Models;

namespace Problems.Library.Easy.MergeTwoSortedLists
{
    /// <summary>
    /// To Merge two lists those are already sorted and result will also be in sort order.
    /// </summary>
    public class MergeTwoSortedLists
    {
        /// <summary>
        /// Merge second sorted array into first sorted array
        /// </summary>
        /// <param name="nums1">First sorted array in which second sorted array will be merged with (m+n) number of elments.</param>
        /// <param name="m">number of elements in first array needs to be merged and other elements set to zero to fill with the second array elements.</param>
        /// <param name="nums2">Second sorted array.</param>
        /// <param name="n">number of elements in second sorted array.</param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int currentIndex = m + n - 1;
            while (m > 0 && n > 0)
            {
                if (nums1[m - 1] > nums2[n - 1])
                {
                    nums1[currentIndex] = nums1[m - 1];
                    m--;
                }
                else
                {
                    nums1[currentIndex] = nums2[n - 1];
                    n--;
                }
                currentIndex--;
            }
            while (m > 0)
            {
                nums1[currentIndex] = nums1[m - 1];
                m--;
                currentIndex--;
            }
            while (n > 0)
            {
                nums1[currentIndex] = nums2[n - 1];
                n--;
                currentIndex--;
            }
        }
        /// <summary>
        /// Return the head node of merged linked list from two sorted linked lists
        /// </summary>
        /// <param name="list1">First sorted linked list</param>
        /// <param name="list2">Second sorted linked list</param>
        /// <returns></returns>
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            current.next = list1 ?? list2;
            return dummy.next;
        }
    }
}
