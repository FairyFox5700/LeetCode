    public class Solution
    {
        public int Change(int amount, int[] coins)
        {
            var dp = new int[coins.Length+1, amount +1];
            // last column is the amount filled with 1, because for amount of 0, we can always fill it with 1
            for (int i = 0; i < coins.Length; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = coins.Length - 1; i >= 0; i--)
            {
                for (int j = 1; j <= amount; j++)
                {
                    if (coins[i] > j)
                    {
                        dp[i, j] = dp[i + 1, j];// result without the current coin
                    }
                    else
                    {
                        dp[i,j] = dp[i, j -coins[i]] + dp[i+1, j];
                        //  j -coins[i] - is a rest
                        // for instance the amount is 5, and the coins is 5 - then we add the result from dp[i,1] (to sum up to this amount)
                    }
                }
            }

            return dp[0, amount];
        }
    }