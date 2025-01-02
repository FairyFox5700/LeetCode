    public class Solution
    {
        public int LongestSubarray(int[] nums, int limit)
        {
            var minPq = new PriorityQueue<int, int>();
            var maxPq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            int left = 0;
            int right = 0;
            var longestLength = 0;
            while (left < nums.Length && right < nums.Length)
            {
                minPq.Enqueue(right, nums[right]);
                maxPq.Enqueue(right, nums[right]);

                while (nums[maxPq.Peek()] - nums[minPq.Peek()] > limit)
                {
                    longestLength = Math.Max(longestLength, right - left);
                    // remove out of range
                    while (maxPq.Peek() <= left)
                    {
                        maxPq.Dequeue();
                    }

                    while(minPq.Peek() <= left)
                    {
                        minPq.Dequeue();
                    }
                    left++;
                }
                right++;
            }

            return Math.Max(longestLength, right - left);
        }
    }