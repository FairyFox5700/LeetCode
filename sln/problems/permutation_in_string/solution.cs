  public class Solution
    {
        public bool CheckInclusion(string s1, string s2)
        {
            var hasMap = new Dictionary<char, int>();
            foreach (var ch in s1)
            {
                if (!hasMap.ContainsKey(ch))
                {
                    hasMap.Add(ch, 0);
                }

                hasMap[ch]++;
            }

            var left = 0;

            while (left <= s2.Length - s1.Length)
            {
                var s2hashMap = new Dictionary<char, int>();
                for (int i = 0; i < s1.Length ; i++) // only s1 characters
                {
                    var current = s2[i + left];
                    s2hashMap.TryAdd(current, 0);
                    s2hashMap[current]++;
                }
                Console.WriteLine(left);
                var result = true;
                foreach (var (key, val) in hasMap)
                {
                    if (s2hashMap.ContainsKey(key) && hasMap[key] == s2hashMap[key])
                    {
                        result&=true;
                    }
                    else
                    {
                        result = false;
                    }
                }

                if(result) return true;
                left++;
            }

            return false;
    }
    }
