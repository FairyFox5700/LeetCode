    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            // first transponents
            // then swith the columns
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = i; j < matrix[0].Length; j++)
                {
                    (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
                }
            }

            // reverse
            for (int i = 0; i < matrix.Length; i++)
            {
                // two pointer swap or Array.Reverse
                var left = 0;
                var right = matrix[i].Length - 1;
                while (left < right)
                {
                    (matrix[i][left], matrix[i][right]) = (matrix[i][right], matrix[i][left]);
                    left++;
                    right--;
                }
            }
        }
    }