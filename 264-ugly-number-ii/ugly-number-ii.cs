public class Solution {
    public int NthUglyNumber(int n) 
    {
        // 1, 2, 3, 4, 5, 6, 8, 9, 10, 12

        var pq = new PriorityQueue<long, long>();
        pq.Enqueue(1,1);
        var nums = new int[] { 2, 3, 5};
        var seen = new HashSet<long>();
        seen.Add(1);
        var current = 0L;
        var count  = 0L;
        while(count <n)
        {
            var pop = pq.Dequeue();
            
            current = pop;
            seen.Add( pop);
      
            foreach(var el in nums)
            {
                if(!seen.Contains(pop*el))
                {
                    pq.Enqueue(pop*el, pop*el); 
                    seen.Add( pop*el);
                }
            }
            count++;
        }

        return (int)current;
    }
}