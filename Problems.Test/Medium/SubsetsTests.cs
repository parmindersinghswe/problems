using Problems.Library.Medium.Subsets;
namespace Problems.Test.Medium
{
    public class SubsetsTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void Subsets_TestCases(int[] nums, IList<IList<int>> expected)
        {
            var solution = new SubsetsSolution();
            var result = solution.Subsets(nums);
            Assert.Equal(expected.Count, result.Count);
            foreach (var subset in expected)
            {
                Assert.Contains(subset, result);
            }
        }

        public static IEnumerable<object[]> GetTestData()
        {
            return new List<object[]>{
          new object[]{
              new int[]{1, 2, 3},
              new List<IList<int>>{
                  new List<int>(), new List<int>{1}, new List<int>{2},
                  new List<int>{3}, new List<int>{1, 2}, new List<int>{1, 3},
                  new List<int>{2, 3}, new List<int>{1, 2, 3}}},
          new object[]{new int[]{0},
                       new List<IList<int>>{new List<int>(), new List<int>{0}}},
          new object[]{new int[]{}, new List<IList<int>>{new List<int>()}},
          new object[]{
              new int[]{1, 2},
              new List<IList<int>>{new List<int>(), new List<int>{1},
                                   new List<int>{2}, new List<int>{1, 2}}},
          new object[]{new int[]{4, 5, 6},
                       new List<IList<int>>{
                           new List<int>(),
                           new List<int>{4}, new List<int>{5}, new List<int>{6},
                           new List<int>{4, 5}, new List<int>{4, 6},
                           new List<int>{5, 6}, new List<int>{4, 5, 6}}},
          new object[]{
              new int[]{7, 8, 9, 10},
              new List<IList<int>>{
                  new List<int>(),
                  new List<int>{7}, new List<int>{8}, new List<int>{9},
                  new List<int>{10}, new List<int>{7, 8}, new List<int>{7, 9},
                  new List<int>{7, 10}, new List<int>{8, 9},
                  new List<int>{8, 10}, new List<int>{9, 10},
                  new List<int>{7, 8, 9}, new List<int>{7, 8, 10},
                  new List<int>{7, 9, 10}, new List<int>{8, 9, 10},
                  new List<int>{7, 8, 9, 10}}},
          new object[]{
              new int[]{-1, -2, -3},
              new List<IList<int>>{new List<int>(), new List<int>{-1},
                                   new List<int>{-2}, new List<int>{-3},
                                   new List<int>{-1, -2}, new List<int>{-1, -3},
                                   new List<int>{-2, -3},
                                   new List<int>{-1, -2, -3}}},
          new object[]{
              new int[]{0, 1, 2, 3},
              new List<IList<int>>{
                  new List<int>(),
                  new List<int>{0}, new List<int>{1}, new List<int>{2},
                  new List<int>{3}, new List<int>{0, 1}, new List<int>{0, 2},
                  new List<int>{0, 3}, new List<int>{1, 2}, new List<int>{1, 3},
                  new List<int>{2, 3}, new List<int>{0, 1, 2},
                  new List<int>{0, 1, 3}, new List<int>{0, 2, 3},
                  new List<int>{1, 2, 3}, new List<int>{0, 1, 2, 3}}},
          new object[]{
              new int[]{100},
              new List<IList<int>>{new List<int>(), new List<int>{100}}},
          new object[]{
              new int[]{1, 1},
              new List<IList<int>>{new List<int>(), new List<int>{1},
                                   new List<int>{1}, new List<int>{1, 1}}},
          new object[]{new int[]{2, 3, 4},
                       new List<IList<int>>{
                           new List<int>{},
                           new List<int>{2}, new List<int>{3}, new List<int>{4},
                           new List<int>{2, 3}, new List<int>{2, 4},
                           new List<int>{3, 4}, new List<int>{2, 3, 4}}},
          new object[]{new int[]{1, 2, 2},
                       new List<IList<int>>{
                           new List<int>{},
                           new List<int>{1}, new List<int>{2}, new List<int>{2},
                           new List<int>{1, 2}, new List<int>{1, 2},
                           new List<int>{2, 2}, new List<int>{1, 2, 2}}},
          new object[]{new int[]{1, 1, 2},
                       new List<IList<int>>{
                           new List<int>{},
                           new List<int>{1}, new List<int>{1}, new List<int>{2},
                           new List<int>{1, 1}, new List<int>{1, 2},
                           new List<int>{1, 2}, new List<int>{1, 1, 2}}},
          new object[]{new int[]{2, 2, 2},
                       new List<IList<int>>{
                           new List<int>{},
                           new List<int>{2}, new List<int>{2}, new List<int>{2},
                           new List<int>{2, 2}, new List<int>{2, 2},
                           new List<int>{2, 2}, new List<int>{2, 2, 2}}},
          new object[]{new int[]{3, 2, 1},
                       new List<IList<int>>{
                           new List<int>{},
                           new List<int>{3}, new List<int>{2}, new List<int>{1},
                           new List<int>{3, 2}, new List<int>{3, 1},
                           new List<int>{2, 1}, new List<int>{3, 2, 1}}},
          new object[]{new int[]{5, 5, 5},
                       new List<IList<int>>{
                           new List<int>{},
                           new List<int>{5}, new List<int>{5}, new List<int>{5},
                           new List<int>{5, 5}, new List<int>{5, 5},
                           new List<int>{5, 5}, new List<int>{5, 5, 5}}},
          new object[]{
              new int[]{1, 2, 3, 4, 5},
              new List<IList<int>>{
                  new List<int>{},           new List<int>{1},
                  new List<int>{2},          new List<int>{3},
                  new List<int>{4},          new List<int>{5},
                  new List<int>{1, 2},       new List<int>{1, 3},
                  new List<int>{1, 4},       new List<int>{1, 5},
                  new List<int>{2, 3},       new List<int>{2, 4},
                  new List<int>{2, 5},       new List<int>{3, 4},
                  new List<int>{3, 5},       new List<int>{4, 5},
                  new List<int>{1, 2, 3},    new List<int>{1, 2, 4},
                  new List<int>{1, 2, 5},    new List<int>{1, 3, 4},
                  new List<int>{1, 3, 5},    new List<int>{1, 4, 5},
                  new List<int>{2, 3, 4},    new List<int>{2, 3, 5},
                  new List<int>{2, 4, 5},    new List<int>{3, 4, 5},
                  new List<int>{1, 2, 3, 4}, new List<int>{1, 2, 3, 5},
                  new List<int>{1, 2, 4, 5}, new List<int>{1, 3, 4, 5},
                  new List<int>{2, 3, 4, 5}, new List<int>{1, 2, 3, 4, 5}}}
            };
        }
    }
}
