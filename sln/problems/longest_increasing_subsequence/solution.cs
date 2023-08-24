    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            // the length of increasing subsequence  is at least 1 for each item
            var dp = new int[nums.Length];
            // nums = [1, 3, 2, 4]
            // length of increasing subsequence for item 4 = 1 ( no increasing subsequence after 4), but 4 itself is a subsequnce
            dp[nums.Length - 1] = 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                // starting from the end of array, becuase we know that it is the lastest element and there will be no increasing number afterwards
                var currentMax = 0;
                // check previous values
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j]) // we allowed to do this only for increasing subsequence
                    {
                        // if the current item is less than the next item, we add 1 to the previous max
                        currentMax = Math.Max(currentMax, dp[j]);
                    }
                }
                dp[i] = currentMax + 1; // previous max +1 ( current item)
            }

           return dp.Max();
        }
    }