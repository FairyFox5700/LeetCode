using System;
using System.Collections.Generic;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();
        if (matrix.Length == 0 || matrix[0].Length == 0)
        {
            return result;
        }

        int rowStart = 0, rowEnd = matrix.Length - 1;
        int colStart = 0, colEnd = matrix[0].Length - 1;

        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            // Traverse right across the top
            for (int col = colStart; col <= colEnd; col++)
            {
                result.Add(matrix[rowStart][col]);
            }

            // Traverse down the right side
            for (int row = rowStart+1; row <= rowEnd; row++)
            {
                result.Add(matrix[row][colEnd]);
            }

            if (rowStart != rowEnd)  // Check if there's still a row to traverse
            {
                // Traverse left across the bottom
                for (int col = colEnd-1; col >= colStart; col--)
                {
                    result.Add(matrix[rowEnd][col]);
                }
            }

                if (colStart != colEnd)  
                {
              
                // Traverse up the left side
                for (int row = rowEnd-1; row > rowStart; row--)
                {
                    result.Add(matrix[row][colStart]);
                }
                  }
      
            colStart++;
            colEnd--;
            rowStart++;
            rowEnd--;
        }

        return result;
    }
}
