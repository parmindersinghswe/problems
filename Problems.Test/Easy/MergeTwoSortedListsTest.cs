using Problems.Library.Models;
using Problems.Library.Easy.MergeTwoSortedLists;

namespace Problems.Test.Easy
{
    public class MergeTwoSortedListsTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
        public void MergeTwoLists_Test(int[] list1Array, int[] list2Array, int[] expectedArray)
        {
            MergeTwoSortedLists msl = new MergeTwoSortedLists();
            ListNode? list1 = CreateList(list1Array);
            ListNode? list2 = CreateList(list2Array);
            ListNode? expected = CreateList(expectedArray);

            ListNode? result = msl.MergeTwoLists(list1, list2);

            Assert.True(AreEqual(expected, result));
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3, new int[] { 1, 2, 2, 3, 5, 6 })] 
        [InlineData(new int[] { 1 }, 1, new int[] { }, 0, new int[] { 1 })] 
        [InlineData(new int[] { 0 }, 0, new int[] { 1 }, 1, new int[] { 1 })]
        [InlineData(new int[] { 4, 5, 6, 0, 0, 0 }, 3, new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })] 
        [InlineData(new int[] { 1, 3, 5, 0, 0, 0 }, 3, new int[] { 2, 4, 6 }, 3, new int[] { 1, 2, 3, 4, 5, 6 })] 
        [InlineData(new int[] { 1, 2, 4, 5, 6, 0 }, 5, new int[] { 3 }, 1, new int[] { 1, 2, 3, 4, 5, 6 })] 
        [InlineData(new int[] { 2, 0 }, 1, new int[] { 1 }, 1, new int[] { 1, 2 })] 
        public void Merge_Tests(int[] nums1, int m, int[] nums2, int n, int[] expected)
        {
            MergeTwoSortedLists solution = new MergeTwoSortedLists();
            solution.Merge(nums1, m, nums2, n);
            Assert.Equal(expected, nums1);
        }

        private ListNode? CreateList(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            ListNode head = new ListNode(array[0]);
            ListNode current = head;

            for (int i = 1;i < array.Length;i++)
            {
                current.next = new ListNode(array[i]);
                current = current.next;
            }

            return head;
        }

        private bool AreEqual(ListNode? l1, ListNode? l2)
        {
            while (l1 != null && l2 != null)
            {
                if (l1.val != l2.val)
                {
                    return false;
                }
                l1 = l1.next;
                l2 = l2.next;
            }
            return l1 == null && l2 == null;
        }
    }
}
