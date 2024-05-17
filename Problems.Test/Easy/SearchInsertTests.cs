using Problems.Library.Easy.SearchInsertPosition;

namespace Problems.Test.Easy
{
    public class SearchInsertTests
    {
        [Theory]
        [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
        [InlineData(new int[] { 1, 3, 5, 6 }, 0, 0)]
        [InlineData(new int[] { 1 }, 0, 0)]
        public void SearchInsert_Test(int[] nums, int target, int expected)
        {
            SearchInsertPositionSolution solution = new SearchInsertPositionSolution();
            int result = solution.SearchInsert(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
