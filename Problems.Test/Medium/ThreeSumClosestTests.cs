
using Problems.Library.Medium.ThreeSumClosest;
namespace Problems.Test.Medium
{
    public class ThreeSumClosestTests
    {
        public static IEnumerable<object[]> ThreeSumClosestTestData()
        {
            yield return new object[] { new int[] { -1, 2, 1, -4 }, 1, 2 };
            yield return new object[] { new int[] { 0, 0, 0 }, 1, 0 };
            yield return new object[] { new int[] { 1, 1, 1, 1 }, 0, 3 };
            yield return new object[] { new int[] { -1, 0, 1, 1 }, 1, 1 };
            yield return new object[] { new int[] { 1, 2, 5, 10, 11 }, 12, 13 };
            yield return new object[] { new int[] { -1, 2, 1, -4, 5, 3 }, 5, 5 };
            yield return new object[] { new int[] { 1, 1, 1, 0 }, -100, 2 };
            yield return new object[] { new int[] { 1, 1, 1, 0 }, 100, 3 };
        }

        [Theory]
        [MemberData(nameof(ThreeSumClosestTestData))]
        public void Test_ThreeSumClosest(int[] nums, int target, int expected)
        {
            var solution = new ThreeSumClosestSolution();
            int result = solution.ThreeSumClosest(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
