using Problems.Library.Medium.ThreeSum;

namespace Problems.Test.Medium
{
    public class ThreeSumTests
    {
        public static IEnumerable<object[]> ThreeSumTestData()
        {
            yield return new object[] { new int[] { -1, 0, 1, 2, -1, -4 }, new List<IList<int>> {
            new List<int> { -1, -1, 2 },
            new List<int> { -1, 0, 1 }
        }};
            yield return new object[] { new int[] { 0, 0, 0 }, new List<IList<int>> {
            new List<int> { 0, 0, 0 }
        }};
            yield return new object[] { new int[] { 1, -1, -1, 0 }, new List<IList<int>> {
            new List<int> { -1, 0, 1 }
        }};
            yield return new object[] { new int[] { -2, 0, 1, 1, 2 }, new List<IList<int>> {
            new List<int> { -2, 0, 2 },
            new List<int> { -2, 1, 1 }
        }};
            yield return new object[] { new int[] { -1, 0, 1, 0 }, new List<IList<int>> {
            new List<int> { -1, 0, 1 }
        }};
            yield return new object[] { new int[] { }, new List<IList<int>>() };
            yield return new object[] { new int[] { 0 }, new List<IList<int>>() };
        }

        [Theory]
        [MemberData(nameof(ThreeSumTestData))]
        public void ThreeSum_Test(int[] nums, IList<IList<int>> expected)
        {
            var solution = new ThreeSumSolution();
            IList<IList<int>> result = solution.ThreeSum(nums, 0);
            Assert.Equal(expected.Count, result.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.Equal(expected[i], result[i]);
            }
        }
    }
}
