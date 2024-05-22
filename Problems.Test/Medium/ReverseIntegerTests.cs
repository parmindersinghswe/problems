using Problems.Library.Medium.ReverseInteger;

namespace Problems.Test.Medium
{
    public class ReverseIntegerTests
    {
        public static IEnumerable<object[]> ReverseTestData()
        {
            yield return new object[] { 123, 321 };
            yield return new object[] { -123, -321 };
            yield return new object[] { 120, 21 };
            yield return new object[] { 0, 0 };
            yield return new object[] { 1534236469, 0 };
            yield return new object[] { -2147483648, 0 };
            yield return new object[] { 2147483647, 0 };
            yield return new object[] { 1463847412, 2147483641 };
            yield return new object[] { -1463847412, -2147483641 };
            yield return new object[] { 1056389759, 0 };
            yield return new object[] { -1056389759, 0 };
        }

        [Theory]
        [MemberData(nameof(ReverseTestData))]
        public void Test_Reverse(int x, int expected)
        {
            ReverseIntegerSolution solution = new ReverseIntegerSolution();
            int result = solution.Reverse(x);
            Assert.Equal(expected, result);
        }
    }
}
