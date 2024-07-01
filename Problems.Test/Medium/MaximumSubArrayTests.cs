using Problems.Library.Medium.MaximumSubArray;

namespace Problems.Test.Medium
{
    public class MaximumSubArrayTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6 };
            yield return new object[] { new int[] { 1 }, 1 };
            yield return new object[] { new int[] { 5, 4, -1, 7, 8 }, 23 };
            yield return new object[] { new int[] { -1, -2, -3, -4 }, -1 };
            yield return new object[] { new int[] { 0, -1, 2, -3, 4, -2, 2, 1 }, 5 };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void MaxSubArray_Tests(int[] nums, int expected)
        {
            var solution = new MaximumSubArraySolution();
            var result = solution.MaxSubArray(nums);
            Assert.Equal(expected, result);
        }
        [Fact]
        public void MaxSubArray_Tests_ShouldThrowArgumentException()
        {
            var solution = new MaximumSubArraySolution();
            var nums = new int[] { };
            Assert.Throws<ArgumentException>(() => solution.MaxSubArray(nums));
        }
    }
}
