    public class Solution
    {
        public int UniquePaths(int m, int n)
        {
            var dp = new int[m, n];
            // it is only one option to get to the first row and first column
            for (int i = 0; i < m; i++)
            {
                dp[i, 0] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                dp[0,i] = 1;
            }


            for (int i = 1; i < m; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];

                    // it will be a sum to get to the right and to the bottom
                }
            }
            return dp[m-1,n-1];
        }
    }
