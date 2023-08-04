    public class Solution
    {
        public int CharacterReplacement(string s, int k)
        {
            // used to calculate the most repeated char in window
            var dict = new Dictionary<char, int>();
            var left = 0;
            var maxlen = 0;
            var resultedMaxLen = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict.Add(s[i], 0);
                }
                dict[s[i]]++;
                maxlen = Math.Max(maxlen, dict[s[i]]);
                // condition when it is not longer possible to replace chars
                while (i - left + 1 > maxlen +k)
                {
                    dict[s[left]]--;
                    left++;
                }
                resultedMaxLen = Math.Max(resultedMaxLen,i - left + 1);
            }

            return resultedMaxLen;
        }
    }
