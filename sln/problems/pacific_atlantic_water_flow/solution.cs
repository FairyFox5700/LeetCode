    public class Solution
    {
        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            //417. Pacific Atlantic Water Flow
            var result = new List<IList<int>>();
            var pacific = new HashSet<(int, int)>();
            var atlantic = new HashSet<(int, int)>();
            var colLenght = heights[0].Length;
            var rowLenght =  heights.Length;
            // for atlantic
            for (int c = 0; c < colLenght; c++)
            {
                DFS(0, c, heights, pacific, int.MinValue);
                DFS(rowLenght -1 , c, heights, atlantic, int.MinValue);
            }
            // for pacific row = 0 and col = 0
            for (int r = 0; r <rowLenght; r++)
            {
                DFS(r, 0, heights, pacific, int.MinValue);
                DFS(r, colLenght - 1, heights, atlantic, Int32.MinValue);
            }
        
            return pacific.Where(p=>atlantic.Contains(p)).Select(p=>(IList<int>)new List<int>{p.Item1,p.Item2}).ToList();
        }

        private void DFS(int r, int c, int[][] heights, HashSet<(int, int)> visited, int prevHeight)
        {
            // validaity check in bounds
            if (r < 0 || r >= heights.Length || c < 0 || c >= heights[0].Length)
            {
                return;
            }

            if (visited.Contains((r, c)))
            {
                return;
            }

            if (heights[r][c] < prevHeight)
            {
                return;
            }

            visited.Add((r, c));
            DFS(r + 1, c, heights, visited, heights[r][c]);
            DFS(r - 1, c, heights, visited, heights[r][c]);
            DFS(r, c + 1, heights, visited, heights[r][c]);
            DFS(r, c - 1, heights, visited, heights[r][c]);
        }
    }