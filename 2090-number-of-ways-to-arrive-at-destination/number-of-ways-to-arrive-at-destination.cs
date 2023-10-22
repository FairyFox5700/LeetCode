public class Solution
{
    public int CountPaths(int n, int[][] roads)
    {
        var graph = BuildGraph(roads);
        var pq = new PriorityQueue<(int, double), double>();
        var dist = new double[n];
        for (int i = 0; i < n; i++)
            dist[i] = double.MaxValue;

        dist[0] = 0;

        pq.Enqueue((0, 0), 0);
        var waysToReach = new long[n];
        waysToReach[0] = 1; // There's one way to reach the start node
        while (pq.Count > 0)
        {
            var pop = pq.Dequeue();
            var neighbors = graph.ContainsKey(pop.Item1) ? graph[pop.Item1] : new List<(int, double)>();
            foreach (var neighbor in neighbors)
            {
                var tempDist = pop.Item2 + neighbor.Item2;
                if (dist[neighbor.Item1] > tempDist)
                {
                    dist[neighbor.Item1] = tempDist;
                    pq.Enqueue((neighbor.Item1, tempDist), tempDist);
                    waysToReach[neighbor.Item1] = waysToReach[pop.Item1] % 1_000_000_007;
                }
                else if (dist[neighbor.Item1] == tempDist) // in case of same distance
                {
                    waysToReach[neighbor.Item1] = (waysToReach[neighbor.Item1] + waysToReach[pop.Item1]) % 1_000_000_007;
                }
            }
        }

        return (int)waysToReach[n - 1];
    }

    private Dictionary<int, List<(int, double)>> BuildGraph(int[][] roads)
    {
        var dict = new Dictionary<int, List<(int, double)>>();
        for (int i = 0; i < roads.Length; i++)
        {
            var edge = roads[i];
            var src = edge[0];
            var dst = edge[1];
            var weight = edge[2];
            if (!dict.ContainsKey(src))
                dict.Add(src, new List<(int, double)>());
            if (!dict.ContainsKey(dst))
                dict.Add(dst, new List<(int, double)>());
            dict[src].Add((dst, weight));
            dict[dst].Add((src, weight));
        }

        return dict;
    }
}
