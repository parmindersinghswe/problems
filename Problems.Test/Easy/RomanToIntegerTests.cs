namespace Problems.Test.Easy
{
    public class RomanToIntegerTests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("XL", 40)]
        public void RomanToInt_Test(string input, int expected)
        {
            Library.Easy.RomanToInteger.RomanToInteger romanToInteger = new Library.Easy.RomanToInteger.RomanToInteger();
            int result = romanToInteger.RomanToInt(input);
            Assert.Equal(expected, result);
        }
    }
}
