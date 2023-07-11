public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var res = new List<int[]>();
        foreach( var interval in intervals)
        {
            // two cases when not overlapping
            // 1. when the endNew is less then begining of old
            if(newInterval[1]< interval[0])
            {
                res.Add(newInterval);
                newInterval = interval;
            }
            // 2. beginingNew is more then end interval ( then we need to check furthen intervals)
            else if (newInterval[0] > interval[1])
            {
                res.Add(interval);
            }
            else {
                 newInterval =  new int []
                 {
                     Math.Min( newInterval[0],interval[0]), Math.Max(newInterval[1],interval[1] )
                 } ;
            }
            
        }
        res.Add(newInterval);
        return res.ToArray();
        /*
        there are several casses
        1. interval: [1, 3] , newInterval: [2, 5]
            solution: [1, 5]
        2. interval: [2, 3] , newInterval: [2, 5]
            solution: [2, 5]
        3. interval: [2, 7] , newInterval: [2, 5]
            solution: [2, 7]
        4. interval: [3, 4] , newInterval: [2, 5]
            solution: [3, 5]
        5. interval: [3, 7] , newInterval: [2, 5]
            solution: [3, 7]
        */
        
    }
}