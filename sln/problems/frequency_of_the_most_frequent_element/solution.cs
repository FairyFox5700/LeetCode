public class Solution {
       public int MaxFrequency(int[] nums, int k)
        {
            var sortedArray = nums.OrderBy(x => x).ToArray();
            var left = 0;
            long currentSum = 0;
            int maxFreq = 0;
            for (int i = 0; i < sortedArray.Length; i++)
            {
                currentSum += sortedArray[i];
                if (sortedArray[i] * ( i - left + 1) > currentSum + k)
                {
                    currentSum -= sortedArray[left];
                    left++;
                }
                maxFreq = Math.Max(maxFreq, i - left + 1);
                
            }
            return maxFreq;
        }
}