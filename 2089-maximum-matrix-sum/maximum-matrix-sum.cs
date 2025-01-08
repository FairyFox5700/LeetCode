public class Solution {
    public long MaxMatrixSum(int[][] matrix) {

        var minAbs = int.MaxValue;
        var negatives =0;
        long sum = 0;
        for( int i = 0; i< matrix.Count(); i++)
        {
            for(int j = 0; j< matrix[i].Count(); j++)
            {
                if(matrix[i][j] < 0)
                {
                    negatives++;
                }

                minAbs = Math.Min(Math.Abs(matrix[i][j]), minAbs);
                sum+= Math.Abs(matrix[i][j]);
                
            }
        }
Console.WriteLine( sum);
        if( negatives%2==0)
        {
            return sum; // each element can be converted to positive
        }
        else {
            // one element will be left in case of odd, 
            // to minimize - operatin, we take minAbs element *2 ( because we previously added this usm value to the sum)
            return sum - 2*minAbs;
        }
    }
}