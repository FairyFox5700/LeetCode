    public class Solution
    {
        public int MaxSumAfterPartitioning(int[] arr, int k)
        {
            var dp = new int[arr.Length+1];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                var lenofcurrentsubsequnce = 1;
                var maxElement = 0;
                var maxSum = 0;
                for (int j = i; j < Math.Min(i + k, arr.Length); j++)
                {
                    maxElement = Math.Max(maxElement, arr[j]);
                    var currentSum = maxElement * lenofcurrentsubsequnce + dp[j + 1]; // dp [j+1] is the sum of the rest of the array
                    maxSum = Math.Max(maxSum, currentSum);
                    lenofcurrentsubsequnce++;
                }
                dp[i] = maxSum;
            }

            return dp[0];
        }
    }