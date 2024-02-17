    public class Solution
    {
        //kadans algortihm
        public int MaxProduct(int[] nums)
        {
            var minEndinHere = nums[0];
            var maxEndingHere = nums[0];
            var max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                var current = nums[i];
                var previous = maxEndingHere * current;
                var previosMin = minEndinHere * current;

                maxEndingHere = Math.Max(current, Math.Max(previous, previosMin));
                minEndinHere = Math.Min(current, Math.Min(previous, previosMin));
                max = Math.Max(maxEndingHere, max);
              
            }
            return max;
        }
    }