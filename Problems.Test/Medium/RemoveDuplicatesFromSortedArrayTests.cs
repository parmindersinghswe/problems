using Problems.Library.Medium.RemoveDuplicatesFromSortedArray;

namespace Problems.Test.Medium
{
    public class RemoveDuplicatesFromSortedArrayTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void RemoveDuplicates_Tests(int[] nums, int expectedLength, int[] expectedNums)
        {
            var solution = new RemoveDuplicatesFromSortedArraySolution();
            int resultLength = solution.RemoveDuplicates(nums);
            Assert.Equal(expectedLength, resultLength);
            for (int i = 0; i < expectedLength; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { new int[] {1, 1, 1, 2, 2, 3}, 5, new int[] {1, 1, 2, 2, 3} },
            new object[] { new int[] {0, 0, 1, 1, 1, 1, 2, 3, 3}, 7, new int[] {0, 0, 1, 1, 2, 3, 3} },
            new object[] { new int[] {}, 0, new int[] {} },
            new object[] { new int[] {1}, 1, new int[] {1} },
            new object[] { new int[] {1, 1, 2, 2, 2, 3}, 5, new int[] {1, 1, 2, 2, 3} },
            new object[] { new int[] {1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4}, 7, new int[] {1, 2, 2, 3, 3, 4, 4} }
        };
        }
    }
}
