public class Solution
{
    public int MinimumSwaps(int[] nums)
    {
        var min = int.MaxValue;
        var minIndex = -1;
        var max = int.MinValue;
        var maxIndex = -1;
        for (int i = 0; i < nums.Length; i++)
        {

            if (min > nums[i])
            {
                minIndex = i;
                min = nums[i];
            }

            if (max <= nums[i]) // this will make sure we handle duplicate max value, that we encounter later in array
            {
                max = nums[i];
                maxIndex = i;
            }
        }

        var swapsForMin = minIndex;
        var swapsForMax = (nums.Length-1) - maxIndex;
        if(minIndex> maxIndex)
            swapsForMin--; // during move of the largest one, the smallest one will mode on direction below

        return swapsForMax + swapsForMin;
    }
}