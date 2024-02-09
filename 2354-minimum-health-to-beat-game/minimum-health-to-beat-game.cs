public class Solution
{
    public long MinimumHealth(int[] damage, int armor)
    {
        var max = 0L;
        var sum = 0L;
        for (int i = 0; i < damage.Length; i++)
        {
                if(max< damage[i])
                {
                    max = damage[i];
                }
            sum += damage[i];
        }

            return  sum - Math.Min(armor, max) +1;
        }

    }
