    public class Solution
    {
        public int LongestSubsequence(int[] arr, int difference)
        {
            var hashMap = new Dictionary<int, int>();
            foreach (var item in arr)
            {
                var diff = item - difference;
                hashMap.TryGetValue(diff, out int accumulatedLength);
                if (hashMap.ContainsKey(item))
                {
                    hashMap[item] = accumulatedLength + 1;
                }
                else
                {
                    hashMap.Add(item, accumulatedLength + 1);
                }
            }
            return hashMap.Values.Max();
        }
    }