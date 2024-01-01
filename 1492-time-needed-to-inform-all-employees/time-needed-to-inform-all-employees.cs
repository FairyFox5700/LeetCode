public class Solution {
    public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime) {

        int managers = manager.Count();
        int infoTimes = informTime.Count();
        if(informTime.Count() <= 1 || manager.Count() <= 1)
        {
            return 0;
        }
        
        var adjList = new Dictionary<int,List<int>>();
        for(int i =0; i< manager.Count(); i++)
        {
            var currentManager = manager[i];
            if(currentManager!=-1)// root manager
            {
                if(adjList.ContainsKey(currentManager))
                {
                    adjList[currentManager].Add(i);
                }
                else {
                    adjList.Add(currentManager, new List<int> { i});
                }
            }
        }

        var maxTime = int.MinValue;
        var queue = new Queue<(int, int)>();
        queue.Enqueue((headID, informTime[headID]));
        while(queue.Count() > 0)
        {
            var (current, currentInfoTime) =  queue.Dequeue();

            if(!adjList.ContainsKey(current))
                continue;
            foreach(var adj in adjList[current])
            {
                var time = informTime[adj] + currentInfoTime;
                maxTime = Math.Max(maxTime, time);
                queue.Enqueue((adj, time));
            }
        }

        return maxTime;
        
    }
}