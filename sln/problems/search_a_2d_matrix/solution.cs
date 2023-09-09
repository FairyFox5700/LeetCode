    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            // first we find the necessary row
            // then we find the necessary column
            var firstRow = 0;
            var lastRow = matrix.Length-1;
            var rowIndex = 0;
            while (firstRow <= lastRow)
            {
                var mid = firstRow + (lastRow - firstRow) / 2;
                rowIndex=mid;
                
                if (matrix[mid][0] == target)
                {
                    Console.WriteLine(matrix[mid][0]);
                    break;
                }
                if (matrix[mid][0] > target)
                {
                     lastRow = mid - 1;
                }
                else if(matrix[mid][matrix[0].Length-1] < target)
                {
                    firstRow = mid + 1;
                  
                }
                else 
                {
                    break;
                }
                
            }
            Console.WriteLine($"firstColumn = {firstRow}");
            Console.WriteLine($"lastColumn = {lastRow}");
            Console.WriteLine(rowIndex);
            var left = 0;
            var right = matrix[0].Length-1;
            while(left <= right)
            {
                var mid = left + (right - left) / 2;
                if(matrix[rowIndex][mid] == target)
                {
                    return true;
                }
                if (matrix[rowIndex][mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return false;
        }
    }