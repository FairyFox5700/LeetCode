
        public class Solution
        {
            public long TotalCost(int[] costs, int k, int candidates)
            {
                var comparer = Comparer<(int, int)>.Create((a, b) =>
                {
                    int costComparison = a.Item1.CompareTo(b.Item1);
                    if (costComparison != 0) return costComparison;
                    return a.Item2.CompareTo(b.Item2);
                });

                var totalCost = 0L;
                var pq = new PriorityQueue<(int, int), (int, int)>(comparer: comparer);
                var n = costs.Length;

                var head = candidates;
                var tail = Math.Max(n - candidates, candidates);
                for (int i = 0; i < candidates; i++)
                {
                    pq.Enqueue((1, costs[i]), (costs[i],1));
                }
                for (int i = tail; i < n; i++)
                {
                    pq.Enqueue((2, costs[i]), (costs[i], 2));
                }

                head = candidates; // next head
                tail = n - 1 - candidates; // next tail
                for (int i = 0; i < k; i++)
                {
                    Console.WriteLine("head: " + head);
                    Console.WriteLine("tail: " + tail);
                    var (index, cost) = pq.Dequeue();
                    Console.WriteLine("index: " + index);
                    if (head <= tail)
                    {
                        if (index == 1)
                        {
                            Console.WriteLine("costs[head]: " + costs[head]);
                            pq.Enqueue((1, costs[head]),( costs[head], 1));
                            head++;
                        }
                        else
                        {
                            pq.Enqueue((2, costs[tail]), (costs[tail],2));
                            tail--;
                        }

                    }
                    totalCost += cost;
                }

                return totalCost;
            }
        }