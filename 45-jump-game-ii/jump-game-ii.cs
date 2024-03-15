    public class Solution
    {
        // 2 3 1 1 4
        public int Jump(int[] nums)
        {
            var maxReach = 0;
            var steps = 0;
            var min = int.MaxValue;
            var maxEnd = 0;
            var target = nums.Length - 1;
            if(nums.Length == 1) return 0;

            for (int i = 0; i < nums.Length; i++)
            {
                maxReach = Math.Max(maxReach, i + nums[i]);
                Console.WriteLine(maxReach);

                if(target<=maxReach)
                {
                    return steps +1;
                }

                if (i == maxEnd)
                {
                    steps++;
                    maxEnd = maxReach;
                }
            }

            return steps;
        }
    }
