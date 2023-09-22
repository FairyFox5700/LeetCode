    public class Solution
    {
        // pq
        // Complexity:
        // Memory = O(n)
        // CPU = O(nlogn + nlogn)
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var list = new List<int>();
            // using two pointers
            var left = 0;
            var right = arr.Length - 1;
            while (right-left >=k) // we need to find k element, means we stop if start el eq = right -k
                        {
                // Math.Abs(arr[left] - x) it is a distance to the x, so if it is longer on left side, then we need to move left pointer
                if (Math.Abs(arr[left] - x) > Math.Abs(arr[right] - x))
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            for (int i = left; i <= right; i++)
            {
                list.Add(arr[i]);
            }

            return list;

            /*var list = new List<int>();
            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) =>
            {
                var cmp = Math.Abs(a - x).CompareTo(Math.Abs(b - x));
                if (cmp == 0)
                {
                    return a.CompareTo(b);
                    // a > b return 1
                    // priority queue is by default min heap
                    // so if a > b then a should be at the top of the heap
                }
                return cmp;
            }));
            foreach (var val in arr)
            {
                pq.Enqueue(val, val);
            }

            while (k > 0 && pq.Count > 0)
            {
                var el = pq.Dequeue();
                list.Add(el);
                k--;
            }

            list.Sort();
            return list;
        }*/
    }
    }