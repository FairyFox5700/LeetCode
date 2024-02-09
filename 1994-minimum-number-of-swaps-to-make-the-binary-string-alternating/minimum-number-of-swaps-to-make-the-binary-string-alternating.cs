public class Solution
{
    public int MinSwaps(string s)
    {
        var str = s;
        var countOfOnes = 0;
        var countOfZeros = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == '1')
            {
                countOfOnes++;
            }
            else
            {
                countOfZeros++;
            }
        }

        if (Math.Abs(countOfOnes - countOfZeros) > 1)
            return -1;

        if (countOfOnes > countOfZeros)
        {
           return CountSwaps(s, '1');
        }
        else if (countOfZeros > countOfOnes)
        {
            return CountSwaps(s, '0');
        }
       
        return Math.Min(CountSwaps(s, '0'), CountSwaps(s, '1'));
    }

    public int CountSwaps(string s, char ch)
    {
        var swaps = 0;
        for (int i = 0; i < s.Length; i+=2)
        {
            if (s[i] != ch)
            {
                swaps++;
            }
        }

        return swaps;
    }
}