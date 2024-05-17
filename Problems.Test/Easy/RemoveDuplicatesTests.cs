
namespace Problems.Test.Easy
{
    public class RemoveDuplicatesTests
    {
        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, 2, new int[] { 1, 2 })]
        [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5, new int[] { 0, 1, 2, 3, 4 })]
        public void RemoveDuplicates_Test(int[] nums, int expectedK, int[] expectedNums)
        {
            // Act
            Library.Easy.RemoveDuplicates.RemoveDuplicates solution = new Library.Easy.RemoveDuplicates.RemoveDuplicates();
            int k = solution.Remove(nums);

            // Assert
            Assert.Equal(expectedK, k);
            for (int i = 0; i < k; i++)
            {
                Assert.Equal(expectedNums[i], nums[i]);
            }
        }
    }
}
