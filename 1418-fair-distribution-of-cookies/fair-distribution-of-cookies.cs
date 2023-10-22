    public class Solution
    {

        private int _count = int.MaxValue;
        public int DistributeCookies(int[] cookies, int k)
        {
            var currentDistribution = new int[k];
            DFS(cookies, 0, k, currentDistribution, k);

            return _count;
        }

        private void DFS(int[] cookies, int cookieLength, int k, int[] currentDistribution, int noDistributedKidsYet)
        {
            // not enoghh cookies to distribute
            if(noDistributedKidsYet !=0 && cookieLength == cookies.Length)
                return;

            if (cookieLength == cookies.Length)
            {
                _count = Math.Min(_count, currentDistribution.Max());
                return;
            }

            for (int i = 0; i < k; i++)
            {
                if (currentDistribution[i] == 0)
                    noDistributedKidsYet--;
                currentDistribution[i] += cookies[cookieLength]; // give cookie to ith child
                // continue to distribute other cookies to other children
                DFS(cookies, cookieLength + 1, k, currentDistribution, noDistributedKidsYet);
                // backtrack
                currentDistribution[i] -= cookies[cookieLength];
                if (currentDistribution[i] == 0)
                    noDistributedKidsYet--;
            }
        }
    }