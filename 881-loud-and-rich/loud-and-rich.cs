    public class Solution
    {
        public int[] LoudAndRich(int[][] richer, int[] quiet)
        {
             var graph = BuildGraph(richer);
             var visited = new bool[quiet.Length];
             var answer = new int[quiet.Length+1];
             for (int i = 0; i < quiet.Length; i++)
             {
                 answer[i] = int.MaxValue;
             }
             var result = new int[quiet.Length];
             for (int i = 0; i < quiet.Length; i++)
             {
                 result[i] = DFS(graph, visited, i, answer, quiet);
             }

             return result;
        }

        private int DFS(Dictionary<int, List<int>> graph, bool[] visited, int node, int[] answer, int[]quite)
        {
            if (visited[node])
                return answer[node];

            if (answer[node] != int.MaxValue)
                return node;
            else
                answer[node] = node;

            visited[node] = true;
            var neigbours = graph.ContainsKey(node) ? graph[node] : new List<int>();
            foreach (var neigbour in neigbours)
            {
                var candidate = DFS(graph, visited, neigbour,  answer, quite);
                if(quite[candidate] < quite[answer[node]]) 
                {
                    answer[node] = candidate;
                }
            }

            return answer[node];
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