namespace Problems.Test.Easy
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new string[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefix_Test(string[] inputList, string expected)
        {
            Library.Easy.LongestCommonPrefix.LongestCommonPrefix prefix = new Library.Easy.LongestCommonPrefix.LongestCommonPrefix();
            string result = prefix.Solve(inputList);
            Assert.Equal(result, expected);
        }
    }
}
