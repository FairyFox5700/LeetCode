    public class Solution
    {
        public int MinPathSum(int[][] grid)
        {
            var dp = new int[grid.Length, grid[0].Length];

            dp[grid.Length - 1, grid[0].Length - 1] = grid[grid.Length - 1][grid[0].Length - 1];
            for (int i = grid.Length - 2; i >= 0; i--)
            {
                dp[i, grid[0].Length - 1] = dp[i+1, grid[0].Length - 1] + grid[i][grid[0].Length-1];
            }

            for (int i = grid[0].Length - 2; i >= 0; i--)
            {
                dp[grid.Length - 1, i] = dp[grid.Length - 1, i + 1] + grid[grid.Length-1][i];
            }
            for (int i = grid.Length - 2; i >= 0; i--)
            {
                for (int j = grid[0].Length - 2; j >= 0; j--)
                {
                    dp[i, j] = Math.Min(dp[i + 1, j], dp[i, j + 1]) + grid[i][j];
                }
            }
            
            return dp[0, 0];
        }
    

    }

