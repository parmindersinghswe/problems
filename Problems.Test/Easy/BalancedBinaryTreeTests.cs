using Problems.Library.Easy.BalancedBinaryTree;
using Problems.Library.Models;
using Problems.Test.Services;

namespace Problems.Test.Easy
{
    public class BalancedBinaryTreeTests
    {
        public static IEnumerable<object?[]> GetTestData()
        {
            return new List<object?[]> {
            new object?[] { TreeService.CreateTree([3, 9, 20, null, null, 15, 7]), true },
            new object ?[] { TreeService.CreateTree([1, 2, 2, 3, 3, null, null, 4, 4]), false },
             new object?[] { TreeService.CreateTree([]), true }, 
             new object?[] { TreeService.CreateTree([1]), true }, 
             new object?[] { TreeService.CreateTree([1, 2, 2, 3, null, null, 3, 4, null, null, 4]), false },
             new object?[] { TreeService.CreateTree([1, 2, 2, 3, null, null, 3, 4, null, null, 4, null, null, null, 5]), false },
             new object?[] { TreeService.CreateTree([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15]), true },
             new object?[] { TreeService.CreateTree([1, 2, 2, 3, null, null, 3, 4, null, null, 4, 5]), false },
             new object?[] { TreeService.CreateTree([1, null, 2, null, 3, null, 4, null, 5]), false },
             new object?[] { TreeService.CreateTree([10, 5, 15, 2, 7, null, 20, 1, null, null, 8]), true },
             new object?[] { TreeService.CreateTree([1, 2, null, 3, null, 4]), false },
             new object?[] { TreeService.CreateTree([1, null, 2, null, 3, null, 4, null, 5, 6]), false },
             new object?[] { TreeService.CreateTree([1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4]), true },
             new object?[] { TreeService.CreateTree([1, 2, 2, 3, 3, null, null, 4, 4, 4, null, null, null, null, 5]), false },
        };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IsBalanced_Tests(TreeNode root, bool expected)
        {
            var solution = new BalancedBinaryTreeSolution();
            Assert.Equal(expected, solution.IsBalanced(root));
        }
    }
}
