public class Solution {
        public int IslandPerimeter(int[][] grid)
        {
            int sum = 0;
            var visited = new HashSet<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (!visited.Contains((i, j)) && grid[i][j] == 1)
                    {
                        sum += DFS(i, j, grid, visited);
                    }
                }
            }

            return sum;
        }
        private int DFS(int r, int c, int[][] grid, HashSet<(int,int)> visited)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return 1; // out of border case
            }

            if(grid[r][c] == 0)
            {
                return 1;
            }

            if (visited.Contains((r, c)))
            {
                return 0;
            }

            visited.Add((r, c));
            var sum = DFS(r + 1, c, grid, visited) + DFS(r, c + 1, grid, visited)
            + DFS(r, c - 1, grid, visited) + DFS(r - 1, c, grid, visited);

            return sum;
        }
}