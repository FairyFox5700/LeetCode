public class Solution {
    public int ConnectSticks(int[] sticks) 
    {
        var pq = new PriorityQueue<int, int>();

        foreach(var el in sticks)
        {
            pq.Enqueue(el, el);
        }

        var total = 0;
        
        while( pq.Count > 1)
        {
            var el1 = pq.Dequeue();
            var el2 = pq.Dequeue();
            var sum = el1 + el2;

            total+=(sum);
            pq.Enqueue(sum, sum);
        }

        return total;
    }
}