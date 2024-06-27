using Problems.Library.Medium.HIndex;
namespace Problems.Test.Medium
{
    public class HIndexTests
    {
        public static IEnumerable<object[]> HIndexTestData =>
           new List<object[]>
           {
                new object[] { new int[] { 3, 0, 6, 1, 5 }, 3 },
                new object[] { new int[] { 1, 3, 1 }, 1 },
                new object[] { new int[] { 0, 0, 0 }, 0 },
                new object[] { new int[] { 100 }, 1 },
                new object[] { new int[] { 11, 15, 6, 5, 10 }, 5 },
                new object[] { new int[] { 25, 8, 5, 3, 3 }, 3 }
           };

        [Theory]
        [MemberData(nameof(HIndexTestData))]
        public void HIndex_ShouldReturnCorrectHIndex(int[] citations, int expected)
        {
            var solution = new HIndexSolution();
            var result = solution.HIndex(citations);
            Assert.Equal(expected, result);
        }
    }
}
