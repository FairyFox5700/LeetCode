
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            var left = 0;
            var right = nums.Length - 1;
            if(nums.Count() == 1)
            {
                return nums[0];
            }
            var min = int.MaxValue;
            while (left <= right)
            {
              var mid = (left + right) / 2;
              Console.WriteLine(left);
              min = Math.Min(min, nums[left]);
              if (nums[mid] >= nums[left])
              {
                    left = mid + 1;
              }
              else
              {
                    min = Math.Min(min, nums[mid]);
                    right = mid -1;
              }
            }

            return min;
        }
    }