public class Solution {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            var visited = new HashSet<int>();
            var result = new List<int>();
            var safeNodes = new bool[graph.Length];
            // Initialize an empty array safeNodes to store the safe nodes.
            // initially all nodes are unsafe
            // Perform a DFS traversal on each unvisited node in the graph:
            // Set the state of the current node to true.
            //  Recursively visit all neighbors of the current node:
            // If the neighbor is in the DFS path, mark the current node as unsafe and return.
            // If the neighbor is unvisited, perform a DFS visit on it.
            // If the neighbor is safe, continue.
            for (int i = 0; i < graph.Length; i++)
            {
                if (DFS(i, visited, safeNodes, graph))
                {
                    result.Add(i);
                }
            }

            return result;

        }

        private bool DFS(int node, HashSet<int> visited, bool[] safeNodes, int[][] graph)
        {
            //safe nodes contains node with at least one outgoing edge
            if (visited.Contains(node))
            {
                return safeNodes[node];
            }
            // mask as visited
            visited.Add(node);

            var isTerminal = true; // no outgoing edges
            foreach (var neighbour in graph[node])
            {
                isTerminal &= DFS(neighbour, visited, safeNodes, graph);
            }

            // if all neighbours are safe then current node is safe
            if (isTerminal)
            {
                safeNodes[node] = true;
            }

            return isTerminal;
        }
    
}