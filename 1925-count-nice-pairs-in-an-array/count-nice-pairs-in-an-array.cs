  public class Solution
    {
        public int CountNicePairs(int[] nums)
        {
            var answer = 0;
            var dict = new Dictionary<int, int>();
            var mod = 1000000007;
            for (int i = 0; i < nums.Length; i++)
            {
                var rev = reverse(nums[i]);
                var diff = nums[i] - rev;
                if (dict.ContainsKey(diff))
                {
                    answer = (answer + (dict[diff] % mod) ) % mod;
                    dict[diff]++;
                }
                else
                {
                    dict.Add(diff, 1);
                }
            }

            return answer;
        }

        private int reverse(int num)
        {
            var current = 0;
            while (num>0)
            {
                var digit = num % 10;
                current = current * 10 + digit;
                num /= 10;
            }

            return current;
        }
    }