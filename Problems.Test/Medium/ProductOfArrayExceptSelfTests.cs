using Problems.Library.Medium.ProductOfArrayExceptSelf;

namespace Problems.Test.Medium
{
    public class ProductOfArrayExceptSelfTests
    {
        [Theory]
        [MemberData(nameof(ProductExceptSelfTestData))]
        public void ProductExceptSelf_ShouldReturnExpectedResult(int[] nums, int[] expected)
        {
            var solution = new ProductOfArrayExceptSelfSolution();
            var result = solution.ProductExceptSelf(nums);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> ProductExceptSelfTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 } };
            yield return new object[] { new int[] { 0, 0 }, new int[] { 0, 0 } };
            yield return new object[] { new int[] { 0, 4, 0 }, new int[] { 0, 0, 0 } };
            yield return new object[] { new int[] { 1, 0 }, new int[] { 0, 1 } };
            yield return new object[] { new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 } };
        }
    }
}
