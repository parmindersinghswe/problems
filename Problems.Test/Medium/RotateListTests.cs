using Problems.Test.Services;
using Problems.Library.Models;
using Problems.Library.Medium.RotateList;

namespace Problems.Test.Medium
{
    public class RotateListTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void RotateRight_Tests(ListNode? head, int k, ListNode expected)
        {
            var solution = new RotateListSolution();
            ListNode? result = solution.RotateRight(head, k);
            Assert.True(LinkedListService.CompareLinkedLists(result, expected));
        }

        public static IEnumerable<object?[]> GetTestData()
        {
            return new List<object?[]> {
            new object?[] { LinkedListService.CreateLinkedList(new int[] {1, 2, 3, 4, 5}), 2, LinkedListService.CreateLinkedList(new int[] {4, 5, 1, 2, 3}) },
            new object?[] { LinkedListService.CreateLinkedList(new int[] {0, 1, 2}), 4, LinkedListService.CreateLinkedList(new int[] {2, 0, 1}) },
            new object?[] { LinkedListService.CreateLinkedList(new int[] {1}), 1, LinkedListService.CreateLinkedList(new int[] {1}) },
            new object?[] { LinkedListService.CreateLinkedList(new int[] {1, 2}), 2, LinkedListService.CreateLinkedList(new int[] {1, 2}) },
            new object?[] { LinkedListService.CreateLinkedList(new int[] {1, 2, 3}), 0, LinkedListService.CreateLinkedList(new int[] {1, 2, 3}) },
            new object?[] { null, 1, null },
            new object?[] { LinkedListService.CreateLinkedList(new int[] {1, 2, 3, 4, 5}), 10, LinkedListService.CreateLinkedList(new int[] {1, 2, 3, 4, 5}) },
            new object?[] { LinkedListService.CreateLinkedList(new int[] {1, 2, 3, 4, 5}), 3, LinkedListService.CreateLinkedList(new int[] {3, 4, 5, 1, 2}) },
        };
        }
    }
}
