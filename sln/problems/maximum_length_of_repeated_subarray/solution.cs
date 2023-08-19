    public class Solution
    {
        public int FindLength(int[] nums1, int[] nums2)
        {
            // same approach as longest-palindromic-substring
            //https://www.youtube.com/watch?v=BgLVRkA8w6w&ab_channel=TimothyHChang

            var dp = new int[nums1.Length + 1, nums2.Length + 1];
            var maxLength = 0;
            for (int i = 1; i <= nums1.Length; i++)
            {
                for (int j = 1; j <= nums2.Length; j++)
                {
                    if (nums1[i-1] == nums2[j-1])
                    {
                        dp[i,j] = dp[i - 1, j - 1] + 1;
                        maxLength = Math.Max(maxLength, dp[i,j]);
                    }
                }
            }

            return maxLength;
        }
    }