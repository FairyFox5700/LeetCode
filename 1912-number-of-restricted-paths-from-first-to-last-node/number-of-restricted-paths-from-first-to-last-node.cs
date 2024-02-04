using System;
using System.Collections.Generic;

public class Solution
{
    public record Node(int node, int weight);

    public Dictionary<int, List<Node>> BuildGraph(int n, int[][] edges)
    {
        var graph = new Dictionary<int, List<Node>>();
        for (int i = 1; i <= n; i++) // Ensure all nodes are in the graph
        {
            graph[i] = new List<Node>();
        }

        foreach (var edge in edges)
        {
            var (v1, v2, w) = (edge[0], edge[1], edge[2]);
            graph[v1].Add(new Node(v2, w));
            graph[v2].Add(new Node(v1, w));
        }

        return graph;
    }

    public int CountRestrictedPaths(int n, int[][] edges)
    {
        var graph = BuildGraph(n, edges);
        var distances = DijkstraMinPath(n, graph);
        var dp = new int[n + 1]; // Array to collect restricted path counts
        Array.Fill(dp, -1); // Initialize with -1 to indicate unvisited

        return DFS(1, n, graph, dp, distances);
    }

    private int DFS(int current, int target, Dictionary<int, List<Node>> graph, int[] dp, Dictionary<int, int> dist)
    {
        if (current == target) return 1;
        if (dp[current] != -1) return dp[current];

        int paths = 0;
        foreach (var adj in graph[current])
        {
            if (dist[adj.node] < dist[current])
            {
                paths += DFS(adj.node, target, graph, dp, dist);
                paths %= 1000000007; // Correct modulo
            }
        }

        dp[current] = paths;
        return dp[current];
    }

    private Dictionary<int, int> DijkstraMinPath(int n, Dictionary<int, List<Node>> graph)
    {
        var distances = new Dictionary<int, int>();
        for (int i = 1; i <= n; i++) distances[i] = int.MaxValue; // Ensure all nodes are accounted for

        distances[n] = 0;
        var pq = new PriorityQueue<int, int>();
        pq.Enqueue(n, 0);

        while (pq.Count > 0)
        {
            var node = pq.Dequeue();
            foreach (var adjNode in graph[node])
            {
                var newDist = distances[node] + adjNode.weight;
                if (newDist < distances[adjNode.node])
                {
                    distances[adjNode.node] = newDist;
                    pq.Enqueue(adjNode.node, newDist);
                }
            }
        }

        return distances;
    }

    

    // Main method for testing omitted for brevity
}
