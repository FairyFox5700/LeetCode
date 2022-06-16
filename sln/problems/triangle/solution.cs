public class Solution {
 public int MinimumTotal(IList<IList<int>> triangle)
        {
            var dp = new int[triangle[^1].Count+1];

            for (int j = triangle.Count - 1; j >= 0; j--)
            {
                var items = triangle[j];
                for (int i = 0; i < items.Count; i++)
                {
                    dp[i] = items[i] + Math.Min(dp[i], dp[i + 1]);
                }
            }
            return dp[0];
        }
}