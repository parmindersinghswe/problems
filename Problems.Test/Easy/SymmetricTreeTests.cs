using Problems.Library.Models;
using Problems.Library.Easy.SymmetricTree;

namespace Problems.Test.Easy
{
    public class SymmetricTreeTests
    {
        public static IEnumerable<object[]> GetTestData()
        {            var symmetricTree = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(3),
                    new TreeNode(4)
                ),
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(3)
                )
            );
            var asymmetricTree = new TreeNode(1,
                new TreeNode(2,
                    null,
                    new TreeNode(3)
                ),
                new TreeNode(2,
                    null,
                    new TreeNode(3)
                )
            );

            var singleNodeTree = new TreeNode(1);

            TreeNode nullTree = null;

            return new List<object[]> {
            new object[] { symmetricTree, true },
            new object[] { asymmetricTree, false },
            new object[] { singleNodeTree, true },
            new object[] { nullTree, true }
        };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IsSymmetric_TestCases(TreeNode root, bool expected)
        {
            var solution = new SymmetricTreeSolution();
            Assert.Equal(expected, solution.IsSymmetric(root));
        }
    }
}
