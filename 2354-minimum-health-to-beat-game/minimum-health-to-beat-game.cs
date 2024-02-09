public class Solution
{
    public long MinimumHealth(int[] damage, int armor)
    {
        var max = 0L;
        var maxIndex = -1;
        var sum = 0L;
        for (int i = 0; i < damage.Length; i++)
        {
      
                if(max< damage[i])
                {
                    max = damage[i];
                    maxIndex = i;
                }
                
          

            sum += damage[i];
        }

        if (maxIndex != -1 && armor > 0)
        {
            if(armor > max)
            {
                 return sum - max +1;
            }
            var helpFromArmor = max - armor;
            return (sum - armor +1);
        }

        return sum + 1;


    }
}