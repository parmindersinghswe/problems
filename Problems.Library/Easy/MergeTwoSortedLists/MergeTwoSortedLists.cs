using Problems.Library.Models;

namespace Problems.Library.Easy.MergeTwoSortedLists
{
    public class MergeTwoSortedLists
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int currentIndex = nums1.Length - 1;
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
