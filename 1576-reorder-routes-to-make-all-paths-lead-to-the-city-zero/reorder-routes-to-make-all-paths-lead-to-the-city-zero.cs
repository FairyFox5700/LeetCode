    public class Solution
    {
        private int _numberOfChanges = 0;

        public int MinReorder(int n, int[][] connections)
        {
            var graph = BuildGraph(connections);
            var visited = new HashSet<int>();

            for (int i = 0; i < graph.Count; i++)
            {
                DFS(i, 0, graph,visited);
            }

            return _numberOfChanges;
        }

        private Dictionary<int, List<(int, int)>> BuildGraph(int[][] connections)
        {
            var graph = new Dictionary<int, List<(int, int)>>();
            for (int i = 0; i < connections.Length; i++)
            {

                var v1 = connections[i][0];
                var v2 = connections[i][1];
                if (!graph.ContainsKey(v1))
                {
                    graph.Add(v1, new List<(int, int)>()
                    {
                        (v2, 1),
                    });
                }
                else
                {
                    graph[v1].Add((v2, 1));
                }

                if (!graph.ContainsKey(v2))
                {
                    graph.Add(v2, new List<(int, int)>()
                    {
                        (v1, 0),
                    });
                }
                else
                {
                    graph[v2].Add((v1, 0));
                }
            }

            return graph;
        }

        private void DFS(int node, int sign, Dictionary<int, List<(int, int)>> graph, HashSet<int> visited)
        {
            if (visited.Contains(node))
            {
                return;
            }

            _numberOfChanges += sign;
            visited.Add(node);
            foreach (var neighbour in graph[node])
            {
               DFS(neighbour.Item1, neighbour.Item2, graph, visited);
            }
        }
    }