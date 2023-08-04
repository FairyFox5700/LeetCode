    public class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var result = new HashSet<string>();
            // containes words of length 10
            var hashMap = new HashSet<string>();
            var left = 0;
            for (int i = 0; i < s.Length -9; i++)
            {
                var subDNA = s.Substring(i, 10);
                if (hashMap.Contains(subDNA))
                {
                    result.Add(subDNA);
                }
                hashMap.Add(subDNA);
                left++;
            }

            return result.ToList();
        }
    }