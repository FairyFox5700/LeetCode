    public class Solution
    {
        public int CountPrimes(int n)
        {
            var boolarr = new bool[n];
            // 0 and 1 are not primes
            if(n <=1)
            {
                return 0;
            }
            boolarr[0] =boolarr[1] = true;
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j * i < n; j++)
                {
                    boolarr[j * i] = true;
                }
            }

            return boolarr.Count(e => e== false);
        }
    }