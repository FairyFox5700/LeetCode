    public class Solution
    {
        public int ShortestBridge(int[][] grid)
        {
            var visited = new HashSet<(int, int)>();
            var queue = new Queue<(int, int)>();
            // first using DFS, find the first island
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        DFS(i, j, grid, visited);
                        
                        // after we found the location of the first island, we can break
                        // and run BFS to find the shortest path to the second island
                        PopulateQueue(visited, queue);
                        
                        return BFS( grid,queue, visited);
                    }
                }
            }

            return -1;
        }

        private void PopulateQueue(HashSet<(int, int)> visited, Queue<(int, int)> queue)
        {
            foreach (var item in visited)
            {
                queue.Enqueue(item);
            }
        }

        //dfs

        public void DFS(int r, int c, int[][] grid, HashSet<(int, int)> visited)
        {
            var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };
            if (visited.Contains((r, c)))
            {
                return;
            }
            if (r < 0 || r >= grid.Length || c < 0 || c >= grid[0].Length)
            {
                return;
            }
            if (grid[r][c] == 0)
            {
                // we intend to populate visited array only with sells islands(1 value)
                return;
            }
            visited.Add((r, c));
            foreach (var direction in directions)
            {
                var newRow = r + direction.Item1;
                var newCol = c + direction.Item2;
                DFS(newRow, newCol, grid, visited);
            }
        }
        // bfs
        public int BFS(int[][] grid, Queue<(int, int)> queue, HashSet<(int, int)> visited)
        {
            var steps = 0;
            var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Count);
                // here we do the layer approach, similar to the tree layers approach
                var currentCount = queue.Count;
                for (int i = 0; i < currentCount; i++)
                {
                    var (r, c) = queue.Dequeue();
                    foreach (var direction in directions)
                    {
                        var newRow = r + direction.Item1;
                        var newCol = c + direction.Item2;
                        // check in bounds
                         if (newRow < 0 || newRow >= grid.Length || newCol < 0 || newCol >= grid[0].Length
                            || visited.Contains((newRow, newCol)))
                        {
                            // visited array is here to count that the BFS can connect to the island we found using DFS
                            continue;
                        }
                        visited.Add((newRow, newCol));
                        if (grid[newRow][newCol] == 1)
                        {
                            return steps;
                        }


                        queue.Enqueue((newRow, newCol));
                    }
                }
                // only when one layer is done, we increment the steps
                steps++;
            }

            return steps;
        }
    }

