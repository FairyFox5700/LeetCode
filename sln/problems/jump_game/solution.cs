    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            var total = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // we can not reac this index
                if(i>total)
                {
                    return false;
                }
                // max distance we can reach
                total = Math.Max(total, nums[i] + i);
            }

            return true;

        }
    }