public class Solution {
    public int FindUnsortedSubarray(int[] nums)
    {
        var max = int.MinValue;
        var min = int.MaxValue;
        for (int i = 1; i < nums.Length; i++)
        {
            //rising slope
            if (nums[i] < nums[i - 1])
            {
                min = Math.Min(min, nums[i]);
            }
        }
        
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            // falling slope
            if (nums[i] > nums[i + 1])
            {
                max = Math.Max(max, nums[i]);
            }
        }
        int l, r;
        for (l = 0; l < nums.Length; l++) {
            if (min < nums[l])
                break;
        }
        for (r = nums.Length - 1; r >= 0; r--) {
            if (max > nums[r])
                break;
        }
    
        return r - l < 0 ? 0 : r - l + 1;
    }
    
}