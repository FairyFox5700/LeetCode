    public class Solution
    {
        private int _count = 0;
        public int CountArrangement(int n)
        {
            var visted = new bool[n + 1];

            BackTrack(n, 1, visted);

            return  _count;
        }

        private void BackTrack(int n, int currentIndex, bool[] visited)
        {
            if (currentIndex == n+1)
            {
                _count++;
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i] && (currentIndex % i == 0 || i % currentIndex == 0))
                {
                    visited[i] = true;
                    BackTrack(n, currentIndex + 1, visited);
                    visited[i] = false;
                }
            }
        }
    }