using Problems.Test.Services;
using Problems.Library.Models;
using Problems.Library.Easy.BinaryTreeTraversal;

namespace Problems.Test.Easy
{
    public class BinaryTreeTreversalTests
    {
        public static IEnumerable<object[]> PostorderTraversalTestData()
        {
            yield return new object[] { new int?[] { 1, null, 2, 3 }, new int[] { 3, 2, 1 } };
            yield return new object[] { new int?[] { }, new int[] { } };
            yield return new object[] { new int?[] { 1 }, new int[] { 1 } };
            yield return new object[] { new int?[] { 1, 2, 3, 4, 5, null, 6 }, new int[] { 4, 5, 2, 6, 3, 1 } };
            yield return new object[] { new int?[] { 1, 2, 3, null, 4, null, 5 }, new int[] { 4, 2, 5, 3, 1 } };
            yield return new object[] { new int?[] { 1, null, 2, null, 3, null, 4 }, new int[] { 4, 3, 2, 1 } };
            yield return new object[] { new int?[] { 3, 9, 20, null, null, 15, 7 }, new int[] { 9, 15, 7, 20, 3 } };
            yield return new object[] { new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new int[] { 8, 9, 4, 10, 11, 5, 2, 12, 13, 6, 14, 15, 7, 3, 1 } };
        }

        [Theory]
        [MemberData(nameof(PostorderTraversalTestData))]
        public void PostorderTraversal_Tests(int?[] treeValues, int[] expectedOutput)
        {
            // Arrange
            TreeNode? root = TreeService.CreateTree(treeValues);
            BinaryTreeTraversalSolution solution = new BinaryTreeTraversalSolution();
            // Act
            IList<int> result = solution.PostorderTraversal(root);

            // Assert
            Assert.Equal(expectedOutput, result);
        }
        public static IEnumerable<object[]> PreorderTraversalTestData()
        {
            yield return new object[] { new int?[] { 1, null, 2, 3 }, new int[] { 1, 2, 3 } };
            yield return new object[] { new int?[] { }, new int[] { } };
            yield return new object[] { new int?[] { 1 }, new int[] { 1 } };
            yield return new object[] { new int?[] { 1, 2, 3, 4, 5, null, 6 }, new int[] { 1, 2, 4, 5, 3, 6 } };
            yield return new object[] { new int?[] { 1, 2, 3, null, 4, null, 5 }, new int[] { 1, 2, 4, 3, 5 } };
            yield return new object[] { new int?[] { 1, null, 2, null, 3, null, 4 }, new int[] { 1, 2, 3, 4 } };
            yield return new object[] { new int?[] { 3, 9, 20, null, null, 15, 7 }, new int[] { 3, 9, 20, 15, 7 } };
            yield return new object[] { new int?[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, new int[] { 1, 2, 4, 8, 9, 5, 10, 11, 3, 6, 12, 13, 7, 14, 15 } };
        }

        [Theory]
        [MemberData(nameof(PreorderTraversalTestData))]
        public void Test_PreorderTraversal(int?[] treeValues, int[] expectedOutput)
        {
            // Arrange
            TreeNode? root = TreeService.CreateTree(treeValues);
            BinaryTreeTraversalSolution solution = new BinaryTreeTraversalSolution();
            // Act
            IList<int> result = solution.PreorderTraversal(root);

            // Assert
            Assert.Equal(expectedOutput, result);
        }

        public static IEnumerable<object[]> InorderTraversalTestData()
        {
            yield return new object[] { new TreeNode(1), new int[] { 1 } };
            yield return new object[] {
        new TreeNode(1, null, new TreeNode(2, new TreeNode(3), null)),
        new int[] { 1, 3, 2 }
    };
            yield return new object[] {
        new TreeNode(4,
            new TreeNode(2, new TreeNode(1), new TreeNode(3)),
            new TreeNode(6, new TreeNode(5), new TreeNode(7))
        ),
        new int[] { 1, 2, 3, 4, 5, 6, 7 }
    };
        }


        [Theory]
        [MemberData(nameof(InorderTraversalTestData))]
        public void TestInorderTraversal(TreeNode? input, int[] expected)
        {
            var solution = new BinaryTreeTraversalSolution();
            var result = solution.InorderTraversal(input);
            Assert.Equal(expected, result);
        }
    }
}
