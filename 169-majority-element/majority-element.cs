public class Solution {
    public int MajorityElement(int[] nums) {
        var count = 0;
        var majorityEl = 0;

        foreach(var num in nums) {
            if(count == 0) {
                majorityEl = num;
            }
            if(num == majorityEl) {
                count++;
            } else {
                count--;
            }
        }

        return majorityEl;
    }
}
