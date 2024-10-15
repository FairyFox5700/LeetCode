public class Solution
{
    public int SmallestChair(int[][] times, int targetFriend)
    {

        var availableSeats = new SortedSet<int>();
        var leavingQueue = new PriorityQueue<(int, int), int>();
        var targetArr = times[targetFriend][0];
        var nextAvailable = 0;

        Array.Sort(times,(a, b) => a[0] - b[0]);

        foreach (var time in times)
        {
            var arr = time[0];
            var dep = time[1];

            while (leavingQueue.Count > 0 && leavingQueue.Peek().Item1 <= arr)
            {
                var chair = leavingQueue.Dequeue();
                availableSeats.Add(chair.Item2);
            }

            var nextChair = availableSeats.Count == 0 ? nextAvailable++ : availableSeats.Min();

            leavingQueue.Enqueue((dep, nextChair), dep);
            availableSeats.Remove(nextChair);

            if(arr == targetArr)
            {
                return nextChair;
            }
        }

        return 0;
    }
}