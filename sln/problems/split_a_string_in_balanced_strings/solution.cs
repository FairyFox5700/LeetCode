    public class Solution
    {
        public int BalancedStringSplit(string s)
        {
            var rCount = 0;
            var totalCount = 0;
            foreach (var ch in s)
            {
                if (ch == 'R')
                {
                    rCount++;
                }

                if (ch == 'L')
                {
                    rCount--;
                }

                if (rCount == 0)
                {
                    totalCount++;
                }
            }

            return totalCount;
        }
    }
