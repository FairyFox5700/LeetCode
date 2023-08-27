    public class Solution
    {
        public bool CanPartition(int[] nums)
        {
            // the devision to two should be without reminder ( target should be a whole number)
            if (nums.Sum() % 2 == 1)
            {
                return false;
            }
            var target = nums.Sum() / 2;
            var dp = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == target)
                {
                    return true;
                }
                
                foreach (var el in dp.ToList())
                {
                    var sum = el + nums[i];
                    if(sum < target)
                    {
                        dp.Add(sum);
                    }
                    
                    // if we ever find a subset with a sum equal to half of the total sum, we can partition the array
                    // target = nums.Length / 2; garantees that if we found subarray which sum equals to target, the rest element will form another value equal to target
                    if (sum == target)
                    {
                        return true;
                    }
                }
                dp.Add(nums[i]);
            }

            return false;
        }
    }