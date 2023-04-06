public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        var l = 0;
        var sum = 0;
        double maxsum = double.MinValue;
        for(int r = 0; r < nums.Count(); r++)
        {
           while(r-l < k && r < nums.Count())
           {
              sum += nums[r];
              Console.WriteLine(sum);
              r++;
           }

            maxsum = Math.Max((double)sum/k, maxsum);
            sum -= nums[l];
            l++;
            r--;
           
        }
        return maxsum;
    }
}