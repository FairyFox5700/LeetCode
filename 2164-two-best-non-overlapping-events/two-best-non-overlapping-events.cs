public class Solution {
    public int MaxTwoEvents(int[][] events) {
        var orderedEvents = events.OrderBy(e=>e[0]).ToList();
        var current = 0;
        var max = int.MinValue; 
        var accumulatedValue = 0;
        var runningMax = 0; // max till this point, all the events that fo before have the value accumulaed here
        var pq = new PriorityQueue<int[], int>(Comparer<int>.Create((a, b) => a.CompareTo(b)));
        for(int i = 0; i< orderedEvents.Count(); i++)
        {
            var item = orderedEvents[i];
            while(pq.Count> 0 && item[0] > pq.Peek()[1]) // not overlappping
            {
                var pair = pq.Dequeue();
                runningMax= Math.Max(runningMax, pair[2]);
                //max = Math.Max( max, +current);
            }
            max = Math.Max( max, runningMax+ item[2]); //mpair with currecnt value and the may value form one of the previous events
            pq.Enqueue(item, item[1]);
        }

        return max;
    }
}