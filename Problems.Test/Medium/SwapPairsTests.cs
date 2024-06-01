using Problems.Library.Medium.SwapPairs;
using Problems.Library.Models;
using Problems.Test.Services;
namespace Problems.Test.Medium
{
    public class SwapPairsTests
    {
        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { new int[] { }, new int[] { } };
            yield return new object[] { new int[] { 1 }, new int[] { 1 } };
            yield return new object[] { new int[] { 1, 2 }, new int[] { 2, 1 } };
            yield return new object[] { new int[] { 1, 2, 3 }, new int[] { 2, 1, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 4, 3 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 4, 3, 5 } };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 2, 1, 4, 3, 6, 5 } };
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void TestSwapPairs(int[] inputArray, int[] expectedArray)
        {
            var solution = new SwapPairsSolution();
            ListNode? head = LinkedListService.CreateLinkedList(inputArray);
            ListNode? result = solution.SwapPairs(head);
            List<int> resultArray = LinkedListService.ConvertToList(result);
            Assert.Equal(expectedArray, resultArray);
        }
    }
}
