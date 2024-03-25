    public class Solution
    {
        public int NumDistinctIslands(int[][] grid)
        {
            var visited = new HashSet<(int, int)>();

            var hashSet = new HashSet<string>();

            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[0].Length; c++)
                {
                    if (grid[r][c] == 1 && !visited.Contains((r, c)))
                    {

                        var strBuilder = new StringBuilder();
                        DFS(grid, r, c, visited, ' ', strBuilder);
                        if(!hashSet.Contains(strBuilder.ToString()))
                        {
                            hashSet.Add(strBuilder.ToString());
                        }
                    }
                }
            }

            return hashSet.Count;
        }

        private void DFS(int[][] grid, int r, int c, HashSet<(int, int)> visited, char direction, StringBuilder stringBuilder)
        {
            // to validate
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return;
            }

            if (visited.Contains((r, c)) || grid[r][c]!=1)
            {
                return;
            }

            visited.Add((r, c));
            stringBuilder.Append(direction);
            DFS(grid, r+1, c, visited, 'D', stringBuilder);
            DFS(grid, r-1, c, visited, 'U', stringBuilder);
            DFS(grid, r, c+1, visited, 'R', stringBuilder);
            DFS(grid, r, c-1, visited, 'L', stringBuilder);
            stringBuilder.Append(' ');
        }
    }