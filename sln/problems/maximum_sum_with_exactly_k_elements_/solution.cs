public class Solution {
    public int MaximizeSum(int[] nums, int k) {
        Array.Sort(nums);
            int sum = 0;

            for(int i = 0; i<k; i++)
            {
                sum += nums[nums.Length - 1];
                nums[nums.Length - 1] += 1;
            }

            return sum;
    }
}