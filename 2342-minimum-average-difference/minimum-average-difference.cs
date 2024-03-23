public class Solution {
    public int MinimumAverageDifference(int[] nums) {
        int n = nums.Length;
        int ans = -1;
        int minAvgDiff = int.MaxValue;

        // Generate prefix and suffix sum arrays.
        long[] prefixSum = new long[n + 1];
        long[] suffixSum = new long[n + 1];

        for (int index = 1; index <= n; index++) {
            prefixSum[index] = prefixSum[index-1] + nums[index-1];
        }

        for (int index = n; index > 0; index--) {
            suffixSum[index- 1] = suffixSum[index] + nums[index-1];
        }

        for (int index = 0; index < n; index++) {
            long leftPartAverage = prefixSum[index + 1] / (index + 1);
            long rightPartAverage = suffixSum[index + 1];
            if (index != n - 1) {
                rightPartAverage /= (n - index - 1);
            }
            int currDifference = (int)Math.Abs(leftPartAverage - rightPartAverage);
            if (currDifference < minAvgDiff) {
                minAvgDiff = currDifference;
                ans = index;
            }
        }

        return ans;
    }
}
