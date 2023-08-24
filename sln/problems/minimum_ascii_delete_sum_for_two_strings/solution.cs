    public class Solution
    {
        public int MinimumDeleteSum(string s1, string s2)
        {
            var dp = new int[s1.Length + 1, s2.Length + 1];
            // row is for string s1
            for (int i = 1; i <= s1.Length; i++)
            {
                dp[i, 0] = dp[i - 1, 0] + s1[i - 1];
            }
            // colums if for string s2
            // first row and column is empty strings
            // first row will be the sum of the string ASCII charcters
            for (int j = 1; j <= s2.Length; j++)
            {
                dp[0, j] = dp[0, j - 1] + s2[j - 1];
            }

            for (int i = 1; i < s1.Length +1; i++)
            {
                for (int j = 1; j < s2.Length + 1; j++)
                {
                    var vals1 = s1[i - 1];
                    var vals2 = s2[j - 1];
                    if (vals1 == vals2)
                    {
                        dp[i,j]  = dp[i-1,j-1]; // diagonal value, which represents the previous calculated optimal results
                        // we dont need to delete the characters
                        // so no need to add the ASCII values
                    }
                    else
                    {
                        // assumably we delete from s1
                        var deleteS1 = dp[i - 1, j] + s1[i - 1];
                        var deleteS2 = dp[i, j - 1] + s2[j - 1];
                        var min = Math.Min(deleteS1, deleteS2);
                        dp[i,j ] = min;
                    }
                }
            }

            return dp[s1.Length, s2.Length];
        }
    }