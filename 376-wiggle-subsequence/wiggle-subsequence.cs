   public class Solution
    {
        public int WiggleMaxLength(int[] nums)
        {
            var length = 0;
            var lastSign = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                var diffSign = Math.Sign(nums[i + 1] - nums[i]);
             
                if (diffSign != 0 && diffSign != lastSign)
                {
                    length ++;
                    lastSign = diffSign;
                }
            }

            return length+1;
        }
    }
