namespace Problems.Test.Easy
{
    public class RemoveElement
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 2, 3 }, 3, 2, new int[] { 2, 2 })]
        [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5, new int[] { 0, 1, 4, 0, 3 })]
        public void RemoveElementTest(int[] nums, int val, int expectedK, int[] expectedNums)
        {
            // Arrange
            Library.Easy.RemoveElement.RemoveElement solution = new Library.Easy.RemoveElement.RemoveElement();

            // Act
            int k = solution.Remove(nums, val);

            // Assert
            Assert.Equal(expectedK, k);
            Array.Sort(nums, 0, k); // Sort the first k elements
            Array.Sort(expectedNums);
            for (int i = 0; i < k; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }

    }
}
