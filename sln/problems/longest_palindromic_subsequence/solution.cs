public class Solution 
    {
        public int LongestPalindromeSubseq(string s)
        {
            //https://www.youtube.com/watch?v=6i_T5kkfv4A&ab_channel=takeUforward

            var text1 = s;
            var text2 = new string(s.Reverse().ToArray());
          
            var dp = new int[text1.Length + 1, text2.Length + 1];

            for (int i = 1; i < text1.Length + 1; i++)
            {
                for (int j = 1; j < text2.Length + 1; j++)
                {
                    if (text1[i-1] == text2[j-1])
                    {
                        // only diagonal value
                        // as it represents the actual longest subsequence of string len (i-1) and (j-1)
                        dp[i, j] = dp[i - 1, j -1] + 1;
                    }
                    else
                    {
                        dp[i, j] = Math.Max(dp[i, j - 1], dp[i - 1, j]);
                    }
                }
            }
            return dp[text1.Length, text2.Length];

        }
}
    