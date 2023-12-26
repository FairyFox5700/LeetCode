public class Solution {
            public int SubarraySum(int[] nums, int k)
            {
                var sum = 0;
                var count = 0;
                var dict = new Dictionary<int, int>();
                dict.Add(0,1);
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    if (dict.ContainsKey(sum - k))
                    {
                        count += dict[(sum - k)];
                    }
                    if(!dict.ContainsKey(sum))
                        dict.Add((sum), 1); 
                    else
                        dict[sum]++;
                   
                }
                return count;
            }
}