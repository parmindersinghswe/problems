using Problems.Library.Medium.BestTimeToBuyAndSellStock;

namespace Problems.Test.Medium
{
    public class BestTimeToBuyAndSellStockTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void MaxProfit_ShouldReturnExpectedResult(int[] prices, int expectedProfit)
        {
            var solution = new BestTimeToBuyAndSellStockSolution();
            var result = solution.MaxProfit(prices);
            Assert.Equal(expectedProfit, result);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new int[] { 7, 1, 5, 3, 6, 4 }, 7 }; 
            yield return new object[] { new int[] { 1, 2, 3, 4, 5 }, 4 };   
            yield return new object[] { new int[] { 7, 6, 4, 3, 1 }, 0 };   
            yield return new object[] { new int[] { 1, 2 }, 1 };           
            yield return new object[] { new int[] { 2, 4, 1 }, 2 };        
        }
    }
}
