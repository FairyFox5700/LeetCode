public class Solution {
        public record NetworkNode(int node, int time);
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            var graph  = BuildGraph(times);
            // stores the distances
            var dictionary = new Dictionary<int, int>();
            var queue = new PriorityQueue<int, int>();

            // init all nodes to max value
            for (int i = 0; i <=n; i++)
            {
                dictionary.Add(i, int.MaxValue);
            }

            //init source with 0
            dictionary[k] = 0;
            // add source to queue
            queue.Enqueue(k, 0);
            // k is starting position
            while(queue.Count > 0)
            {
                Dijkstra(graph, dictionary, queue);
            }
            int maxDis = 0;
        
            for(int i=1;i<=n;i++)
                maxDis = Math.Max(maxDis,dictionary[i]);
        
            return maxDis==int.MaxValue ? -1 : maxDis;
            
        }

        private void Dijkstra(Dictionary<int, List<NetworkNode>> graph, Dictionary<int, int> dictionary,PriorityQueue<int, int> queue)
        {
          
            var current = queue.Dequeue();
            if (!graph.ContainsKey(current))
            {
                return;
            }

            foreach (var node in graph[current])
            {
                var newDistance = dictionary[current] + node.time;
                Console.WriteLine($"{newDistance} nedistance to node {node.node}");
                if (newDistance < dictionary[node.node])
                {
                    dictionary[node.node] = newDistance;
                    queue.Enqueue(node.node, newDistance);
                    
                }
                
            }
            
        }


        private Dictionary<int, List<NetworkNode>> BuildGraph(int[][] times)
        {
            var graph = new Dictionary<int, List<NetworkNode>>();
            for (int i = 0; i < times.Length; i++)
            {
                var source = times[i][0];
                if (!graph.ContainsKey(source))
                {
                    graph[source] = new List<NetworkNode>();
                }
                var target = times[i][1];
                var weight = times[i][2];
                graph[source].Add(new NetworkNode(target, weight));
            }

            return graph;
        }
}