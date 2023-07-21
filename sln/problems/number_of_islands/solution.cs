public class Solution {
        public int NumIslands(char[][] grid)
        {
            var queue = new Queue<(int, int)>();
            var visited = new HashSet<(int, int)>();
            var islands = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1' && !visited.Contains((i, j)))
                    {
                        queue.Enqueue((i, j));
                        visited.Add((i, j));
                        BFS(grid, i, j, visited, queue);
                        islands++;
                    }
                }
            }
            // mark first node ( root) as visited and add to queue
            return islands;
        }

                 private void BFS(char[][] grid, int i, int j, HashSet<(int,int)> visited, Queue<(int, int)> queue)
        {
            int[] dx = { 1, -1, 0, 0 };
            int[] dy = { 0, 0, 1, -1 };
            while (queue.Count > 0)
            {
                var (x, y) = queue.Dequeue();
                for (int k = 0; k < 4; k++)
                {
                    int newX = x + dx[k];
                    int newY = y + dy[k];

                    if (newX >= 0 && newX < grid.Length && newY >= 0 && newY < grid[0].Length &&
                        grid[newX][newY] == '1' && !visited.Contains((newX, newY)))
                    {
                        queue.Enqueue((newX, newY));
                        visited.Add((newX, newY));
                    }
                }
            }
        }
}