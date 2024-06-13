using Problems.Library.Hard.ValidNumber;
namespace Problems.Test.Hard
{
    public class ValidNumberTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IsNumber_Tests(string s, bool expected)
        {
            var solution = new ValidNumberSolution();
            bool result = solution.IsNumber(s);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { "0", true },
            new object[] { " 0.1 ", true },
            new object[] { "abc", false },
            new object[] { "1 a", false },
            new object[] { "2e10", true },
            new object[] { " -90e3   ", true },
            new object[] { " 1e", false },
            new object[] { "e3", false },
            new object[] { " 6e-1", true },
            new object[] { " 99e2.5 ", false },
            new object[] { "53.5e93", true },
            new object[] { " --6 ", false },
            new object[] { "-+3", false },
            new object[] { "95a54e53", false },
            new object[] { " ", false },
            new object[] { ".1", true },
            new object[] { "3.", true },
            new object[] { "+.8", true },
            new object[] { "46.e3", true },
            new object[] { ".e1", false },
            new object[] { "6e6.5", false },
            new object[] { " -.", false }
        };
        }
    }
}
