public class Solution {
    public int MajorityElement(int[] nums) {
        // sot and select element which is more then a middle
        Array.Sort(nums);

        return nums[nums.Count()/2];
        
    }
}