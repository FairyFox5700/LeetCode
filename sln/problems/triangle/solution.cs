public class Solution {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var dp = new int[triangle.Count + 1];

            for (int i = triangle.Count- 1; i >= 0; i--)
            {
                var list = triangle[i];
                for (int j = 0; j < list.Count; j++)
                {
                    dp[j] = Math.Min(dp[j], dp[j + 1]) + list[j];
                }
            }

            return dp[0];
        }
}