using Problems.Library.Easy.LengthOfLastWord;
namespace Problems.Test.Easy
{
    public class LengthOfLastWordTests
    {
        [Theory]
        [InlineData("Hello World", 5)]
        [InlineData("   fly me   to   the moon  ", 4)]
        [InlineData("luffy is still joyboy", 6)]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("a ", 1)]
        public void LengthOfLastWord_ShouldReturnExpectedResult(string input, int expected)
        {
            // Arrange
            var solution = new LengthOfLastWordSolution();

            // Act
            int result = solution.Length(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
