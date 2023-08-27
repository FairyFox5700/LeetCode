    public class Solution
    {
        public int MaxProfit(int[] prices, int fee)
        {
            var bestEffectivePriceToBuy = prices[0];
            var currentProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                var currentProfitWithTransaction = prices[i] - bestEffectivePriceToBuy - fee;

                currentProfit = Math.Max(currentProfitWithTransaction, currentProfit);
                bestEffectivePriceToBuy = Math.Min(bestEffectivePriceToBuy, prices[i] -currentProfit);
            }

            return currentProfit;
        }
        //prices = [1,3,2,8,4,9], fee = 2
    }