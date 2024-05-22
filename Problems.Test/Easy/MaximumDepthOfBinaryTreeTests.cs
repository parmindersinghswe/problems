using Problems.Library.Easy.MaximumDepthOfBinaryTree;
using Problems.Library.Models;
using Problems.Test.Services;

namespace Problems.Test.Easy
{
    public class MaximumDepthOfBinaryTreeTests
    {
        public static IEnumerable<object[]> MaxDepthTestData()
        {
            yield return new object[] { new int?[] { 3, 9, 20, null, null, 15, 7 }, 3 };
            yield return new object[] { new int?[] { 1, null, 2 }, 2 };
            yield return new object[] { new int?[] { }, 0 }; 
            yield return new object[] { new int?[] { 1, 2, 3, 4, null, null, 5 }, 3 };
            yield return new object[] { new int?[] { 1 }, 1 }; 
            yield return new object[] { new int?[] { 1, 2, 2, 3, null, null, 3, 4, null, null, 4 }, 4 };
        }

        [Theory]
        [MemberData(nameof(MaxDepthTestData))]
        public void Test_MaxDepth(int?[] treeValues, int expected)
        {
            TreeNode? root = TreeService.CreateTree(treeValues);
            MaximumDepthOfBinaryTreeSolution solution = new MaximumDepthOfBinaryTreeSolution();
            int result = solution.MaxDepth(root);
            Assert.Equal(expected, result);
        }
    }
}
