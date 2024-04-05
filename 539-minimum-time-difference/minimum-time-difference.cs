    public class Solution
    {
        public int FindMinDifference(IList<string> timePoints)
        {
            var listTime = new List<int>();
            for (int i = 0; i < timePoints.Count; i++)
            {
                var point = timePoints[i].Split(":");
                var p1 = int.Parse(point[0]) ;
                var p2 = int.Parse(point[1]) ;
                var totalMinutes = p1 * 60 + p2;
                listTime.Add(totalMinutes);
            }

            listTime.Sort();
            var min = int.MaxValue;
            for (int i = 1; i < listTime.Count; i++)
            {
                var diff = Math.Abs(listTime[i]- listTime[i-1]);
                min = Math.Min(diff , min);
            }

            // calculate circulal nature of timePoints
            var circularDiff =  Math.Abs(listTime[0]+ 24 *60 - listTime[listTime.Count-1]);
            min = Math.Min(circularDiff  , min);
            return min;
        }
    }