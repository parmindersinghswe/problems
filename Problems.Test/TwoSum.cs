namespace Problems.Test
{
    public class TwoSum
    {
        [Fact]
        public void TwoSumTest()
        {
            Library.TwoSum.TwoSumSolution twoSum = new Library.TwoSum.TwoSumSolution();
            int[] result = twoSum.TwoSum([2, 7, 11, 15], 9);
            int[] expected = [0, 1];
            Assert.Equal(result, expected);
            result = twoSum.TwoSum([3, 2, 4], 6);
            expected = [1, 2];
            Assert.Equal(result, expected);
            result = twoSum.TwoSum([3, 3], 6);
            expected = [0, 1];
            Assert.Equal(result, expected);
        }
    }
}
