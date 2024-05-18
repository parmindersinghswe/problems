using Problems.Library.Easy.MySqrt;
namespace Problems.Test.Easy
{
    public class MySqrtTests
    {
        [Theory]
        [InlineData(4, 2)]    
        [InlineData(8, 2)]    
        [InlineData(0, 0)]    
        [InlineData(1, 1)]    
        [InlineData(15, 3)]   
        [InlineData(16, 4)]   
        [InlineData(25, 5)]   
        [InlineData(27, 5)]   
        [InlineData(100, 10)] 
        public void MySqrt_Tests(int input, int expectedOutput)
        {
            var solution = new MySqrtSolution();
            // Act
            int actualOutput = solution.Find(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
