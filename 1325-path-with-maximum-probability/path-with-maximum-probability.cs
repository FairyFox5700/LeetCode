    public class Solution
    {
        public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
        {
            // Bellman-Ford algorithm improved
            var distances = new double[n];
            distances[start_node] = 1;
            var quue = new PriorityQueue<(int, double), double>(Comparer<double>.Create((double a, double b) => b.CompareTo(a)));

            var graph = BuildGraph(edges, succProb);

            // probability of start is 1
            quue.Enqueue((start_node, 1), 1);

            while (quue.Count > 0)
            {
                var pop = quue.Dequeue();
                var neigbours = graph.ContainsKey(pop.Item1) ? graph[pop.Item1] : new List<(int, double)>();
                foreach (var edge in neigbours)
                {
                    var u = pop.Item1;
                    var w = edge.Item1;
                    var newDist = pop.Item2 * edge.Item2;
                    if (newDist > distances[w])
                    {
                        distances[w] = newDist;
                        quue.Enqueue((w, newDist), newDist);
                    }
                }
            }

            return distances[end_node];
        }

        private Dictionary<int, List<(int, double)>> BuildGraph(int[][] edges, double[] succprobes)
        {
            var dict = new Dictionary<int, List<(int, double)>>();
            for (int i = 0; i < edges.Length; i++)
            {
                var edge = edges[i];
                var src = edge[0];
                var dst = edge[1];
                var prob = succprobes[i];
                if (!dict.ContainsKey(src))
                    dict.Add(src, new List<(int, double)>());
                if (!dict.ContainsKey(dst))
                    dict.Add(dst, new List<(int, double)>());
                dict[src].Add((dst, prob));
                dict[dst].Add((src, prob));
            }

            return dict;
        }
    }