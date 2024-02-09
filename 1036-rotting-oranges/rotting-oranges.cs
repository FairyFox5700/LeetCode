public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        /*
         *  0 representing an empty cell,
            1 representing a fresh orange, or
            2 representing a rotten orange.
         */

        var mintTimeToElapse = 0;
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<(int, int)>();
        var directions = new List<(int, int)>()
        {
            (1, 0), // down
            (0, 1), // right
            (-1, 0), // up
            (0, -1) // left
        };

        var countOfFreshOranges = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 2)
                {
                    queue.Enqueue((i,j));

                }

                if (grid[i][j] == 1)
                {
                    countOfFreshOranges++;
                }
            }
        }

              if (countOfFreshOranges == 0)
                    {

                        return 0;
                    }

        var result = BFS(grid, queue, directions,ref countOfFreshOranges);

        return countOfFreshOranges == 0? result: -1;
    }

    private int BFS( int[][] grid, Queue<(int,int)> queue, List<(int,int)> directions, ref int countOfFreshOranges)
    {
        var timeToMakeRotten = 0;
        while (queue.Count > 0)
        {
            var currentCount = queue.Count;
            for (int i = 0; i < currentCount; i++)
            {
                var (currentR, currentC) = queue.Dequeue();
                foreach (var (xDelta, yDelta) in directions)
                {
                    var nextR = currentR + xDelta;
                    var nextC = currentC + yDelta;

                    if (InBound(nextR, nextC, grid) && grid[nextR][nextC] == 1)
                    {
                        grid[nextR][nextC] = 2;
                        countOfFreshOranges--;
                        queue.Enqueue((nextR, nextC));
                    }

                    if (countOfFreshOranges == 0)
                    {
                        timeToMakeRotten++;
                        return timeToMakeRotten;
                    }
                }
            }
Console.WriteLine("L");
            timeToMakeRotten++;
        }

        return timeToMakeRotten;
    }

    private bool IsExitPoint(int row, int col, char[][] maze, int[] entrance)
    {
        if (!ValidCellToMove(row, col, maze))
        {
            return false;
        }

        if ((row == 0 || col == 0 || row == maze.Length - 1 || col == maze[0].Length - 1) && !(row == entrance[0] && col == entrance[1]))
        {
            return true;
        }

        return false;
    }

    private bool InBound(int row, int col, int[][] maze)
    {
        var totalRows = maze.Length;
        var totalCols = maze[0].Length;

        return (row >= 0 && row < totalRows && col >= 0 && col < totalCols);
    }

    private bool ValidCellToMove(int row, int col, char[][] maze)
    {
        return maze[row][col] != '+';
    }
}