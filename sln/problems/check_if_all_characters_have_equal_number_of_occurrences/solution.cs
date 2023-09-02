    public class Solution
    {
        public bool AreOccurrencesEqual(string s)
        {
            var dict = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }

         var firstCount = dict.First().Value;
        
        return dict.Values.All(x => x == firstCount);
        }
    }