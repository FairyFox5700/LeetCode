    public class Solution
    {
        public int FindLongestChain(int[][] pairs)
        {
            Array.Sort(pairs, (a, b) => a[1] - b[1]);
            var currentEnd = pairs[0][1];
            var currentLen = 1;
            for (int i = 1; i < pairs.Length; i++)
            {
                var start = pairs[i][0];
                if (start > currentEnd)
                {
                    currentLen++;
                    currentEnd = pairs[i][1];
                }
            }

            return currentLen;
        }
    }