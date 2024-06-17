using Problems.Library.Medium.RotateArray;
namespace Problems.Test.Medium
{
    public class RotateArrayTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Rotate_Tests(int[] nums, int k, int[] expected)
        {
            var solution = new RotateArraySolution();
            solution.Rotate(nums, k);
            Assert.Equal(expected, nums);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { new int[] {1, 2, 3, 4, 5, 6, 7}, 3, new int[] {5, 6, 7, 1, 2, 3, 4} },
            new object[] { new int[] {-1, -100, 3, 99}, 2, new int[] {3, 99, -1, -100} },
            new object[] { new int[] {1, 2, 3, 4, 5, 6}, 2, new int[] {5, 6, 1, 2, 3, 4} },
            new object[] { new int[] {1, 2, 3}, 4, new int[] {3, 1, 2} },
            new object[] { new int[] {1}, 0, new int[] {1} },
            new object[] { new int[] {1}, 1, new int[] {1} }
        };
        }
    }
}
