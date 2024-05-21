using Problems.Library.Easy.PascalTriangle;

namespace Problems.Test.Easy
{
    public class PascalsTriangleTests
    {
        public static IEnumerable<object[]> GenerateTestData()
        {
            yield return new object[] { 0, new List<IList<int>>() };
            yield return new object[] { 1, new List<IList<int>> { new List<int> { 1 } } };
            yield return new object[] { 2, new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 } } };
            yield return new object[] { 3, new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 }, new List<int> { 1, 2, 1 } } };
            yield return new object[] { 4, new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 }, new List<int> { 1, 2, 1 }, new List<int> { 1, 3, 3, 1 } } };
            yield return new object[] { 5, new List<IList<int>> { new List<int> { 1 }, new List<int> { 1, 1 }, new List<int> { 1, 2, 1 }, new List<int> { 1, 3, 3, 1 }, new List<int> { 1, 4, 6, 4, 1 } } };
        }

        [Theory]
        [MemberData(nameof(GenerateTestData))]
        public void PascalsTriangle_Tests(int numRows, IList<IList<int>> expected)
        {
            PascalsTriangleSolution solution = new PascalsTriangleSolution();
            IList<IList<int>> result = solution.Generate(numRows);
            Assert.Equal(expected, result);
        }
    }
}
