    public class Solution
    {
        public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
        {

            //using dfs

            var graph = BuildGraph(prerequisites);

            var result = new List<bool>();
            foreach (var query in queries)
            {
                var start = query[0];
                var end = query[1];
                // take 0 to take 1
                result.Add(DFS(new bool[numCourses], graph, start, end));

            }

            return result;
        }

        private bool DFS(bool[] visited, Dictionary<int, List<int>> graph, int node, int end)
        {
            if(node == end)
                return true;
            if (visited[node])
                return false;

            visited[node] = true;
            var neigbours = graph.ContainsKey(node)?graph[node]: new List<int>();
            foreach (var neigbour in neigbours)
            {
                if(DFS(visited, graph, neigbour, end))
                    return true;
            }

            return false;
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
        /* using toplogical sort
             public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries)
        {

            // topological sort
            var preq = new Dictionary<int, List<int>>();
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
                preq.Add(i, new List<int>());
                if (degree[i] == 0)
                    queue.Enqueue(i);
            }

            while (queue.Count > 0)
            {
                var pop = queue.Dequeue();
                var cuurrpreq = preq[pop];
                var neigbours = graph.ContainsKey(pop) ? graph[pop] : new List<int>();
                for (int i = 0; i < neigbours.Count; i++)
                {
                    preq[neigbours[i]].Add(pop);
                    preq[neigbours[i]].AddRange(cuurrpreq);
                    var currneigbour = neigbours[i];
                    degree[currneigbour]--;
                    if (degree[currneigbour] == 0)
                    {
                        queue.Enqueue(currneigbour);
                    }
                }
            }


            var bresult = new List<bool>();
            foreach (var pair in queries)
            {
                if (preq.ContainsKey(pair[1])&& preq[pair[1]].Contains(pair[0]))
                    bresult.Add(true);
                else
                    bresult.Add(false);
            }

            return bresult;
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
        */
    }