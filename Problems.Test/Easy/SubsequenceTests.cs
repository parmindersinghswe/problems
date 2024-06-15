using Problems.Library.Easy.Subsequence;
namespace Problems.Test.Easy
{
    public class SubsequenceTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IsSubsequence_Tests(string s, string t, bool expected)
        {
            var solution = new SubsequenceSolution();
            bool result = solution.IsSubsequence(s, t);
            Assert.Equal(expected, result);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { "abc", "ahbgdc", true },
            new object[] { "axc", "ahbgdc", false },
            new object[] { "", "ahbgdc", true },
            new object[] { "abc", "", false },
            new object[] { "", "", true },
            new object[] { "ace", "abcde", true },
            new object[] { "aec", "abcde", false },
            new object[] { "aaaa", "bbaaaa", true },
            new object[] { "acb", "ahbgdc", false },
            new object[] { "a", "b", false },
            new object[] { "a", "a", true },
            new object[] { "a", "ba", true },
            new object[] { "abc", "abcdabc", true },
            new object[] { "abc", "abdabac", true },
            new object[] { "abc", "bacab", false }
        };
        }
    }
}
