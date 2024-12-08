public class Solution {
    public bool PossibleBipartition(int n, int[][] dislikes) {
        // If there are no dislikes, we can trivially bipartition
        if (dislikes.Length == 0) return true;

        // Create the graph
        var graph = BuildGraph(n, dislikes);

        // Initialize a color array with -1 (unvisited)
        var color = new int[n + 1];
        Array.Fill(color, -1);

        // Use BFS to check for bipartiteness
        for (int i = 1; i <= n; i++) {
            if (color[i] == -1) { // Start BFS for unvisited nodes
                var queue = new Queue<int>();
                queue.Enqueue(i);
                color[i] = 0; // Assign first color (group 0)

                while (queue.Count > 0) {
                    var current = queue.Dequeue();
                    
                    foreach (var neighbor in graph[current]) {
                        if (color[neighbor] == -1) { // If not yet colored, color it with opposite color
                            color[neighbor] = 1 - color[current];
                            queue.Enqueue(neighbor);
                        } else if (color[neighbor] == color[current]) {
                            // If neighbor has the same color, the graph is not bipartite
                            return false;
                        }
                    }
                }
            }
        }

        return true;
    }

    private Dictionary<int, List<int>> BuildGraph(int n, int[][] dislikes) {
        var graph = new Dictionary<int, List<int>>();

        // Initialize the adjacency list
        for (int i = 1; i <= n; i++) {
            graph[i] = new List<int>();
        }

        // Add edges based on dislikes
        foreach (var pair in dislikes) {
            int a = pair[0];
            int b = pair[1];
            graph[a].Add(b);
            graph[b].Add(a);
        }

        return graph;
    }
}
