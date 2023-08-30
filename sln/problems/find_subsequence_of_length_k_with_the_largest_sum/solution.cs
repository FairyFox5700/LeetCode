  public class Solution
    {
        public int[] MaxSubsequence(int[] nums, int k)
        {
            var pairs = nums.Select((n, i) => (n, i)).ToArray();
            return pairs.OrderByDescending(p => p.n).Take(k)
                .OrderBy(p => p.i).Select(e => e.n).ToArray();
        }
    }