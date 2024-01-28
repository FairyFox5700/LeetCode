    public class Solution
    {
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var dict = new Dictionary<int, List<int>>();

            for (int i = 0; i < ppid.Count; i++)
            {
                if (!dict.ContainsKey(ppid[i]))
                {
                    dict.Add(ppid[i], new List<int>());
                }
                Console.WriteLine("ppid;" +ppid[i]  +"p:" + pid[i]);
                dict[ppid[i]].Add(pid[i]);
            }

            for (int i = 0; i < pid.Count; i++)
            {
                if (!dict.ContainsKey(pid[i]))
                {
                    dict.Add(pid[i], new List<int>());
                }
            }

            var items = dict[kill];
            var result = new List<int>() {kill};
           result.AddRange(GetAllChildren(dict, kill));
            return result;
        }

        private List<int> GetAllChildren(Dictionary<int, List<int>> map , int kill)
        {
            var result = new List<int>();
           
            var items = map[kill];
            result.AddRange(items);
            foreach (var kid  in items)
            {
                result.AddRange(GetAllChildren(map, kid));
            }
            return result;
        }
    }