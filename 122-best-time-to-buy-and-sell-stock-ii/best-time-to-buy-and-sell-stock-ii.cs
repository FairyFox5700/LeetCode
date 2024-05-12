public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int i = 0;
        int maxprofit = 0;
        while (i < prices.Length - 1)
        {
            // Find the valley
            while (i < prices.Length - 1 && prices[i] >= prices[i + 1])
            {
                i++;
            }
            int valley = prices[i];
            
            // Find the peak
            while (i < prices.Length - 1 && prices[i] <= prices[i + 1])
            {
                i++;
            }
            int peak = prices[i];
            
            // Calculate the profit for this valley-peak pair
            maxprofit += peak - valley;
        }
        
        return maxprofit;
    }
}
