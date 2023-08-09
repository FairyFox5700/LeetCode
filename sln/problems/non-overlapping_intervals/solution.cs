    public class Solution
    {
        public int EraseOverlapIntervals(int[][] intervals)
        {
            Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
           
            var begining = intervals.First()[0];
            var end = intervals.First()[1];
            var countOfIntervals = 0;
            for (int i = 1; i < intervals.Count(); i++)
            {
                var currentInterval =intervals.ElementAt(i);
                var currentBegining = currentInterval[0];
                var currentEnding = currentInterval[1];
                if (currentBegining < end)
                {
                    countOfIntervals++;
                    end = Math.Min(end, currentEnding);
                }
                else
                {
                    end = currentEnding;
                }
            }

            return countOfIntervals;
        }
    }