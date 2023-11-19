public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        var right = 1;
        var count = 0;
        if(nums.Count() <=1) return 1;
        //10,5,2,6
        for(int i =0; i< nums.Length; i++)
        {
            right = i;
            var product = 1;
            while(right < nums.Length && product * nums[right] < k )
            {
                product*= nums[right];
                count++;
                right++;
            }
        }

        return count;
    }
}