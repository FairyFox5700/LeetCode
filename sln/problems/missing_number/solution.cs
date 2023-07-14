public class Solution {
    public int MissingNumber(int[] nums) {
        var sum = nums.Count() *(nums.Count() +1)/2;
        return sum - nums.Sum();
    }
}