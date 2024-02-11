public class Solution
{
    public int MinMeetingRooms(int[][] intervals)
    {
        var pq = new PriorityQueue<int,int>();
        Array.Sort(intervals, (a, b) => a[0] - b[0]);// sort based on start time ascending
        var roomsCount = 0;
        for (int i = 0; i < intervals.Length; i++)
        {
             // ending time is less then start date of another interval ( make them in paralel)
            if(pq.Count>0 && pq.Peek() <= intervals[i][0])
            {
                roomsCount--;
                pq.Dequeue();
            }
           
            roomsCount++;
            pq.Enqueue(intervals[i][1],intervals[i][1]);
        }

        return roomsCount;
    }
}