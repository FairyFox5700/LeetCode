    public class Solution
    {
        public long MaxScore(int[] nums1, int[] nums2, int k)
        {
            var min = 0;

            var pairs = new List<(int, int)>();
            //O(n)
            for (int i = 0; i < nums1.Length; i++)
            {
                pairs.Add((nums1[i], nums2[i]));
            }
            //O(mlogm) - try to minimize both arrays
            pairs = pairs.OrderByDescending(p => p.Item2).ToList();
            var pq = new PriorityQueue<(int,int), int>();
            var maxScore = 0L;
            var currentTotal = 0L;
            for (int i = 0; i < pairs.Count; i++)
            {
                Console.WriteLine("i: " + i);
        while (pq.Count < k && i < pairs.Count)
            {
                pq.Enqueue(pairs[i], pairs[i].Item1);
                currentTotal += pairs[i].Item1;
                i++;
            }
            if (pq.Count == k)
            {
                maxScore = Math.Max(maxScore, currentTotal * pairs[i - 1].Item2);
                var el = pq.Dequeue();
                currentTotal -= el.Item1;
                i--;
            }
        
            }

            return maxScore;
        }
    }