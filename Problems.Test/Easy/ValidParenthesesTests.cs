namespace Problems.Test.Easy
{
    public class ValidParenthesesTests
    {
        [Theory]
        [InlineData("()", true)]
        [InlineData("()[]{}", true)]
        [InlineData("(]", false)]
        [InlineData("([)]", false)]
        [InlineData("{[]}", true)]
        public void IsValid_Test(string input, bool expected)
        {
            Library.Easy.ValidParentheses.ValidParentheses validParentheses = new Library.Easy.ValidParentheses.ValidParentheses();
            bool result = validParentheses.IsValid(input);
            Assert.Equal(expected, result);
        }
    }
}
