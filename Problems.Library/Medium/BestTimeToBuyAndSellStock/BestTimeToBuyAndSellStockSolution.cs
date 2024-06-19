namespace Problems.Library.Medium.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// Solution for the "Best Time to Buy and Sell Stock" problem.
    /// </summary>
    public class BestTimeToBuyAndSellStockSolution
    {
        /// <summary>
        /// Calculates the maximum profit that can be achieved by buying and selling stocks.
        /// </summary>
        /// <param name="prices">An array of stock prices where prices[i] is the price of a given stock on the ith day.</param>
        /// <returns>The maximum profit that can be achieved.</returns>
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;

            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < prices[i + 1])
                {
                    maxProfit += prices[i + 1] - prices[i];
                }
            }

            return maxProfit;
        }
    }
}
