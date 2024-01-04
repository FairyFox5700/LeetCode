    public class Solution
    {
        public int Trap(int[] height)
        {
            var n = height.Count();
            var leftMax = new int[n];
            var rightMax = new int[n];
            rightMax[n - 1] = height[n - 1];
            leftMax[0] = height[0];
            for (int i = 1; i < n; i++)
            {
                leftMax[i] = Math.Max(leftMax[i-1], height[i]);
            }
            for (int i = n-2; i>=0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i+1], height[i]);
            }

            var result = new int[n];
            for(int i = 0; i < n; i++)
            {
                var current =  Math.Min(leftMax[i], rightMax[i]) - height[i];
                if(current < 0)
                {
                    result[i] = 0;
                }
                else
                {
                    result[i] = current;
                }
            }

            return result.Sum();
        }
    }