    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
            for (int i = 0; i < intervals.Length-1; i++)
            {
                var begining = intervals[i][0];
                var end = intervals[i][1];
                var beginingSecond = intervals[i + 1][0];
                var endSecond = intervals[i + 1][1];
                if (beginingSecond <= end)
                {
                    intervals[i][0] = -1;
                    intervals[i][1] = -1;
                    intervals[i+1][0] = begining;
                    intervals[i+1][1] = Math.Max(end, endSecond);
                }
            }

            return  intervals.Where(x => x[0] != -1).ToArray();
        }
    }