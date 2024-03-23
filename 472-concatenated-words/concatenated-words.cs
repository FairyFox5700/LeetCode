    public class Solution
    {
        public IList<string> FindAllConcatenatedWordsInADict(string[] words)
        {
            var hashSet = new HashSet<string>(words);
            var result = new List<string>();

            foreach (var word in words)
            {
                var len = word.Length;
                var dp = new bool[len + 1];
                dp[0] = true; // empty string is always present in the dictionary
                // generate substring from 0 to i
                for (int i = 1; i <= len; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (dp[j] && hashSet.Contains(word.Substring(j,  i - j))&& (j != 0 || i != len))
                        {
                            dp[i] = true;
                            break;
                        }
                    }
                }

                if (dp[len])
                {
                    result.Add(word);
                }
            }

            return result;
        }
    }