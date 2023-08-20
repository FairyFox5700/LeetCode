    public class Solution
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            var m = obstacleGrid.Length;
            var n = obstacleGrid[0].Length;
            var dp = new int[n];
            if (obstacleGrid[0][0] == 1 || obstacleGrid[m - 1][n - 1] == 1)
            {
                return 0;
            }
            // it is only one option to get to the first row and first column
            dp[0] = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        dp[j] = 0;
                    }
                    else
                    {
                        if(j-1 >= 0)
                        {
                            dp[j] = dp[j] + dp[j - 1];
                            // it will be a sum to get to the right and to the bottom
                        }
 
                    }
                        
                }
            }
            return dp[n - 1];
        }
    }
