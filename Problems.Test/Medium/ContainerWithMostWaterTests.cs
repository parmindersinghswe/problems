using Problems.Library.Medium.MaxArea;

namespace Problems.Test.Medium
{
    public class ContainerWithMostWaterTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { new int[] {1, 8, 6, 2, 5, 4, 8, 3, 7}, 49 },
            new object[] { new int[] {1, 1}, 1 },
            new object[] { new int[] {4, 3, 2, 1, 4}, 16 },
            new object[] { new int[] {1, 2, 1}, 2 },
            new object[] { new int[] {1, 3, 2, 5, 25, 24, 5}, 24 },
            new object[] { new int[] {10, 1, 1, 1, 10}, 40 },
            new object[] { new int[] {1, 1, 1, 1, 1, 1, 1, 1}, 7 },
            new object[] { new int[] {3, 9, 3, 4, 7, 2, 12, 6}, 45 }
        };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void MaxArea_Tests(int[] height, int expected)
        {
            var solution = new ContainerWithMostWaterSolution();
            Assert.Equal(expected, solution.MaxArea(height));
        }
    }
}
