
using Problems.Library.Easy.Palidrome.NumberPalindrome;

namespace Problems.Test.Easy
{
    public class ValidPalindromeTests
    {
        public static IEnumerable<object[]> IsPalindromeTestData()
        {
            yield return new object[] { "A man, a plan, a canal: Panama", true };
            yield return new object[] { "race a car", false };
            yield return new object[] { " ", true };
            yield return new object[] { "No lemon, no melon", true };
            yield return new object[] { "Was it a car or a cat I saw?", true };
            yield return new object[] { "Able was I, I saw Elba", true };
            yield return new object[] { "0P", false };
        }

        [Theory]
        [MemberData(nameof(IsPalindromeTestData))]
        public void ValidPalindrome_Tests(string s, bool expected)
        {
            ValidPalindromeSolution solution = new ValidPalindromeSolution();
            bool result = solution.IsPalindrome(s);
            Assert.Equal(expected, result);
        }
    }
}
