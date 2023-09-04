    public class Solution
    {
        public int FindPairs(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if(!dict.ContainsKey(num))
                    dict.Add(num, 1);
                else
                    dict[num]++;
            }

            var counter = 0;
            foreach (var key in dict.Keys)
            {
                if (k == 0)
                {
                    if (dict.ContainsKey(key) && dict[key] > 1)
                        counter++;
                }
                else
                {
                    if (dict.ContainsKey(key + k))
                        counter++;
                    if (dict.ContainsKey(key - k))
                        counter++;
                    dict.Remove(key);
                }
            }
            return counter;
        }
    }