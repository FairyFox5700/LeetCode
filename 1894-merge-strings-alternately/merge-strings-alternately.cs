public class Solution {
            public string MergeAlternately(string word1, string word2)
            {

                var sb = new StringBuilder();
                var w1Len = 0;
                var w2Len = 0;

                while (w1Len <  word1.Length && w2Len < word2.Length)
                {
                    sb.Append(word1[w1Len]);
                    w1Len++;
                    sb.Append(word2[w2Len]);
                    w2Len++;
                }

                while (w1Len <  word1.Length)
                {
                    sb.Append(word1[w1Len]);
                    w1Len++;
                }

                while( w2Len < word2.Length)
                {
                    sb.Append(word2[w2Len]);
                       w2Len++;
                }

                return sb.ToString();
            }
}