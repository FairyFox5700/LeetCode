public class Solution {
    public int MinPathSum(int[][] grid) {
        if (grid == null || grid.Length == 0 || grid[0].Length == 0) {
            return 0;
        }

        // Initialize the DP array for the last row
        int[] dp = new int[grid[0].Length];
        dp[grid[0].Length - 1] = grid[grid.Length - 1][grid[0].Length - 1]; // Bottom-right corner

        // Populate DP for the last row
        for (int i = grid[0].Length - 2; i >= 0; i--) {
            dp[i] = dp[i + 1] + grid[grid.Length - 1][i]; // Last row values
        }

        // Populate DP for the rest of the rows, moving upwards
        for (int i = grid.Length - 2; i >= 0; i--) {
            for (int j = grid[0].Length - 1; j >= 0; j--) {
                if (j == grid[0].Length - 1) {
                    // Last column: Can only go down
                    dp[j] = dp[j] + grid[i][j];
                } else {
                    // Choose the min path from right or down
                    dp[j] = Math.Min(dp[j], dp[j + 1]) + grid[i][j];
                }
            }
        }

        return dp[0]; // The min path sum to reach (0,0) from (m,n)
    }
}
