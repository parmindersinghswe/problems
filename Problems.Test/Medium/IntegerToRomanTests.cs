using Problems.Library.Medium.IntegerToRoman;
namespace Problems.Test.Medium
{
    public class IntegerToRomanTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]>
            {
                new object[] { 1, "I" },
                new object[] { 4, "IV" },
                new object[] { 9, "IX" },
                new object[] { 58, "LVIII" },
                new object[] { 1994, "MCMXCIV" },
                new object[] { 3999, "MMMCMXCIX" }
            };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IntegerToRoman_Tests(int num, string expected)
        {
            var solution = new IntegerToRomanSolution();
            Assert.Equal(expected, solution.IntToRoman(num));
        }

    }
}
