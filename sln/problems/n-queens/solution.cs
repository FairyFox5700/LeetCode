    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var result = new List<IList<string>>();
            var currentList = new List<string>();
            var board = new char[n,n];
            var columnsSet = new HashSet<int>();
            var positiveDiagonalSet = new HashSet<int>();
            var negativeDiagonalSet = new HashSet<int>();
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    board[r,c] = '.';
                }
            }
            Backtracking(board, result, columnsSet, positiveDiagonalSet, negativeDiagonalSet,0);
            return result;
        }

        private void ConvertBoardToString(char[,] board, List<string> current)
        {
            var sb = new StringBuilder();
            for (int r = 0; r < board.GetLength(0); r++)
            {
                for (int c = 0; c < board.GetLength(0); c++)
                {
                    sb.Append(board[r,c]);
                }
                current.Add(sb.ToString());
                sb.Clear();
            }
        }
        public void Backtracking(char[,] board, List<IList<string>> result, HashSet<int> columnSet,
            HashSet<int> posDiagonalset, HashSet<int> negativeDiagonalSet, int r)
        {
            // iterate throug each row in recursion
            // base case
            if (r == board.GetLength(0))
            {
                var current = new List<string>();
                ConvertBoardToString(board,current);
                result.Add(current);
                return;
            }

            for (var c = 0; c < board.GetLength(0); c++)
            {
                if(columnSet.Contains(c) || posDiagonalset.Contains(r+c) || negativeDiagonalSet.Contains(r-c))
                    continue;
                board[r, c] = 'Q';
                columnSet.Add(c);
                posDiagonalset.Add(r + c);
                negativeDiagonalSet.Add(r - c);
                Backtracking(board,result, columnSet,posDiagonalset,negativeDiagonalSet,r+1);
                // cleanup
                board[r, c] = '.';
                columnSet.Remove(c);
                posDiagonalset.Remove(r + c);
                negativeDiagonalSet.Remove(r - c);
            }
        }
    }