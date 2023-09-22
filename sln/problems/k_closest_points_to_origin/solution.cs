    public class Solution
    {
        public int[][] KClosest(int[][] points, int k)
        {
            //https://csforall.in/2022/10/31/algomaster-sheet-find-k-closest-elements/
            // can also be solved using priority queue

            //
            var pq = new PriorityQueue<int[], double>();
            // min heap
            foreach (var p in points)
            {
                var distance = EqulidianDistance(p[0], p[1], 0, 0);
                pq.Enqueue(p, distance);
            }

            var result = new int[k][];
            while (k>0 && pq.Count >0)
            {
                k--;
                result[k] = pq.Dequeue();
            }

            return result;
        }

        private double EqulidianDistance(int x1, int y1, int x2, int y2)
        {
            return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
        }
    }