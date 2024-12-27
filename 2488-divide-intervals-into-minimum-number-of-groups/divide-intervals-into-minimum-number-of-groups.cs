        public class Solution
        {
            public int MinGroups(int[][] intervals)
            {
                var events = new List<(int, int)>();

                for (int i = 0; i < intervals.Count(); i++)
                {
                    var range = intervals[i];
                    events.Add((range[0], 1));
                    events.Add((range[1], -1));
                }

                // [1,1]], 1, -1 is cancelling , 1,+1 , but we have one active ( first +1 , then -1)
                events = events.OrderBy(e => e.Item1)
                    .ThenByDescending(e => e.Item2).ToList();

                var maxActiveOverlaps = 0;
                var currentActiveOverlaps = 0;

                for (int i = 0; i < events.Count(); i++)
                {
                    var current = events[i];
                    if (current.Item2 > 0)
                    {
                        currentActiveOverlaps++;
                    }
                    if(current.Item2 < 0)
                    {
                        currentActiveOverlaps--;
                    }

                    maxActiveOverlaps = Math.Max(maxActiveOverlaps, currentActiveOverlaps);
                }

                return maxActiveOverlaps;
            }
          
        }