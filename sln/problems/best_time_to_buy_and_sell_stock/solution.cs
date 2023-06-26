public class Solution {
    public int MaxProfit(int[] prices) {
        var profit = 0;
      
        // the idea is that we will get the largest profit if the different is the largest, aka: first number should be the min
        // assume that first is the min
        var min = prices[0];
        for(int i = 0; i < prices.Count(); i++)
        {
            if(prices[i] < min) 
            {
                min = prices[i];
            }
            else 
            {
                // calcualte profit
                var  currentProfix =  prices[i] - min;
                profit = Math.Max(profit,currentProfix);
            }
        }
        return profit;
    }
}