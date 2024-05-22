using Problems.Test.Services;
using Problems.Library.Models;
using Problems.Library.Medium.AddTwoNumbers;

namespace Problems.Test.Medium
{
    public class AddTwoNumbersTests
    {
        public static IEnumerable<object[]> AddTwoNumbersTestData()
        {
            yield return new object[] { new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 } };
            yield return new object[] { new int[] { 0 }, new int[] { 0 }, new int[] { 0 } };
            yield return new object[] { new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 } };
            yield return new object[] { new int[] { 1 }, new int[] { 9, 9, 9 }, new int[] { 0, 0, 0, 1 } };
            yield return new object[] { new int[] { 0 }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 } };
            yield return new object[] { new int[] { 5 }, new int[] { 5 }, new int[] { 0, 1 } };
            yield return new object[] { new int[] { 9, 9 }, new int[] { 1 }, new int[] { 0, 0, 1 } };
            yield return new object[] { new int[] { 1, 8 }, new int[] { 0 }, new int[] { 1, 8 } };
            yield return new object[] { new int[] { 1, 8, 9 }, new int[] { 7, 2 }, new int[] { 8, 0, 0, 1 } };
            yield return new object[] { new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 9, 9, 9, 1 } };
        }

        [Theory]
        [MemberData(nameof(AddTwoNumbersTestData))]
        public void Test_AddTwoNumbers(int[] l1Values, int[] l2Values, int[] expectedValues)
        {
            ListNode? l1 = LinkedListService.CreateLinkedList(l1Values);
            ListNode? l2 = LinkedListService.CreateLinkedList(l2Values);
            AddTwoNumbersSolution solution = new AddTwoNumbersSolution();
            ListNode? result = solution.AddTwoNumbers(l1, l2);
            List<int> resultList = LinkedListService.ConvertToList(result);
            Assert.Equal(expectedValues, resultList);
        }
    }
}
