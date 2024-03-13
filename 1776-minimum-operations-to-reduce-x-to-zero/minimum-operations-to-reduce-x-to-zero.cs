    public class Solution
    {
        public int MinOperations(int[] nums, int x)
        {
            var operations = int.MaxValue;
            var left = 0;
            var right = 0;
            var sum = 0;
            var currentSum = nums.Sum();
            while (right < nums.Length)
            {
                if(nums[right] == x)
                {
                    return 1;
                }
                currentSum -= nums[right];
                right++;
                while (currentSum<x && left<right)
                {
                    currentSum += nums[left];
                    left++;
                }

                if (currentSum == x)
                {
                    operations = Math.Min(operations, left + nums.Length - right);
                }
            }

            return operations == int.MaxValue ? -1: operations;
        }
    }