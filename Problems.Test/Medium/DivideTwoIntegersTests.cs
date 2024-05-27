using Problems.Library.Medium.DivideTwoIntegers;

namespace Problems.Test.Medium
{
    public class DivideTwoIntegersTests
    {
        public static IEnumerable<object[]> DivideTestData()
        {
            yield return new object[] { 10, 3, 3 };
            yield return new object[] { 7, -3, -2 };
            yield return new object[] { 0, 1, 0 };
            yield return new object[] { 1, 1, 1 };
            yield return new object[] { -1, 1, -1 };
            yield return new object[] { Int32.MinValue, -1, Int32.MaxValue };
            yield return new object[] { Int32.MinValue, 1, Int32.MinValue };
            yield return new object[] { Int32.MaxValue, 1, Int32.MaxValue };
            yield return new object[] { -10, 2, -5 };
            yield return new object[] { 100, 10, 10 };
            yield return new object[] { -100, -10, 10 };
            yield return new object[] { 15, 2, 7 };
            yield return new object[] { 1, -1, -1 };
            yield return new object[] { -1, -1, 1 };
            yield return new object[] { 100, -3, -33 };
            yield return new object[] { Int32.MinValue, Int32.MaxValue, -1 }; 
            yield return new object[] { 5, Int32.MaxValue, 0 };
            yield return new object[] { Int32.MaxValue, Int32.MinValue, 0 };
            yield return new object[] { 0, -1, 0 };
            yield return new object[] { -1, 2, 0 };
        }

        [Theory]
        [MemberData(nameof(DivideTestData))]
        public void DivideTwoIntegers_Test(int dividend, int divisor, int expected)
        {
            var solution = new DivideTwoIntegersSolution();
            int result = solution.Divide(dividend, divisor);
            Assert.Equal(expected, result);
        }
    }
}
