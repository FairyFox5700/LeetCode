    public class Solution
    {
        public bool Exist(char[][] board, string word)
        {
            if (word.Length == 0)
            {
                return true;
            }
            var path = new HashSet<(int, int)>();
            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    if (DFS(r, c, 0, board, word, path))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool DFS(int r, int c, int index, char[][] board, string word, HashSet<(int,int)> path)
        {
            var wordLength = word.Length;

            if (r < 0 || r >= board.Length || c < 0 || c >= board[0].Length || index > wordLength || board[r][c] != word[index] || path.Contains((r, c)))
            {
                return false;
            }

            path.Add((r, c));

            if (path.Count == wordLength)
            {
                return true;
            }
            // complexity = 4 *pow(wordLenght)
            var res = (DFS(r + 1, c, index + 1, board, word, path) ||
                       DFS(r, c + 1 , index + 1, board, word, path) ||
                       DFS(r, c - 1, index + 1, board, word, path) ||
                       DFS(r - 1, c, index + 1, board, word, path));
            path.Remove((r, c));
            return res;
        }
    }