    public class Solution
    {
        public int[] CountBits(int n)
        {
            var dp = new int[n + 1];
            dp[0] = 0;
            var offsetSoFar = 1;
            for(int i = 1; i<=n; i++)
            {
                var nextoffset = offsetSoFar * 2; // power of two
                if (nextoffset == i)
                {
                    offsetSoFar = nextoffset;
                }
                dp[i] = dp[i - offsetSoFar] + 1;
                //4, = 1+ dp[i-4]
                //5, 1+ dp[i-5]
                //dp[i-5} = dp[5-4] = dp[1] = 1
            }

            return dp;
        }
    }