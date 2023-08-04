    public class Solution
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            var left = 0;
            var countOfAnagrams = 0;
            var result = new List<int>();

            var hasmapOfPointer = new Dictionary<char, int>();

            foreach (var ch in p)
            {
                if (!hasmapOfPointer.ContainsKey(ch))
                {
                    hasmapOfPointer.Add(ch, 0);
                }
                hasmapOfPointer[ch]++;
            }

            var hasmapOfWindow = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!hasmapOfWindow.ContainsKey(s[i]))
                {
                    hasmapOfWindow.Add(s[i], 0);
                }
                hasmapOfWindow[s[i]]++;
                var currentWindowLength = i - left + 1;
                if (currentWindowLength == p.Length)
                {
                    var currentMatchCount = 0;
                    foreach (var (key,value) in hasmapOfPointer)
                    {
                        if (hasmapOfWindow.ContainsKey(key) && hasmapOfPointer[key] == hasmapOfWindow[key])
                        {
                            currentMatchCount+=hasmapOfWindow[key] ;
                        }
                        
                    }
                    Console.WriteLine( currentMatchCount);
                    if (currentMatchCount == p.Length)
                    {
                        result.Add(left);
                    }
                }

                if (currentWindowLength >= p.Length)
                {
                    hasmapOfWindow[s[left]]--;
                    left++;
                }
            }

            return result;
        }
    }