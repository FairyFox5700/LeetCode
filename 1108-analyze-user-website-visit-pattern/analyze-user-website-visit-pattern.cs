    public class Solution
    {
        public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website)
        {
            var dictionary = new Dictionary<string, List<(string,int)>>();

            for(int i = 0; i < username.Length;i++)
            {
                if (!dictionary.ContainsKey(username[i]))
                {
                    dictionary[username[i]] = new List<(string,int)>();
                }
                dictionary[username[i]].Add((website[i],timestamp[i]));
            }


        var counter = new Dictionary<string, HashSet<string>>();

        foreach (var (key, val) in dictionary)
        {
            if (val.Count >= 3)
            {
                Backtracking(new List<string>(), counter, key, 0, val.OrderBy(e => e.Item2).Select(e => e.Item1).ToList());
            }
        }

        var max = 0;
        var keys = new List<string>();

        foreach (var (key, val) in counter)
        {
            if (val.Count > max)
            {
                max = val.Count;
                keys = new List<string> { key };
            }
            else if (val.Count == max)
            {
                keys.Add(key);
            }
        }

        Console.WriteLine(string.Join(",", keys.OrderBy(e => e)));

        return keys
            .OrderBy(e => e)
            .First()
            .Split("-")
            .ToList();
        }
    
        private void Backtracking(List<string> currentPermutation, Dictionary<string, HashSet<string>> counter,
            string userName, int index, List<string> websites)
        {
            if(currentPermutation.Count == 3)
            {
                var key = $"{currentPermutation[0]}-{currentPermutation[1]}-{currentPermutation[2]}";
             
                if (!counter.ContainsKey(key))
                {
                    counter.Add(key, new HashSet<string>());
                }
                counter[key].Add(userName);
                currentPermutation = new List<string>();
                return;
            }

            for(int i = index; i < websites.Count(); i++)
            {
                currentPermutation.Add(websites[i]);
                Backtracking(currentPermutation, counter, userName, i+1, websites);
                currentPermutation.RemoveAt(currentPermutation.Count() -1);
            }
        }
    }