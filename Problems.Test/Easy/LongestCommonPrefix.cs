namespace Problems.Test.Easy
{
    public class LongestCommonPrefix
    {
        [Fact]
        public void LongestCommonPrefixTest()
        {
            Library.Easy.LongestCommonPrefix.LongestCommonPrefix prefix = new Library.Easy.LongestCommonPrefix.LongestCommonPrefix();
            string result = prefix.Solve(["flower", "flow", "flight"]);
            string expected = "fl";
            Assert.Equal(result, expected);
            result = prefix.Solve(["dog", "racecar", "car"]);
            expected = "";
            Assert.Equal(result, expected);
        }
    }
}
