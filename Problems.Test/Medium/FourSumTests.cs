using Problems.Library.Medium.FourSum;

namespace Problems.Test.Medium
{
    public class FourSumTests
    {
        public static IEnumerable<object[]> FourSumTestData()
        {
            yield return new object[] { new int[] { 1, 0, -1, 0, -2, 2 }, 0, new List<IList<int>> {
            new List<int> { -2, -1, 1, 2 },
            new List<int> { -2, 0, 0, 2 },
            new List<int> { -1, 0, 0, 1 }
        }};
            yield return new object[] { new int[] { 2, 2, 2, 2, 2 }, 8, new List<IList<int>> {
            new List<int> { 2, 2, 2, 2 }
        }};
            yield return new object[] { new int[] { -1, 0, 1, 2, -1, -4 }, -1, new List<IList<int>> {
            new List<int> { -4, 0, 1, 2 },
            new List<int> { -1, -1, 0, 1 }
        }};
            yield return new object[] { new int[] { 0, 0, 0, 0 }, 0, new List<IList<int>> {
            new List<int> { 0, 0, 0, 0 }
        }};
            yield return new object[] { new int[] { 1, 1, 1, 1, 1 }, 4, new List<IList<int>> {
            new List<int> { 1, 1, 1, 1 }
        }};
            yield return new object[] { new int[] { 1, 0, -1, 0, -2, 2, -1, 1 }, 0, new List<IList<int>> {
                new List<int> { -2, -1, 1, 2 },
                new List<int> { -2, 0, 0, 2 },
                new List<int> { -1, -1, 1, 1 },
                new List<int> { -1, 0, 0, 1 },
                new List<int> {-2, 0, 1, 1 },
                new List<int> {-1, -1, 0, 2 }
            }};
        }

        [Theory]
        [MemberData(nameof(FourSumTestData))]
        public void FourSum_Test(int[] nums, int target, IList<IList<int>> expected)
        {
            var solution = new FourSumSolution();
            IList<IList<int>> result = solution.FourSum(nums, target);
            Assert.Equal(expected.Count, result.Count);
            var sortedExpected = expected.Select(list => list.OrderBy(x => x).ToList()).OrderBy(list => string.Join(",", list)).ToList();
            var sortedResult = result.Select(list => list.OrderBy(x => x).ToList()).OrderBy(list => string.Join(",", list)).ToList();
            for (int i = 0; i < sortedExpected.Count; i++)
            {
                Assert.Equal(sortedExpected[i], sortedResult[i]);
            }
        }
    }
}
