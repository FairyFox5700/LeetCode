    public class Solution
    {
        public int MinimumMoves(string s)
        {
            var minMoves = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // if we see a 0, we need to move the next two characters
                // if we see a 1, we need to move the next three characters
                if (s[i] != 'O')
                {
                    minMoves++;
                    i += 2;
                }
            }

            return minMoves;
        }
    }