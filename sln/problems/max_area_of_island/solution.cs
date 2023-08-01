    public class Solution
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            var maxArea = 0;
            var visited = new HashSet<(int, int)>();
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (!visited.Contains((i, j)) && grid[i][j] == 1)
                    {
                        var currentArea = DFS(i, j, visited, grid);
                        maxArea= Math.Max(maxArea, currentArea);
                    }
                }
            }

            return maxArea;
        }

        //DFS
        public int DFS(int r, int c, HashSet<(int, int)> visited, int[][] grid)
        {
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return 0;
            }

            if (visited.Contains((r, c)))
            {
                return 0;
            }

            if (grid[r][c] == 0)
            {
                return 0;
            }
            visited.Add((r,c));
            // tail recursion
            // mean we return the 1 if the cell is 1 and then we add the result of the recursive calls
            return 1 + DFS(r + 1, c, visited, grid) +
                   DFS(r - 1, c, visited, grid) +
                   DFS(r, c + 1, visited, grid) +
                   DFS(r, c - 1, visited, grid);
        }
    }
