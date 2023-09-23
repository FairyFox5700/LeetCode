    public class Solution
    {
        public int LeastInterval(char[] tasks, int n)
        {
            var dict = new Dictionary<char, int>();
            foreach (var ch in tasks)
            {
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, 0);
                }
                dict[ch]++;
            }

            var pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            // max heap
            foreach (var kvp in dict)
            {
                if (kvp.Value > 0)
                    pq.Enqueue(kvp.Key, kvp.Value);
            }
            var timeToProcess = 0;
            Queue<(char, int, int)> queue = new Queue<(char, int, int)>();
            while (queue.Count > 0 || pq.Count > 0)
            {
                timeToProcess++;
                if (pq.Count > 0)
                {
                    var ch = pq.Dequeue();
                    dict[ch]--;
                    if (dict[ch] > 0)
                    {
                        queue.Enqueue((ch, dict[ch], timeToProcess + n));
                    }
                }
               
                if (queue.Count > 0 && queue.TryPeek(out var item) && item.Item3 == timeToProcess)
                {
                    queue.Dequeue();
                    pq.Enqueue(item.Item1, item.Item2);
                   
                }
            }
            return timeToProcess;
        }
    }