    public class Solution
    {
        public int CoinChange(int[] coins, int amount)
        {
           var dp = new int[amount + 1];
           for (int i = 1; i <= amount; i++)
           {
                dp[i] = int.MaxValue;
           }

           dp[0] = 0;
           for (int am = 1; am <= amount; am++)
           {
               for (int j = 0; j < coins.Length; j++)
               {
                   var diff = am - coins[j];
                   if (diff >= 0)
                   {
                       var previousDiff = dp[diff];
                       if (previousDiff != int.MaxValue)
                       {
                           // we can find better solution possibly
                            dp[am] = Math.Min(dp[am], previousDiff + 1);
                       }
                   }
               }
           }

           return dp[amount] == int.MaxValue ? -1: dp[amount];
        }
    }
