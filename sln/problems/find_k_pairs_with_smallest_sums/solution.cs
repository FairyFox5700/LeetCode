    public class HeapInfo
    {
        public int Num1Index { get; set; }
        public int Num2Index { get; set; }
    }

    public class Solution
    {
        public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k)
        {
            var result = new List<IList<int>>();
            var pq = new PriorityQueue<HeapInfo, int>(Comparer<int>.Create((a, b) => a.CompareTo(b)));
            pq.Enqueue(new HeapInfo()
            {
                Num1Index = 0,
                Num2Index = 0,
            }, nums1[0] + nums1[0]);
            var answer = new List<IList<int>>();

            var hashSet = new HashSet<(int,int)>();
            while (k>0 && pq.Count >0)
            {
                var heapInfo = pq.Dequeue();
                answer.Add(new List<int> { nums1[heapInfo.Num1Index], nums2[heapInfo.Num2Index] });

                if (heapInfo.Num1Index + 1 < nums1.Length && !hashSet.Contains((heapInfo.Num1Index+1, heapInfo.Num2Index)))
                {
                    pq.Enqueue(new HeapInfo()
                                        {
                        Num1Index = heapInfo.Num1Index + 1,
                        Num2Index = heapInfo.Num2Index,
                    }, nums1[heapInfo.Num1Index + 1] + nums2[heapInfo.Num2Index]);
                    hashSet.Add((heapInfo.Num1Index + 1, heapInfo.Num2Index));
                }

                if (heapInfo.Num2Index + 1 < nums2.Length && !hashSet.Contains((heapInfo.Num1Index, heapInfo.Num2Index +1)))
                {
                    pq.Enqueue(new HeapInfo()
                    {
                        Num1Index = heapInfo.Num1Index,
                        Num2Index = heapInfo.Num2Index + 1,
                    }, nums1[heapInfo.Num1Index] + nums2[heapInfo.Num2Index + 1]);

                    hashSet.Add((heapInfo.Num1Index, heapInfo.Num2Index + 1));
                }
                k--;
            }

            return answer;
        }
    }
