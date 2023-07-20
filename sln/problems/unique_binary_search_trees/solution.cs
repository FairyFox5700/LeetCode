public class Solution {
        public int NumTrees(int n)
        {
            // dp[4] = dp[0] * dp[3] + dp[1] * dp[2] + dp[2] * dp[1] + dp[3] * dp[0]
            // we cosidering the case
            // 1. left = 0, right = 3
            // 2. left = 1, right = 2
            // 3. left = 2, right = 1
            // 4. left = 3, right = 0
            // so we can see that the left and right are symmetrical
            if (n == 1) return 1;
            if (n == 2) return 2;
            var dp = new int[n + 1];
            // base cases
            dp[0] = 1;
            dp[1] = 1;
            dp[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - (j + 1)] ;
                }
            }

            return dp[n];
        }
}