using Problems.Library.Easy.RansomNote;
namespace Problems.Test.Easy
{
    public class RansomNoteTests
    {
        public static IEnumerable<object[]> GetTestCases()
        {
            yield return new object[] { "a", "b", false };
            yield return new object[] { "aa", "ab", false };
            yield return new object[] { "aa", "aab", true };
            yield return new object[] { "abc", "abcabc", true };
            yield return new object[] { "", "a", true };
            yield return new object[] { "a", "", false };
        }

        [Theory]
        [MemberData(nameof(GetTestCases))]
        public void CanConstructTests(string ransomNote, string magazine, bool expected)
        {
            var solution = new RansomNoteSolution();
            var result = solution.CanConstruct(ransomNote, magazine);
            Assert.Equal(expected, result);
        }
    }
}
