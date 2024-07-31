    public class Solution
    {
        public bool ValidTicTacToe(string[] board)
        {
            var row = new int[3];
            var col = new int[3];
            var diag = 0;
            var antidiag = 0;
            var turns = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var ch = board[i][j];
                    if(ch == 'X')
                    {
                        row[i]++ ; 
                        col[j]++ ; 
                        if(i==j)
                            diag++;
                        if (i + j == 2)
                           antidiag++;

                        turns++;

                    }
                    else if(ch == 'O')
                    {
                        row[i]--;
                        col[j]--;
                        if (i == j)
                            diag--;
                        if(i+j== 2)
                            antidiag--;

                        turns--;
                    }
                }
            }

            var xWin = row[0]==3 || row[1]==3 || row[2]==3 || col[0]==3 || col[1]==3 || col[2]==3 || diag==3 || antidiag==3;
            var yWin = row[0] == -3 || row[1] == -3 || row[2] == -3 || col[0] == -3 || col[1] == -3 || col[2] == -3 || diag == -3 || antidiag == -3;

            if((xWin&& turns!=1 )|| (yWin && turns !=0 ))
            {
                Console.WriteLine("here");
                return false;
            }

            if(turns != 0 && turns!=1) // if X was not first
            {
                   Console.WriteLine("here2");
                return false;
            }

            return true;
        }
    }