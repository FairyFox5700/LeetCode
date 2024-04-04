public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        // array set or sorting
        var result = new List<int>();
        for(int i = 0; i< nums.Length; i++)
        {
            var previousIndex = Math.Abs(nums[i]) -1;
            if(nums[previousIndex]<0)
            {
                result.Add(Math.Abs(nums[i]));
            }
            nums[previousIndex]*= -1;
        }

        return result;
    }
}