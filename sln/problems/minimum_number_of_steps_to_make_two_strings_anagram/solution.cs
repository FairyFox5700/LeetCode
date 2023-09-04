    public class Solution
    {
        public int MinSteps(string s, string t)
        {
            var dict = new Dictionary<char, int>();
            foreach (var chs in s)
            {
                if(!dict.ContainsKey(chs))
                    dict.Add(chs, 1);
                else
                    dict[chs]++;
            }

            foreach (var cht in t)
            {
                if(dict.ContainsKey(cht))
                    dict[cht]--;
            }

            return dict.Values.Where(e => e > 0).Sum();
        }
    }