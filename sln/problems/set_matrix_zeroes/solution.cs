    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            bool firstRowZero = false;
            bool firstColumnZero = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        // we mark the row and column that should be set to 0
                        if (i == 0)
                        {
                            firstRowZero = true;
                        }

                        if (j == 0)
                        {
                            firstColumnZero = true;
                        }

                        matrix[i][0] = 0;
                        matrix[0][j] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (firstRowZero)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    matrix[0][i] = 0;
                }
            }

            if (firstColumnZero)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }
    }