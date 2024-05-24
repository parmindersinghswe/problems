using Problems.Library.Medium.SearchInRotatedSortedArray;
namespace Problems.Test.Medium
{
    public class SearchInRotatedSortedArrayTests
    {
        public static IEnumerable<object[]> SearchTestData()
        {
            yield return new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4 };
            yield return new object[] { new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1 };
            yield return new object[] { new int[] { 1 }, 0, -1 };
            yield return new object[] { new int[] { 1, 3 }, 0, -1 };
            yield return new object[] { new int[] { 1, 3 }, 1, 0 };
            yield return new object[] { new int[] { 1, 3 }, 3, 1 };
            yield return new object[] { new int[] { 3, 5, 1 }, 1, 2 };
            yield return new object[] { new int[] { 5, 1, 3 }, 5, 0 };
            yield return new object[] { new int[] { 5, 6, 7, 0, 1, 2, 4 }, 0, 3 };
            yield return new object[] { new int[] { 2, 2, 2, 0, 1, 2 }, 0, 3 };
        }

        [Theory]
        [MemberData(nameof(SearchTestData))]
        public void SearchInRotatedSortedArray_Test(int[] nums, int target, int expected)
        {
            var solution = new SearchInRotatedSortedArraySolution();
            int result = solution.Search(nums, target);
            Assert.Equal(expected, result);
        }

    }
}
