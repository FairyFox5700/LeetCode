    public class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            var n = nums.Length;
            var left = 0;
            var max = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("i: " + i);
                if (nums[i] == 0 && k>=0)
                {
                    k--;
                }
                while(k<0)
                {
                    Console.WriteLine("max: " + max);
                    if(nums[left]==0)
                    {
                        k++;// return number of zeros
                    }
                    left++;
                }
                max = Math.Max(max, i - left + 1);
            }

            return max;
        }
    }