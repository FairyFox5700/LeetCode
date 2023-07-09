public class Solution {
    public int Rob(int[] nums) {
        // robbing = 1. the option to rob the current house and discar previous result
        // 2. the option to rob the adjacent house + rob[from previous houses]
        // recurence:
        // rob[i] = Math.Max(currentVal, rob[i-2] + currentVal);
        var rob = new int[nums.Count()];
        if(nums.Count() == 1)
        {
            return nums[0];
        }
        rob[0] = nums[0]; // base case
        rob[1] =Math.Max(nums[0],nums[1]); 
        // they are two adjacent , so the sum is not accumulated
        for(int i = 2; i< nums.Count(); i++)
        {
            Console.WriteLine(rob[i-1]);
            rob[i] = Math.Max(rob[i-1], rob[i-2] + nums[i]);
            Console.WriteLine(rob[i]);
        }

        return rob[nums.Count()-1];
        
    }
}