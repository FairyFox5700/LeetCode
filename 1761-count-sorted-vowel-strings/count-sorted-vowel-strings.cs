
public class Solution
{
    public int CountVowelStrings(int n)
    {
        //https://www.youtube.com/watch?v=gdt7HQF56OI&ab_channel=Fraz

        var dp = new int[n+1, 5];
        dp[0, 0] = 1;

        for (int i = 1; i < 5; i++)
        {
            dp[0,i]+= dp[0,i-1];
        }

        for (int i = 1; i < n+1; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (j == 0)
                {
                    dp[i, j] = 1;
                }
                else
                {
                    dp[i, j] = dp[i, j - 1] + dp[i - 1, j];
                    // represent dp[i-1,j -- number of strings we collected of length 2, having ( i-1) characters and ending
                    // dp[i, j-1] -- number of available character, with which we can collect combinations
                    // having a character u and 4 different character {a,e,i,u} -- we can collect {ua, ue, ui, uu}
                }
            }
        }

        return dp[n , 4];
    }
}