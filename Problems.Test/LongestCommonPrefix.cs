namespace Problems.Test
{
    public class LongestCommonPrefix
    {
        [Fact]
        public void LongestCommonPrefixTest()
        {
            Library.LongestCommonPrefix.LongestCommonPrefix prefix = new Library.LongestCommonPrefix.LongestCommonPrefix();
            string result = prefix.Solve(["flower", "flow", "flight"]);
            string expected = "fl";
            Assert.Equal(result, expected);
            result = prefix.Solve(["dog", "racecar", "car"]);
            expected = "";
            Assert.Equal(result, expected);
        }
    }
}
