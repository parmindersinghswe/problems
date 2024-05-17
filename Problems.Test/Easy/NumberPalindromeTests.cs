using Problems.Library.Easy.Palidrom.NumberPalidrom;

namespace Problems.Test.Easy
{
    public class NumberPalindromeTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(0, true)]
        [InlineData(12321, true)]
        public void IsPalindrome_Test(int input, bool expected)
        {
            NumberPalindromeSolution palindrome = new NumberPalindromeSolution();
            bool result = palindrome.IsPalindrome(input);
            Assert.Equal(expected, result);
        }

    }
}
