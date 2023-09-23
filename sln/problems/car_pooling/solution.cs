    public class Solution
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            trips = trips.OrderBy(x => x[1]).ToArray();
            // trips now orddered by start time);
            var pq = new PriorityQueue<(int,int,int), int>(Comparer<int>.Create((a, b) => a.CompareTo(b)));
            // min heap
            // the structure of pq = number of pessanger, endTime

            var currentPassengers = 0;
            foreach (var trip in trips)
            {
                var startTime = trip[1];
                var endTime = trip[2];
                var passengers = trip[0];

                while (pq.Count > 0 && pq.Peek().Item3 <=startTime)
                {
                    currentPassengers-=pq.Peek().Item1;
                    pq.Dequeue();
                    // passangers droped off
                }
                pq.Enqueue((passengers, startTime, endTime), endTime);
                currentPassengers += passengers;
                if (currentPassengers > capacity)
                    return false;
            }

            return true;
        }
    }
