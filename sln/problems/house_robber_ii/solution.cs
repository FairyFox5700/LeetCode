    public class Solution
    {
        //nums = [2,3,2]
        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0];
            }
            var withFirst = RobRange(0, nums.Length - 1, nums);
            var withoutFirst = RobRange(1, nums.Length, nums);
            return Math.Max(withFirst, withoutFirst);
        }

        public int RobRange(int start, int end, int[] nums)
        {
            var robbed_prev = 0;
            // accumulates max of two previous houses
            var robbedCurrentStep = 0;
            for (int i = start; i < end; i++)
            {
                var temp = Math.Max(robbed_prev + nums[i], robbedCurrentStep);
                robbed_prev = robbedCurrentStep;
                robbedCurrentStep = temp;
            }

            return robbedCurrentStep;
        }
    }