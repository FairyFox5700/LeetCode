    public class Solution
    {
        public int DeleteAndEarn(int[] nums)
        {
            // contains frequencies of element
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }

            // now we can use only keys, as we know there will not be any duplicates
            var keys = dict.Keys.ToArray();
            Array.Sort(keys);
            // after sorting, we can imply which objects are adjacent to each other

            //2,2,3,3,3,4
            // 2: 2; 3: 3; 4: 1;

            var dp = new int[keys.Length];
            dp[0] = keys[0] * dict[keys[0]];
            if(keys.Count() == 1)
            {
                return dp[0];
            }
            if (keys[1] == keys[0] + 1)
            {
                dp[1] = Math.Max(dp[0], keys[1] * dict[keys[1]]);
            }
            else
            {
                dp[1] = dp[0] + keys[1] * dict[keys[1]];
            }
            for (int i = 2; i <= keys.Length-1; i++)
            {
                if (i == 0)
                {
                    dp[i] = keys[i] * dict[keys[i]]; // value  * frequency
                }
                else if (keys[i] == keys[i - 1] + 1) // they are adjuscent
                {
                    // we can not take both of them, so we take the one with the biggest value
                    dp[i] = Math.Max(dp[i - 1], dp[i-2] + keys[i] * dict[keys[i]]);
                }
                else
                {
                    dp[i] = dp[i - 1] + keys[i] * dict[keys[i]];
                }
            }

            return dp[keys.Length - 1];
        }
    }