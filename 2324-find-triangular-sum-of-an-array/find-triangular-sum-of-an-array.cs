public class Solution {
    public int TriangularSum(int[] nums) {
        var count = nums.Length;
        while(count > 1)
        {
            for(int i =0; i<nums.Length-1; i++)
            {
                var newEl = (nums[i] + nums[i+1]) % 10;
                nums[i] = newEl;
            }
            count--;
        }
        
        return nums[0];
    }
}