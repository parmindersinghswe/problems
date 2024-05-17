using Problems.Library.Easy.FindIndexOfFirstOccurence;
namespace Problems.Test.Easy
{
    public class FindIndexOfFirstOccurenceTests
    {
        [Theory]
        [InlineData("sadbutsad", "sad", 0)]
        [InlineData("leetcode", "leeto", -1)]
        [InlineData("hello", "ll", 2)]
        [InlineData("aaaaa", "bba", -1)]
        [InlineData("", "", 0)]
        [InlineData("a", "", 0)]
        [InlineData("", "a", -1)]
        public void Find_Test(string haystack, string needle, int expected)
        {
            FindIndexOfFirstOccurenceSolution solution = new FindIndexOfFirstOccurenceSolution();
            int result = solution.Find(haystack, needle);
            Assert.Equal(expected, result);
        }
    }
}
