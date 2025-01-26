public class Solution
{
    public bool ValidTree(int n, int[][] edges)
    {

        // A valid tree must have exactly n - 1 edges
        if (edges.Length != n - 1)
        {
            return false;
        }

        if(edges.Length == 0)
        {
            return true;
        }
        // Build the graph
        var graph = BuildGraph(edges);
        var parent = new Dictionary<int, int>();
        parent.Add(edges[0][0], -1);
        // Set to track visited nodes
        var seen = new HashSet<int>();

        // Perform DFS starting from node 0
        DFS(edges[0][0],  seen, graph, parent);

        // Check if all nodes are connected
        return seen.Count == n;
    }

    private bool DFS(int current, HashSet<int> seen, Dictionary<int, List<int>> graph, Dictionary<int, int> parent)
    {
        // Mark the current node as visited
        seen.Add(current);
        // Visit all neighbors
        foreach (var neighbor in graph[current])
        {
            if(parent[current] == neighbor)
            {
                // trivial cycle
                continue;
            }

            if(parent.ContainsKey(neighbor))
            {
                // cycle
                return false;
            }

            parent.Add(neighbor, current);

            if (!DFS(neighbor,  seen, graph, parent))
            {
                return false;
            }
        }

        return true; // No cycles detected
    }

    public Dictionary<int, List<int>> BuildGraph(int[][] edges)
    {
        var graph = new Dictionary<int, List<int>>();

        foreach (var edge in edges)
        {
            int node1 = edge[0];
            int node2 = edge[1];

            if (!graph.ContainsKey(node1))
            {
                graph[node1] = new List<int>();
            }
            graph[node1].Add(node2);

            if (!graph.ContainsKey(node2))
            {
                graph[node2] = new List<int>();
            }
            graph[node2].Add(node1);
        }

        return graph;
    }
}
