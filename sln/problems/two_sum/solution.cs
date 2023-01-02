
public class Solution {
    private Dictionary<int,int> set = new Dictionary<int,int>();

    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Count(); i++)
        {
            var diff = target - nums[i];
            if(set.ContainsKey(diff))
            {
                return new int[2]{i, set[diff]};
            }
            if(!set.ContainsKey(nums[i]))
            {
               set.Add(nums[i],i);
            }
        }
         return new int[2] {0,0};
    }
}