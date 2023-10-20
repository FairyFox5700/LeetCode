public class Solution {
  
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            // topological sort
            var queue = new Queue<int>();
            var degree = new int[numCourses];
            var graph = BuildGraph(prerequisites);
            for (int i = 0; i < prerequisites.Length; i++)
            {
                // you need to finish 0 to take 1
                degree[prerequisites[i][1]]++;
                
            }

            for (int i = 0; i < degree.Length; i++)
            {
                if (degree[i] == 0)
                    queue.Enqueue(i);
            }

            var result = new Stack<int>();
            while (queue.Count > 0)
            {
                var pop = queue.Dequeue();
                result.Push(pop);
                var neigbours = graph.ContainsKey(pop)? graph[pop]: new List<int>();
                for (int i = 0; i < neigbours.Count; i++)
                {
                    var currneigbour = neigbours[i];
                    degree[currneigbour]--;
                    if (degree[currneigbour] == 0)
                    {
                        queue.Enqueue(currneigbour);
                    }
                }
            }

            return result.Count == numCourses ? result.ToArray() : new int[0];
        }

        private Dictionary<int, List<int>> BuildGraph(int[][] prerequisites)
        {
            var graph = new Dictionary<int, List<int>>();
            for (int i = 0; i < prerequisites.Length; i++)
            {
                var course = prerequisites[i][0];
                var pre = prerequisites[i][1];
                if (!graph.ContainsKey(course))
                    graph.Add(course, new List<int>());
                graph[course].Add(pre);
            }
            return graph;
        }
 
    /* using dfs and backtracking
  public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            var graph = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                if (!graph.ContainsKey(i))
                {
                    graph.Add(i, new List<int>());
                }
            }

            BuildGraph(prerequisites, graph);
            var visited = new HashSet<int>();
            var path = new HashSet<int>();
            var output = new List<int>();
  
            for(int index = 0; index < numCourses; index++)
            {
                if (!visited.Contains(index))
                {
                    if(!DFS(index, graph,  path, output, visited))
                    {
                        return new int[0];
                    }
                }
            }

            return output.ToArray();
        }

        private bool DFS(int n, Dictionary<int,List<int>> graph, HashSet<int> cycle, List<int> output, HashSet<int> visited)
        {
            if (cycle.Contains(n))
            {
                return false;
            }

            if (visited.Contains(n))
            {
                return true;
            }

            cycle.Add(n);
            var adjacent = graph[n];
            foreach(var adj in adjacent)
            {
                if(!DFS(adj, graph, cycle, output, visited))
                {
                    return false;
                }
            }

            output.Add(n);
            cycle.Remove(n);
            visited.Add(n);
            return true;
        }

        private static void BuildGraph(int[][] prerequisites, Dictionary<int, List<int>> graph)
        {
            foreach (var pair in prerequisites)
            {
                var course = pair[0];
                var prequisite = pair[1];
                if (!graph.ContainsKey(course))
                {
                    graph.Add(course, new List<int>());
                }

                if (!graph.ContainsKey(prequisite))
                {
                    graph.Add(prequisite, new List<int>());
                }

                graph[course].Add(prequisite);
            }
        }*/
}