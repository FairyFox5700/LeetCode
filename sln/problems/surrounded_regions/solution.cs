    public class Solution
    {
        public void Solve(char[][] board)
        {
            var visisted = new HashSet<(int, int)>();

            // capture all nodes surrounded by border cells , which has 0 value
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    // runn only for border node with 0 value
                    if ((i == 0 || i == board.Length - 1 || j == 0 || j == board[0].Length - 1) && board[i][j] == 'O')
                    {
                        Console.WriteLine("true");
                        DFS(i, j, board, visisted);
                    }
                }
            }

            // flip all nodes which are not visited
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'O')
                    {
                        board[i][j] = 'X';
                    }
                }
            }

            // flip T back to O
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == 'T')
                    {
                        board[i][j] = 'O';
                   }
                }
            }
        }
        // used to capture all nodes surrounded by border cells , which has 0 value
        // if there will be node on border which is 0
        // then we run DFS to mark them as tos, which should not be flipped
        private void DFS(int r, int  c, char[][] board, HashSet<(int,int)> visited)
        {
      
            // check borders
            if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length || board[r][c] != 'O')
            {
                return;
            }

            visited.Add((r,c));
            Console.WriteLine("r: " + r+ ", c: " +c);
                board[r][c] = 'T';
           

            DFS(r + 1, c, board, visited);
            DFS(r - 1, c, board, visited);
            DFS(r, c+1, board, visited);
            DFS(r, c-1, board, visited);
        }
    }