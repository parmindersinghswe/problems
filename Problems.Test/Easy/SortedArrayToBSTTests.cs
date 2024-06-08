using Problems.Library.Models;
using Problems.Library.Easy.SortedArrayToBST;
using Problems.Library.Easy.BinaryTreeTraversal;

namespace Problems.Test.Easy
{
    public class SortedArrayToBSTTests
    {
        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]> {
            new object[] { new int[] {-10, -3, 0, 5, 9}, new int[] {-10, -3, 0, 5, 9} },
            new object[] { new int[] {1, 3}, new int[] {1, 3} },
            new object[] { new int[] {}, new int[] {} },
            new object[] { new int[] {1}, new int[] {1} },
            new object[] { new int[] {1, 2, 3, 4, 5, 6, 7}, new int[] {1, 2, 3, 4, 5, 6, 7} },
            new object[] { new int[] {1, 2, 3, 4, 5, 6}, new int[] {1, 2, 3, 4, 5, 6} },
            new object[] { new int[] {-5, -4, -3, -2, -1}, new int[] {-5, -4, -3, -2, -1} },
            new object[] { new int[] {100, 200, 300, 400, 500}, new int[] {100, 200, 300, 400, 500} },
            new object[] { new int[] {1, 2, 2, 3, 3, 4, 5, 5, 6, 7, 8}, new int[] {1, 2, 2, 3, 3, 4, 5, 5, 6, 7, 8} },
            new object[] { new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10} },
        };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void SortedArrayToBST_TestCases(int[] nums, int[] expectedInOrder)
        {
            var solution = new SortedArrayToBSTSolution();
            TreeNode? root = solution.SortedArrayToBST(nums);
            var inorderSolution = new BinaryTreeTraversalSolution();
            var resultInOrder = inorderSolution.InorderTraversal(root);
            Assert.Equal(expectedInOrder, resultInOrder);
        }
    }
}
