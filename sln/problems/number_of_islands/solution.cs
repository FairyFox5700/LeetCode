public class Solution {
        private HashSet<(int, int)> visisted = new();
        private Queue<(int, int)> queue = new Queue<(int, int)>();

        public int NumIslands(char[][] grid)
        {
            var count = 0;
            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {

                    if (!visisted.Contains((r, c)) && grid[r][c] == '1')
                    {

                        queue.Enqueue((r, c));
                        visisted.Add((r, c));
                        BFS(grid);
                        count += 1;
                    }

                }
            }

            return count;
        }

        public void BFS(char[][] grid)
        {
            while (queue.Count > 0)
            {
                var (r, c) = queue.Dequeue();
                var directions = new List<(int, int)>()
                {
                    (r, c + 1),
                    (r, c - 1),
                    (r + 1, c),
                    (r - 1, c)
                };

                foreach (var (dr, dc) in directions)
                {
                    r =dr;
                    c = dc;
                    if (r >= 0 && r < grid.Length
                               && c >= 0 && c < grid[0].Length
                               && grid[r][c] == '1'
                               && !visisted.Contains((r, c)))
                    {
                        queue.Enqueue((r, c));
                        visisted.Add((r, c));
                    }
                }
            }
        }
}