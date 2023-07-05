public class Solution {
    public int MaxSubArray(int[] nums) {
        int subMax = int.MinValue;
        int max = int.MinValue;
        for(int i = 0; i< nums.Count(); i++)
        {
            
            if(subMax < 0)
            {
                subMax = 0;
            }
            subMax += nums[i];
            max = Math.Max(subMax, max);
        }
        return max;
    }
}