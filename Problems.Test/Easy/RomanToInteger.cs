namespace Problems.Test.Easy
{
    public class RomanToInteger
    {
        [Fact]
        public void RomanToIntegerTest()
        {
            Library.Easy.RomanToInteger.RomanToInteger romanToInteger = new Library.Easy.RomanToInteger.RomanToInteger();
            int result = romanToInteger.RomanToInt("III");
            int expected = 3;
            Assert.Equal(result, expected);
            result = romanToInteger.RomanToInt("LVIII");
            expected = 58;
            Assert.Equal(result, expected);
            result = romanToInteger.RomanToInt("MCMXCIV");
            expected = 1994;
            Assert.Equal(result, expected);
        }
    }
}
