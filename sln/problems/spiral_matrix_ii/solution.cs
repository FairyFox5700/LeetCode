    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            var lastRow = n - 1;
            var lastColumn = n - 1;
            var firstRow = 0;
            var firstColumn = 0;
            var result = new int[n][];
               for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }
            var val = 1;
              while (firstRow <= lastRow && firstColumn <= lastColumn)
        {
                // populate first row
                for (int c = firstColumn; c <= lastColumn; c++)
                {
                    result[firstRow][c] = val;
                    val++;
                    
                }
                firstRow++;
                // populate last column 
                for (int r = firstRow; r <= lastRow; r++)
                {
                    result[r][lastColumn] = val;
                    val++;
                   
                }
                 lastColumn--;
                // populate last row
                for (int c =lastColumn; c >= firstColumn; c--)
                {
                result[lastRow][c] = val;
                    val++;
                    
                }
                lastRow--;

                // populate first column 
                for (int r = lastRow; r >= firstRow; r--)
                {
                result[r][firstColumn] = val;
                    val++;
                    
                }
firstColumn++;
                
        }
        return result;
        }
        
    }