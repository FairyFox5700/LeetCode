    public class Solution
    {
        public int MinSetSize(int[] arr)
        {
            var hashmap = new Dictionary<int, int>();
            foreach (int i in arr)
            {
                if (!hashmap.ContainsKey(i))
                {
                    hashmap.Add(i, 1);
                }
                else
                {
                    hashmap[i]++;
                }
            }

            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            foreach (var (key, val) in hashmap)
            {
                pq.Enqueue(key, val);
            }

            int counter = 0;
            int answ = 0;
            while (pq.Count > 0)
            {
                var el = pq.Dequeue();
                counter += hashmap[el]; // num of occurrence of this element
                answ++;
                if (counter >= arr.Length / 2)
                {
                    return answ;
                }

            }

            return arr.Length;
            //https://beizhedenglong.github.io/leetcode-solutions/docs/reduce-array-size-to-the-half
        }
    }