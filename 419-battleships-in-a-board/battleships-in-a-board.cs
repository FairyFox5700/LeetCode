public class Solution
{
    public int CountBattleships(char[][] board)
    {

        //Going over all cells, we can count only those that are the "first" cell of the battleship. 
        //First cell will be defined as the most top-left cell. We can check for first cells 
        // by only counting cells that do not have an 'X' to the left and do not have an 'X' above them.
        var count = 0;
        for(int i = 0; i < board.Length; i++)
        {
            for(int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j] == '.')
                {
                    continue;
                }
                if(i > 0 && board[i-1][j] == 'X')// value of cell above
                {
                    // X
                    // X
                    // O 
                    continue;
                }
                if(j > 0 && board[i][j-1] == 'X')// value of cell to the left 
                {

                    //X
                    //X
                    //X X
                    continue;
                }
                count++;
            }
        }

        return count;
    }
}