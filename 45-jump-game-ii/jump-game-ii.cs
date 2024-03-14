public class Solution {
          public int Jump(int[] nums)
        {
            if(nums.Length <= 1)
            {
                return 0; // no jump requred
            }
            // max window we can reac from current location
            var left = 0;
            var right = 0;
            var maxReachedIndex = 0;
            var jumps = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // we try for each index in the reachable window
                for (int j = left; j <= right; j++)
                {
                    // max distance we can reach
                    // if we are on poistion 1, then the max index we can reach is 1 + nums[1]
                    // ex. arr = [2,3,1,1,4], reached = 1(index) + 3(nums[1]) = 4
                    maxReachedIndex = Math.Max(maxReachedIndex, nums[j] + j);
                }
                Console.WriteLine($"left: {left}, right: {right}, maxReachedIndex: {maxReachedIndex}");
                left = right; // current index
                right = maxReachedIndex; // max index we can reach from current index
                jumps++;
                if(maxReachedIndex >=  nums.Length -1)
                {
                    return jumps;
                }
            }

            return jumps;
        }
}