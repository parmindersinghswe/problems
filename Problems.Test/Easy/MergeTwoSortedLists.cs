using Problems.Library.Easy.MergeTwoSortedLists;

namespace Problems.Test.Easy
{
    public class MergeTwoSortedListsTests
    {
        [Fact]
        public void MergeTwoLists_BothNonEmpty()
        {
            MergeTwoSortedLinkedLists msl = new MergeTwoSortedLinkedLists();
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new ListNode(1, new ListNode(3, new ListNode(4)));
            ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));

            ListNode result = msl.MergeTwoLists(list1, list2);

            Assert.True(AreEqual(expected, result));
        }

        [Fact]
        public void MergeTwoLists_BothEmpty()
        {
            MergeTwoSortedLinkedLists msl = new MergeTwoSortedLinkedLists();
            ListNode list1 = null;
            ListNode list2 = null;
            ListNode expected = null;

            ListNode result = msl.MergeTwoLists(list1, list2);

            Assert.True(AreEqual(expected, result));
        }

        [Fact]
        public void MergeTwoLists_OneEmpty()
        {
            MergeTwoSortedLinkedLists msl = new MergeTwoSortedLinkedLists();
            ListNode list1 = null;
            ListNode list2 = new ListNode(0);
            ListNode expected = new ListNode(0);

            ListNode result = msl.MergeTwoLists(list1, list2);

            Assert.True(AreEqual(expected, result));
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
