public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        //[[10,16],[2,8],[1,6],[7,12]]
        //[1,6],[2,8], [7,12], [10,16]]
        var sortedPoinrs = points.OrderBy(x => x[1]).ToArray();
        var endSoFar = sortedPoinrs[0][1];
        var start = sortedPoinrs[0][0];
        var arrowsCount = 1;
        for (int i = 1; i < sortedPoinrs.Length; i++)
        {

            Console.WriteLine(sortedPoinrs[i][0]);
            Console.WriteLine(endSoFar);
            if (sortedPoinrs[i][0] > endSoFar)
            {
                arrowsCount++;
                endSoFar = sortedPoinrs[i][1];
            }
            else
            {
                start = sortedPoinrs[i][0];
                
            }
        }

        return arrowsCount;
    }
}