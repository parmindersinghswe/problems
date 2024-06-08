using Problems.Library.Easy.SameTree;
using Problems.Library.Models;
using Problems.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Test.Easy
{
    public class SameTreeTests
    {
        public static IEnumerable<object?[]> GetTestData()
        {
            return new List<object?[]> {
             new object?[] { TreeService.CreateTree([1, 2, 3]), TreeService.CreateTree([1, 2, 3]), true },
             new object?[] { TreeService.CreateTree([1, 2]), TreeService.CreateTree([1, null, 2]), false },
             new object?[] { TreeService.CreateTree([1, 2, 1]), TreeService.CreateTree([1, 1, 2]), false },
             new object?[] { TreeService.CreateTree([]), TreeService.CreateTree([]), true },
             new object?[] { TreeService.CreateTree([1]), TreeService.CreateTree([1]), true },
             new object?[] { TreeService.CreateTree([1]), TreeService.CreateTree([2]), false },
             new object?[] { TreeService.CreateTree([1, 2, 3, 4, 5, 6, 7]), TreeService.CreateTree([1, 2, 3, 4, 5, 6, 7]), true },
             new object?[] { TreeService.CreateTree([1, 2, 3, 4, 5, null, 7]), TreeService.CreateTree([1, 2, 3, 4, 5, null, 7]), true },
             new object?[] { TreeService.CreateTree([1, 2, 3, 4, 5, null, 7]), TreeService.CreateTree([1, 2, 3, 4, null, 6, 7]), false },
             new object?[] { TreeService.CreateTree([1, null, 2]), TreeService.CreateTree([1, null, 2]), true }
        };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
        public void IsSameTree_Tests(TreeNode p, TreeNode q, bool expected)
        {
            var solution = new SameTreeSolution();
            Assert.Equal(expected, solution.IsSameTree(p, q));
        }

    }
}
