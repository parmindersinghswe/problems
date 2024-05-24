using Problems.Test.Services;
using Problems.Library.Models;
using Problems.Library.Medium.RemoveNthFromEnd;

namespace Problems.Test.Medium
{
    public class RemoveNthFromEndTests
    {
        public static IEnumerable<object[]> RemoveNthFromEndTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 } };
            yield return new object[] { new int[] { 1 }, 1, new int[] { } };
            yield return new object[] { new int[] { 1, 2 }, 1, new int[] { 1 } };
            yield return new object[] { new int[] { 1, 2 }, 2, new int[] { 2 } };
            yield return new object[] { new int[] { 1, 2, 3 }, 3, new int[] { 2, 3 } };
            yield return new object[] { new int[] { }, 1, new int[] { } };
            yield return new object[] { new int[] { 1 }, 2, new int[] { 1 } };
            yield return new object[] { new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 1, new int[] { 1, 2, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, 4, new int[] { 2, 3, 4 } };
        }

        [Theory]
        [MemberData(nameof(RemoveNthFromEndTestData))]
        public void Test_RemoveNthFromEnd(int[] values, int n, int[] expected)
        {
            var solution = new RemoveNthFromEndSolution();
            ListNode? head = LinkedListService.CreateLinkedList(values);
            head = solution.RemoveNthFromEnd(head, n);
            List<int> result = LinkedListService.ConvertToList(head);
            Assert.Equal(expected, result);
        }
    }
}
