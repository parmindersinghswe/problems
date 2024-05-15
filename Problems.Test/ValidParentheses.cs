namespace Problems.Test
{
    public class ValidParentheses
    {
        [Fact]
        public void ValidParenthesesTest()
        {
            Library.ValidParentheses.ValidParentheses validParentheses = new Library.ValidParentheses.ValidParentheses();
            bool result = validParentheses.IsValid("()");
            bool expected = true;
            Assert.Equal(result, expected);
            result = validParentheses.IsValid("()[]{}");
            expected = true;
            Assert.Equal(result, expected);
            result = validParentheses.IsValid("(]");
            expected = false;
            Assert.Equal(result, expected);
        }
    }
}
