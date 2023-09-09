public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var left = 0;
            var right = nums.Length - 1;
            var firstIndex = -1;
            var lastIndex = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                // Console.WriteLine($"left = {left}, right = {right}, mid = {mid}");

                if (nums[mid] == target)
                {
                    firstIndex = mid;
                    right = mid - 1; // Continue searching on the left side
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            left = 0;
            right = nums.Length - 1;
            // right index
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                // Console.WriteLine($"left = {left}, right = {right}, mid = {mid}");

                if (nums[mid] == target)
                {
                    lastIndex = mid;
                    left = mid + 1; // Continue searching on the right side
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return new int[] { firstIndex, lastIndex };
        }
    }