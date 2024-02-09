using System.Collections.Generic;

public class Solution
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<(int, int, int)>();
        queue.Enqueue((entrance[0], entrance[1], 0));
      
        var directions = new List<(int, int)>()
        {
           (1, 0), // down
           (0, 1), // right
           (-1, 0), // up
           (0, -1) // left
        };

        while (queue.Count > 0)
        {
            int size = queue.Count;
           
                var (currentR, currentC, stepsCount) = queue.Dequeue();

          
                
                foreach (var (xDelta, yDelta) in directions)
                {
                    var nextR = currentR + xDelta;
                    var nextC = currentC + yDelta;

                    if (InBound(nextR, nextC, maze) && ValidCellToMove(nextR, nextC, maze) && !visited.Contains((nextR, nextC)))
                    {
                        visited.Add((nextR, nextC));
                        queue.Enqueue((nextR, nextC, stepsCount+1));
                    }

                          if (IsExitPoint(currentR, currentC, maze, entrance))
                {
                    return stepsCount++;
                }

                }
           
        }

        return -1;
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

    private bool InBound(int row, int col, char[][] maze)
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
