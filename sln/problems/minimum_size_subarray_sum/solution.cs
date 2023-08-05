public class Solution {
       public int MinSubArrayLen(int target, int[] nums)
        {

            int minLen = int.MaxValue;
            var left = 0;
            var currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                while (currentSum >= target)
                {
                    minLen = Math.Min(minLen, (i - left + 1));
                    currentSum -= nums[left];
                    left++;
                }
            }

            return minLen == int.MaxValue ? 0 : minLen;
        }
}