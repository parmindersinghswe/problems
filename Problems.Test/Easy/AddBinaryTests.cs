using Problems.Library.Easy.AddBinary;

namespace Problems.Test.Easy
{
    public class AddBinaryTests
    {
        [Theory]
        [InlineData("11", "1", "100")]
        [InlineData("1010", "1011", "10101")]
        [InlineData("0", "0", "0")]
        [InlineData("1", "0", "1")]
        [InlineData("0", "1", "1")]
        [InlineData("1111", "1111", "11110")]
        [InlineData("110010", "10111", "1001001")]
        [InlineData("1000000000000000000000000000000", "1", "1000000000000000000000000000001")]
        [InlineData("1111111111111111111111111111111", "1", "10000000000000000000000000000000")]
        [InlineData("1010101010101010101010101010101", "1010101010101010101010101010101", "10101010101010101010101010101010")]
        public void AddBinary_Tests(string a, string b, string expected)
        {
            // Arrange
            var solution = new AddBinarySolution();

            // Act
            string result = solution.AddBinary(a, b);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
