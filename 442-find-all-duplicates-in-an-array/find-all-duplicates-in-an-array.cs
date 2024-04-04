public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        // array set or sorting
        var dict = new HashSet<int>();
        var result = new List<int>();
        for(int i = 0; i< nums.Length; i++)
        {
            if(!dict.Contains(nums[i]))
            {
                dict.Add(nums[i]);
            }
            else {
                result.Add(nums[i]);
            }
        }

        return result;
    }
}