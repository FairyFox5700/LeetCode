    public class Solution
    {
        public int MaximumScore(int a, int b, int c)
        {
            /*Declare ans and initialize it with zero.
    Insert size of three piles of stones in a priority queue/heap.
    Run a loop till the priority queue/heap contains only one pile with non zero stones
    Extract the second largest and largest pile of stones.
    Remove them from the priority queue/heap.
    Decrease the size of both piles of stones by 1. Insert them back in the priority queue/heap.
    Increase ans by 1.
    Return ans .
    Time Complexity: of the solution: O(k logn), where k is the answer which is how many times the while loop runs.
    Space Complexity: O(n)
    https://www.tutorialspoint.com/program-to-find-maximum-score-from-removing-stones-in-python
    https://csforall.in/2022/10/26/algomaster-sheet-maximum-score-from-removing-stones/
    */

            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            // max heap
            pq.Enqueue(a, a);
            pq.Enqueue(b, b);
            pq.Enqueue(c, c);
            var cnt = 0;
            while (pq.Count >= 2)
            {
                var first = pq.Dequeue();
                var second = pq.Dequeue();
                if (first - 1 > 0)
                {
                    pq.Enqueue(first - 1, first - 1);
                }

                if (second - 1 > 0)
                {
                    pq.Enqueue(second - 1, second - 1);
                }

                cnt++;
            }

            return cnt;
        }
    }