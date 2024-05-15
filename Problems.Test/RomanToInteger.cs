namespace Problems.Test
{
    public class RomanToInteger
    {
        [Fact]
        public void RomanToIntegerTest()
        {
            Library.RomanToInteger.RomanToInteger romanToInteger = new Library.RomanToInteger.RomanToInteger();
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
