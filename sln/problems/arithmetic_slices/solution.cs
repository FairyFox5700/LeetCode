public class Solution {

    //https://leetcode.com/problems/arithmetic-slices/solutions/3262569/413-solution-with-step-by-step-explanation/
         public int NumberOfArithmeticSlices(int[] nums)
        {
            if (nums.Length < 3)
            {
                return 0;
            }

            var prevDiff = nums[1] - nums[0];
            var count = 0;
            var totalCount = 0;
            for (int i = 1; i < nums.Length - 1; i++)
            {
                var currentDif = nums[i+1] - nums[i];
                if (prevDiff == currentDif)
                {
                    count++;
                }
                else
                {
                    prevDiff = currentDif;
                    count = 0;
                }

                totalCount+= count;
            }

            return totalCount;
        }
}