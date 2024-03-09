public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {

        //https://www.educative.io/answers/what-is-the-longest-common-subsequence-problem
        // best expanation: https://www.youtube.com/watch?v=e9tUPwZZSBI&ab_channel=NikhilLohia
        /*
        Input: You are given two strings, text1 and text2.

Create a DP Table: Create a 2D array (a DP table) of dimensions (len(text1) + 1) x (len(text2) + 1) to store the lengths of LCS for different prefixes of the two strings. Initialize the entire table with zeros.

Fill the DP Table: Iterate through the DP table starting from (1, 1) (since the first row and first column represent empty strings):

If text1[i-1] matches text2[j-1], increment the value in the DP table at (i, j) by 1 plus the value at (i-1, j-1).
Otherwise, take the maximum of the values at (i-1, j) and (i, j-1) and store it at (i, j).
Result: The value at the bottom-right corner of the DP table (DP[len(text1)][len(text2)]) represents the length of the LCS.*/    
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