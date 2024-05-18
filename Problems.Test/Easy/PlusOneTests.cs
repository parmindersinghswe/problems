using Problems.Library.Easy.PlusOne;

namespace Problems.Test.Easy
{
    public class PlusOneTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
        [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
        [InlineData(new int[] { 9, 9 }, new int[] { 1, 0, 0 })]
        [InlineData(new int[] { 0 }, new int[] { 1 })]
        [InlineData(new int[] { 9, 8, 9 }, new int[] { 9, 9, 0 })]
        public void PlusOne_Tests(int[] input, int[] expected)
        {
            // Arrange
            var solution = new PlusOneSolution();

            // Act
            int[] result = solution.Increment(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
