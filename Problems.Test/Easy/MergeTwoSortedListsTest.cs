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
            MergeTwoSortedLinkedLists msl = new MergeTwoSortedLinkedLists();
            ListNode list1 = CreateList(list1Array);
            ListNode list2 = CreateList(list2Array);
            ListNode expected = CreateList(expectedArray);

            ListNode result = msl.MergeTwoLists(list1, list2);

            Assert.True(AreEqual(expected, result));
        }

        private ListNode CreateList(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            ListNode head = new ListNode(array[0]);
            ListNode current = head;

            for (int i = 1; i < array.Length; i++)
            {
                current.next = new ListNode(array[i]);
                current = current.next;
            }

            return head;
        }

        private bool AreEqual(ListNode l1, ListNode l2)
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
