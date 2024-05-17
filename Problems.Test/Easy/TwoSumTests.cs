using Problems.Library.TwoSum;

namespace Problems.Test.Easy
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        public void TwoSum_Test(int[] nums, int target, int[] expected)
        {
            TwoSumSolution twoSum = new TwoSumSolution();
            int[] result = twoSum.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
