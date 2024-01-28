    public class Solution
    {
        public IList<int> LexicalOrder(int n)
        {
            var num = new List<int>();

            for (int i = 1; i <= 9; i++)
            {
                DFS(n,i, num);
            }

            return num;
        }

        public List<int> DFS(int max, int currentN, List<int> current)
        {
            if (currentN > max)
            {
                return new List<int>();
            }

            current.Add(currentN);
            // if no, try to add 0-9 to the end of currentN
            for (int i = 0; i < 10; i++)
            {
                var next = currentN * 10 + i;
                if (next > max)
                {
                    break;
                }
                DFS(max, next, current);
            }

            return current;
        }
    }