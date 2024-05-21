using Problems.Test.Services;
using Problems.Library.Models;
using Problems.Library.Easy.PathSum;

namespace Problems.Test.Easy
{
    public class PathSumTests
    {
        public static IEnumerable<object[]> HasPathSumTestData()
        {
            yield return new object[] { new int?[] { 5, 4, 8, 11, null, 13, 4, 7, 2, null, null, null, 1 }, 22, true };
            yield return new object[] { new int?[] { 1, 2, 3 }, 5, false };
            yield return new object[] { new int?[] { 1, 2 }, 0, false };
            yield return new object[] { new int?[] { }, 0, false };
            yield return new object[] { new int?[] { 1, 2, null, 3, null, 4, null, 5 }, 15, true };
        }

        [Theory]
        [MemberData(nameof(HasPathSumTestData))]
        public void HasPathSum_Tests(int?[] treeValues, int targetSum, bool expected)
        {
            TreeNode root = TreeService.CreateTree(treeValues)!;
            PathSumSolution solution = new PathSumSolution();
            bool result = solution.HasPathSum(root, targetSum);
            Assert.Equal(expected, result);
        }
    }
}
