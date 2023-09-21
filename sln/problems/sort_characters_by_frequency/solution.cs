    public class Solution
    {
        public string FrequencySort(string s)
        {
            //https://webrewrite.com/sort-characters-by-frequency/

            //using ucket search
            var hashmap = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (!hashmap.ContainsKey(ch))
                {
                    hashmap.Add(ch, 1);
                }
                else
                {
                    hashmap[ch]++;
                }
            }

            var buckets = new List<char>[s.Length + 1];
            foreach (var (key, val) in hashmap)
            {
                if (buckets[val] == null)
                {
                    buckets[val] = new List<char>();
                }
                buckets[val].Add(key);
            }

            var sb = new StringBuilder();
            for (int i = buckets.Length - 1; i >= 0; i--)
            {
                if (buckets[i] != null)
                {
                    foreach (var ch in buckets[i])
                    {
                        for (int j = 0; j < i; j++)
                        {
                            sb.Append(ch);
                        }
                    }
                }
            }

            return sb.ToString();
            /*
            var pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            var hashmap = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                if (!hashmap.ContainsKey(ch))
                {
                    hashmap.Add(ch, 1);
                }
                else
                {
                    hashmap[ch]++;
                }
            }

            foreach (var (key, val) in hashmap)
            {
                pq.Enqueue(key, val);
            }

            var sb = new StringBuilder();
            while (pq.Count > 0)
            {
                var el = pq.Dequeue();
                for (int i = 0; i < hashmap[el]; i++)
                {
                    sb.Append(el);
                }
            }

            return sb.ToString();
            */
        }
    }
