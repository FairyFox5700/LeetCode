    public class Solution
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {

            var dict = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word,1);
                }
                else {
                        dict[word]++;
                }
                
            }

            var s = new SortedSet<KeyValuePair<string, int>>(Comparer<KeyValuePair<string, int>>.Create((a, b) =>
            {
                var cmp = b.Value.CompareTo(a.Value);
                if (cmp == 0)
                {
                    return a.Key.CompareTo(b.Key);
                    // so a letter is goes before b letter
                }
                return cmp;
            }));


            foreach (var kvp in dict)
            {
                s.Add(kvp);
            }

            var result = new List<string>();
            while (k > 0 && s.Count > 0)
            {
                k--;
                result.Add(s.First().Key);
                s.Remove(s.First());
            }
            return result;
        }
    }