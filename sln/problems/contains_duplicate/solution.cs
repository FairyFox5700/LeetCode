public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i< nums.Count(); i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }
        foreach(var val in dict.Values)
        {
            if(val > 1)
            {
                return true;
            }
        }

        return false;
    }
}