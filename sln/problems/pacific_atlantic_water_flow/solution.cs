public class Solution {
        HashSet<(int, int)> visited = new HashSet<(int, int)>();
        HashSet<(int, int)> visited2 = new HashSet<(int, int)>();

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            // bfs from left
            // bfs from bottom

            int row = heights.Length;
            int column = heights[0].Length;

            for (int c = 0; c < column; c++)
            {
                // starting from top row
                DFS(0, c, heights, visited, Int32.MinValue);
                //starting from end row
                DFS(row-1, c, heights, visited2, Int32.MinValue);
            }

            for (int r = 0; r < row; r++)
            {
                // starting from first colomn to the east
                DFS(r, 0, heights, visited, Int32.MinValue);
                //starting from end colomn to the west
                DFS(r, column - 1, heights, visited2, Int32.MinValue);
            }


            IList<IList<int>> result = new List<IList<int>>();
            for (int r = 0; r <row; r++)
            {
                for (int c = 0; c < column; c++)
                {
                    if (visited.Contains((r, c)) && visited2.Contains((r, c)))
                    {

                        IList<int> Coordinate = new List<int>();
                        Coordinate.Add(r);
                        Coordinate.Add(c);
                        result.Add(Coordinate);
                    }
                }
            }

            return result;
        }

        public void DFS(int r, int c, int[][] heights, HashSet<(int, int)> visited2, int prevHeights)
        {
            if (r >= 0 && r < heights.Length
                       && c >= 0 && heights[0].Length > c
                       && !visited2.Contains((r, c))
                       && heights[r][c] >= prevHeights)
            {
                visited2.Add((r, c));
                DFS(r, c + 1, heights, visited2, heights[r][c]);
                DFS(r, c - 1, heights, visited2, heights[r][c]);
                DFS(r + 1, c, heights, visited2, heights[r][c]);
                DFS(r - 1, c, heights, visited2, heights[r][c]);
            }
        }
}