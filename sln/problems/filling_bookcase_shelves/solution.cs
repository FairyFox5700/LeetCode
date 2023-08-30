
public class Solution
{
    public int MinHeightShelves(int[][] books, int shelfWidth)
    {
        // top down approach
        // for sample book i
        // books[i][0] - width
        // books[i][1] - height
        // used to store min height so far
        var dp = new int[books.Length + 1];
        dp[0] = 0;
        for (int i = 1; i < dp.Length; i++)
        {
            dp[i] = int.MaxValue;
        }

        for (int i = 1; i <= books.Length; i++)
        {
            var maxHeight = 0;
            var width = 0;
            var j = i - 1;
            while (j >= 0)
            {

                width += books[j][0];
                if(width > shelfWidth)
                {
                    break;
                }
                //i: 3, j: 1 mean we take book 3,and 2 to the same row
                maxHeight = Math.Max(maxHeight, books[j][1]);
                // in evry step we considering whether to take current book to a next level and sum up the total heigh (maxHeigh + dp[j])
                // or to take it with other books of previous level if the width allows dp[i]
                dp[i] = Math.Min(dp[i], maxHeight + dp[j]);

                // Console tracing
                //Console.WriteLine($"i: {i}, j: {j}, width: {width}, maxHeight: {maxHeight}, dp[i]: {dp[i]}");

                j--;
            }
        }

        return dp[books.Length];
    }
}
