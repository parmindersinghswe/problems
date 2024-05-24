using Problems.Library.Models;

namespace Problems.Library.Easy.MergeTwoSortedLists
{
    /// <summary>
    /// Solution to merge two sorted lists into a single sorted list.
    /// </summary>
    public class MergeTwoSortedLists
    {
        /// <summary>
        /// Merges a second sorted array into a first sorted array, maintaining sorted order.
        /// </summary>
        /// <param name="nums1">The first sorted array, with a size to accommodate both arrays.</param>
        /// <param name="m">The number of initialized elements in the first array.</param>
        /// <param name="nums2">The second sorted array.</param>
        /// <param name="n">The number of elements in the second array.</param>
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
        /// Merges two sorted linked lists into a single sorted linked list.
        /// </summary>
        /// <param name="list1">The first sorted linked list.</param>
        /// <param name="list2">The second sorted linked list.</param>
        /// <returns>The head node of the merged linked list.</returns>
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
