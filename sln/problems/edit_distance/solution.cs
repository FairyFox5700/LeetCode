public class Solution {
        public int MinDistance(string word1, string word2)
        {
            //https://www.youtube.com/watch?v=HwDXH35lr0o&ab_channel=NikhilLohia
            var dp = new int[word1.Length + 1, word2.Length + 1];

            for (int i = 0; i <= word1.Length; i++)
            {
                dp[i, 0] = i;
            }

            for (int i = 0; i <= word2.Length; i++)
            {
                dp[0, i] = i;
            }

            for (int i = 1; i < word1.Length + 1; i++)
            {
                for (int j = 1; j < word2.Length + 1; j++)
                {
                    if (word1[i-1] == word2[j-1])
                    {
                        // if the characters are same, then we can just take the diagonal value ( no operation needed)
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        // if the characters are not same, then we need to take the minimum of the left and top value and add 1 to it
                        // the diagonal means inserting
                        // the left and right value means replacing
                        // removing means we take min of all tree values
                        dp[i, j] =Math.Min( Math.Min(dp[i - 1, j], dp[i, j - 1]), dp[i-1, j-1]) + 1;
                    }
                }
            }

            return dp[word1.Length, word2.Length];
        }
}