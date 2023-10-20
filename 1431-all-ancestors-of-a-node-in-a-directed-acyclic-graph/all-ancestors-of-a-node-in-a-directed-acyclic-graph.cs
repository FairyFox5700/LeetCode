    public class Solution
    {
        public IList<IList<int>> GetAncestors(int n, int[][] edges)
        {
            //using dfs
            var graph = BuildGraph(edges);
            var visited = new bool[n];
            var result = new List<IList<int>>();
            for (int i = 0; i < n; i++)
            {
                var curr = new HashSet<int>();
                result.Add(DFS(graph, new bool[n], i, ref curr).OrderBy(e=>e).ToList());
            }

            return result;
        }

        private HashSet<int> DFS(Dictionary<int, List<int>> graph, bool[] visited, int node, ref HashSet<int> result)
        {
            if (visited[node])
                return result;
            visited[node] = true;

            var neigbours = graph.ContainsKey(node) ? graph[node] : new List<int>();
            foreach (var neigbour in neigbours)
            {
                result.Add(neigbour);
                DFS(graph, visited, neigbour, ref result);
            }

            return result;
        }

        private Dictionary<int, List<int>> BuildGraph(int[][] prerequisites)
        {
            var graph = new Dictionary<int, List<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                var course = prerequisites[i][1];
                var pre = prerequisites[i][0];
                if (!graph.ContainsKey(course))
                    graph.Add(course, new List<int>());
                graph[course].Add(pre);
            }
            return graph;
        }
    }