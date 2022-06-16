public class Solution {
        public int MaxProfit(int[] prices)
        {
            var maxProfit = 0;
            var buy = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (buy > prices[i])
                {
                    buy = prices[i];
                }
                else if (prices[i] - buy > maxProfit)
                {
                    maxProfit = prices[i] - buy;
                }
            }

            return maxProfit;
        }
}