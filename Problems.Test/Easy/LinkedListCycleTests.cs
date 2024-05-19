using Problems.Test.Services;
using Problems.Library.Models;
using Problems.Library.Easy.LinkedListCycle;

namespace Problems.Test.Easy
{
    public class LinkedListCycleTests
    {
        public static IEnumerable<object[]> HasCycleTestData()
        {
            yield return new object[] { new int[] { }, -1, false };
            yield return new object[] { new int[] { 1 }, -1, false };
            yield return new object[] { new int[] { 1, 2 }, 0, true };
            yield return new object[] { new int[] { 3, 2, 0, -4 }, 1, true };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 4, true };
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, -1, false };
        }

        [Theory]
        [MemberData(nameof(HasCycleTestData))]
        public void HasCycle_Test(int[] values, int pos, bool expected)
        {
            ListNode? head = LinkedListService.CreateLinkedList(values, pos);
            LinkedListCycleSolution solution = new LinkedListCycleSolution();
            bool result = solution.HasCycle(head);
            Assert.Equal(expected, result);
        }
    }
}
