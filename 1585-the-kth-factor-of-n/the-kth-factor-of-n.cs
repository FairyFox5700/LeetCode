    public class Solution
    {
        public int KthFactor(int n, int k)
        {
            // while k< 0
            // n // k == 0
            var factors = new List<int>();
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0 && k>0)
                {
                    k--;
                    factors.Add(i);
                }
                if(k == 0)
                    return factors.Last();
            }

            var size = factors.Count;
            if(k == 1)
                return n;
            else
                return -1;
        }
    }