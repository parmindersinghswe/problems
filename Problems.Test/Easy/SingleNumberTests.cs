using Problems.Library.Easy.SingleNumber;
namespace Problems.Test.Easy
{
    /// <summary>
    /// Test cases to check the Single number solution.
    /// </summary>
    public class SingleNumberTests
    {
        public static IEnumerable<object[]> SingleNumberTestData()
        {
            yield return new object[] { new int[] { 2, 2, 1 }, 1 };
            yield return new object[] { new int[] { 4, 1, 2, 1, 2 }, 4 };
            yield return new object[] { new int[] { 1 }, 1 };
            yield return new object[] { new int[] { 1, 3, 1, 2, 2 }, 3 };
            yield return new object[] { new int[] { 7, 3, 5, 3, 7 }, 5 };
            yield return new object[] { new int[] { 0, 1, 0 }, 1 };
            yield return new object[] { new int[] { -1, -1, -2 }, -2 };
            yield return new object[] { new int[] { int.MaxValue, int.MinValue, int.MaxValue }, int.MinValue };
        }

        [Theory]
        [MemberData(nameof(SingleNumberTestData))]
        public void Test_SingleNumber(int[] nums, int expected)
        {
            SingleNumberSolution solution = new SingleNumberSolution();
            int result = solution.SingleNumber(nums);
            Assert.Equal(expected, result);
        }
    }
}
