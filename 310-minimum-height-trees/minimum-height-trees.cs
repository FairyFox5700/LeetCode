    public class Solution
    {

        private record TreeNode(int Value, int Degree);
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            var degree = new int[n];
            var graph = new Dictionary<int, List<int>>();
            var result = new List<int>();
            if(n==1)
            {
                    result.Add(0);
                    return result;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                var v1 = edges[i][0];
                var v2 = edges[i][1];
                degree[v1]++;
                degree[v2]++;

                if(!graph.ContainsKey(v1))
                    graph.Add(v1, new List<int>() { v2});
                else
                {
                    graph[v1].Add(v2);
                }

                if(!graph.ContainsKey(v2))
                    graph.Add(v2, new List<int>() { v1 });
                else
                {
                    graph[v2].Add(v1);
                }
            }

            var queue = new Queue<int>();
            for (int i = 0; i < degree.Length; i++)
            {
                if (degree[i] == 1)
                {
                    queue.Enqueue(i);
                }
            }

            while (queue.Count>0 && n>2)
            {
                var currentCount = queue.Count;
                while (currentCount>0)
                {
                    var pop = queue.Dequeue();
                    n--;
                    foreach (var neighbour in graph[pop])
                    {
                        degree[neighbour]--;
                        if (degree[neighbour] == 1)
                            queue.Enqueue(neighbour);
                    }
                    currentCount--;
                }
            }

              
            while (queue.Count>0)
            {
                result.Add(queue.Dequeue());
            }

  
                

            return result;
        }
    }

