using Problems.Test.Services;
using Problems.Library.Models;

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

        [Theory]
        [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2 })] // Example 1
        [InlineData(new int[] { 1, 1, 2, 3, 3 }, new int[] { 1, 2, 3 })] // Example 2
        [InlineData(new int[] { 1, 1, 1 }, new int[] { 1 })] // Additional test case
        [InlineData(new int[] { 1, 2, 2, 3, 3, 3, 4 }, new int[] { 1, 2, 3, 4 })] // Additional test case
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })] // Additional test case
        [InlineData(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1 })] // Additional test case
        [InlineData(new int[] { 2, 2, 2, 3, 3, 4, 4, 4, 4 }, new int[] { 2, 3, 4 })] // Additional test case
        [InlineData(new int[] { 1, 2, 2, 3, 4, 4, 5, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })] // Additional test case
        [InlineData(new int[] { }, new int[] { })] // Empty list test case
        [InlineData(new int[] { 1 }, new int[] { 1 })] // Single element list test case
        public void DeleteDuplicatesFromLinkedList_Test(int[] inputArray, int[] expectedArray)
        {
            Library.Easy.RemoveDuplicates.RemoveDuplicates solution = new Library.Easy.RemoveDuplicates.RemoveDuplicates();
            // Arrange
            ListNode? inputList = LinkedListService.CreateLinkedList(inputArray);
            ListNode? expectedList = LinkedListService.CreateLinkedList(expectedArray);

            // Act
            ListNode? actualList = solution.Remove(inputList);

            // Assert
            Assert.True(LinkedListService.CompareLinkedLists(expectedList, actualList));
        }
    }
}
