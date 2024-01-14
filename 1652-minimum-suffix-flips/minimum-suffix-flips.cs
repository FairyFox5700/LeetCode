    public class Solution
    {
        public int MinFlips(string target)
        {
            // 10111
            var previos = '0';
            var result = 0;
            for(int i = 0; i<target.Length; i++)
            {
                if (previos != target[i])
                {
                    result++;
                    previos = target[i];
                }
                
            }

            return result;
        }
    }