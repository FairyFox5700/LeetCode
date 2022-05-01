public class Solution {
    public int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var result = target - nums[i];
                if (dictionary.ContainsKey(result))
                {
                    return new[] { dictionary[result], i };
                }
                else
                {
                    if(!dictionary.ContainsKey(nums[i]))
                    {
                       dictionary.Add(nums[i], i); 
                    }
                }
            }

            return new int[] { };
        }
}