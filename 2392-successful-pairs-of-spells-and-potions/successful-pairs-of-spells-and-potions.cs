    public class Solution
    {
    private int GetLowerBoundIndex(int[] spells, int[] sortedPotions, long success, int spellsIndex)
    {
        var right = sortedPotions.Length - 1;
        var left = 0;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var data = (long)spells[spellsIndex] * sortedPotions[mid];
            if (data < success)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left;
    }

    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        var sortedPotions = potions.OrderBy(p => p).ToArray();
        var pairs = new int[spells.Length];
        
        for (int spellsIndex = 0; spellsIndex < spells.Length; spellsIndex++)
        {
            var lowerBound = GetLowerBoundIndex(spells, sortedPotions, success, spellsIndex);
            pairs[spellsIndex] = sortedPotions.Length - lowerBound;
        }

        return pairs;
    }
    }