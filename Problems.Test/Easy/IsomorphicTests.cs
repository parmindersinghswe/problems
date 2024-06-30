using Problems.Library.Easy.Isomorphic;

namespace Problems.Test.Easy
{
    public class IsomorphicTests
    {
        [Theory]
        [InlineData("egg", "add", true)]
        [InlineData("foo", "bar", false)]
        [InlineData("paper", "title", true)]
        [InlineData("abc", "abc", true)]
        [InlineData("a", "b", true)]
        [InlineData("", "", true)]
        [InlineData("abab", "caca", true)]
        [InlineData("ab", "aa", false)]
        public void IsIsomorphic_Tests(string s, string t, bool expected)
        {
            var solution = new IsomorphicSolution();
            var result = solution.IsIsomorphic(s, t);
            Assert.Equal(expected, result);
        }
    }
}
