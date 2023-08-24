   public class Solution
    {
        // wordDict = ["leet", "code"]
        // s = "leetcode"
        //dp[8] = true
        //dp[7] = false
        //dp[6] = false
        //dp[5] = false
        //dp[4] = true // iterated through the wordDict, found a match, set dp[4] = dp[4 + word.Length] = dp[4 + 4] = dp[8] = true
        //dp[3] = false
        //dp[2] = false
        //dp[1] = false
        //dp[0] = true = dp[0 + word.Length] = dp[0 + 4] = dp[4] = true
        public bool WordBreak(string s, IList<string> wordDict)
        {
            // bottom up approch
            var dp = new bool[s.Length + 1];
            // base case, if we go out of bounds, meens we found a match
            dp[s.Length] = true;
            for (int i= s.Length - 1; i >= 0; i--)
            {
                // check every item in dict
                foreach (var word in wordDict)
                {
                    var currentLength = word.Length + i;
                    if (currentLength <= s.Length)
                    {
                        // check if the word is in the string
                        if (s.Substring(i, word.Length) == word)
                        {
                            // if we found a match, we check the next item in the string
                            // if we found a match, we set the dp to true
                            dp[i] = dp[i + word.Length];
                            if (dp[i] == true)
                            {
                                break;
                            }
                        }
                        else
                        {
                            dp[i] = false;
                        }
                    }
                }
            }

            return dp[0];
        }
    }
