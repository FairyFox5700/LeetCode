public class Solution {
    public bool CheckPossibility(int[] nums) {
        int numViolations = 0;
        for (int i = 1; i < nums.Length; i++) {
            
            if (nums[i - 1] > nums[i]) {
                
                if (numViolations == 1) {
                    return false;
                }
                numViolations++;
                if (i >= 2 && nums[i - 2] > nums[i] && i < nums.Length - 1 && nums[i - 1] > nums[i + 1]) {
                    return false;
                }
            }
        }
        return true;
    }
}