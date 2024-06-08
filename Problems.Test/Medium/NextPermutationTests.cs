using Problems.Library.Medium.NextPermutation;

namespace Problems.Test.Medium
{
    public class NextPermutationTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { new int[] {1, 2, 3}, new int[] {1, 3, 2} },
            new object[] { new int[] {3, 2, 1}, new int[] {1, 2, 3} },
            new object[] { new int[] {1, 1, 5}, new int[] {1, 5, 1} },
            new object[] { new int[] {1, 3, 2}, new int[] {2, 1, 3} },
            new object[] { new int[] {2, 3, 1}, new int[] {3, 1, 2} },
            new object[] { new int[] {1, 5, 1}, new int[] {5, 1, 1} },
            new object[] { new int[] {2, 4, 3, 2, 1}, new int[] {3, 1, 2, 2, 4} },
            new object[] { new int[] {1, 4, 3, 2}, new int[] {2, 1, 3, 4} },
            new object[] { new int[] {1, 3, 5, 4, 2}, new int[] {1, 4, 2, 3, 5} },
            new object[] { new int[] {1, 1, 1, 2}, new int[] {1, 1, 2, 1} },
            new object[] { new int[] {1}, new int[] {1} },
            new object[] { new int[] {1, 2, 4, 3}, new int[] {1, 3, 2, 4} },
            new object[] { new int[] {4, 2, 0, 2, 3, 2, 0}, new int[] {4, 2, 0, 3, 0, 2, 2} },
            new object[] { new int[] {2, 3, 1, 3, 3}, new int[] {2, 3, 3, 1, 3} },
            new object[] { new int[] {3, 2, 1, 4, 3}, new int[] {3, 2, 3, 1, 4} },
            new object[] { new int[] {1, 5, 8, 4, 7, 6, 5, 3, 1}, new int[] {1, 5, 8, 5, 1, 3, 4, 6, 7} }
        };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void NextPermutation_TestCases(int[] nums, int[] expected)
        {
            var solution = new NextPermutationSolution();
            solution.NextPermutation(nums);
            Assert.Equal(expected, nums);
        }
    }
}
