
using Problems.Library.Medium.RandomizedSet;

namespace Problems.Test.Medium
{
    public class RandomizedSetTests
    {
        [Theory]
        [MemberData(nameof(InsertTestData))]
        public void Insert_ShouldReturnExpectedResult(int[] initialValues, int val, bool expectedResult)
        {
            var solution = new RandomizedSetSolution();
            foreach (var initialValue in initialValues)
            {
                solution.Insert(initialValue);
            }
            var result = solution.Insert(val);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(RemoveTestData))]
        public void Remove_ShouldReturnExpectedResult(int[] initialValues, int val, bool expectedResult)
        {
            var solution = new RandomizedSetSolution();
            foreach (var initialValue in initialValues)
            {
                solution.Insert(initialValue);
            }
            var result = solution.Remove(val);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(RandomTestData))]
        public void GetRandom_ShouldReturnElementFromSet(int[] initialValues)
        {
            var solution = new RandomizedSetSolution();
            var set = new HashSet<int>(initialValues);
            foreach (var initialValue in initialValues)
            {
                solution.Insert(initialValue);
            }
            var randomElement = solution.GetRandom();
            Assert.Contains(randomElement, set);
        }

        public static IEnumerable<object[]> InsertTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3 }, 4, true };
            yield return new object[] { new int[] { 1, 2, 3 }, 3, false };
            yield return new object[] { new int[] { }, 1, true };
        }

        public static IEnumerable<object[]> RemoveTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3 }, 2, true };
            yield return new object[] { new int[] { 1, 2, 3 }, 4, false };
            yield return new object[] { new int[] { }, 1, false };
        }

        public static IEnumerable<object[]> RandomTestData()
        {
            yield return new object[] { new int[] { 1, 2, 3 } };
            yield return new object[] { new int[] { 5 } };
        }
    }
}
