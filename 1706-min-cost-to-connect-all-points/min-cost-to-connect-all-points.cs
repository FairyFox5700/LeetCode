       public class Solution
    {

        //optimized prim

        private record Edge(int Point1, int Point2, int Weight);

        public int MinCostConnectPoints(int[][] points)
        {
            var listEdge = new List<Edge>();
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    listEdge.Add(new Edge(i, j, ManhattanDistance(points[i], points[j])));
                }
            }

            listEdge = listEdge.OrderBy(e => e.Weight).ToList();
            var uf = new UnionFind(points.Length);
            var cost = 0;
            var usedNodes = 0;
            foreach (var edge in listEdge)
            {
                if (!uf.Union(edge.Point1, edge.Point2))
                {
                    usedNodes++;
                    cost += edge.Weight;
                }
            }

            return cost;
        }


        public class UnionFind
        {
            private int[] _parents;
            private int[] _rank;

            public UnionFind(int size)
            {
                _parents = new int[size];
                _rank = new int[size];

                for (int i = 0; i < size; i++)
                {
                    _parents[i] = i;
                }
            }


            private int FindParent(int v)
            {
                while (v != _parents[v])
                {
                    v = _parents[v];
                }

                return v;
            }

            public bool Union(int v1, int v2)
            {
                var p1 = FindParent(v1);
                var p2 = FindParent(v2);

                if (p1 != p2)
                {
                    if (_rank[p1] > _rank[p2])
                    {
                        _parents[p2] = p1;
                        _rank[p1]++;
                    }
                    else
                    {
                        _parents[p1] = p2;
                        _rank[p2]++;
                    }
                }
                else
                {
                    return true;
                }

                return false;



            }
        }

        private int ManhattanDistance(int[] point1, int[] point2)
        {
            return Math.Abs(point1[0] - point2[0]) + Math.Abs(point1[1] - point2[1]);
        }
    }
 /* public class Solution
    {
        //optimized prim
        private record Node(int node, int distance);
        public int MinCostConnectPoints(int[][] points)
        {
            // prims algorithm
            // 1. pick a random node
            // 2. pick the minimum edge from the node
            // 3. add the node to the visited set
            // 4. repeat 2 and 3 until all nodes are visited
            // 5. return the cost
            var graph = BuildTree(points);
            return PrimsAlgor(graph);
        }

       private int PrimsAlgor(Dictionary<int, List<Node>> graph)
    {
        var visited = new HashSet<int>();
        var minArray = new int[graph.Count+1];
        for (int i = 0; i < graph.Count; i++)
        {
            minArray[i] = int.MaxValue;
        }

        minArray[0] = 0;
        var cost = 0;
        
        while (visited.Count < graph.Count)
        {
            var currentMinCost = int.MaxValue;
            var currentMinWeightNode = -1;

            // Finding the lowest weight node among unvisited nodes.
            for (int i = 0; i < graph.Count; i++)
            {
                if (!visited.Contains(i) && minArray[i] < currentMinCost)
                {
                    currentMinCost = minArray[i];
                    currentMinWeightNode = i;
                }
            }

            cost += currentMinCost;
            visited.Add(currentMinWeightNode);

            foreach (var neighbour in graph[currentMinWeightNode])
            {
                if (!visited.Contains(neighbour.node) && neighbour.distance < minArray[neighbour.node])
                {
                    minArray[neighbour.node] = neighbour.distance;
                }
            }
        }

        return cost;
    }

        private Dictionary<int, List<Node>> BuildTree(int[][] points)
        {
            var dictionary = new Dictionary<int, List<Node>>();
            for (int r = 0; r < points.Length; r++)
            {
                for (int c = r + 1; c < points.Length; c++)
                {
                    var distance = ManhattanDistance(points[r], points[c]);
                    if (!dictionary.ContainsKey(r))
                    {
                        dictionary.Add(r, new List<Node>());
                    }
                    dictionary[r].Add(new Node(c, distance));
                    if (!dictionary.ContainsKey(c))
                    {
                        dictionary.Add(c, new List<Node>());
                    }
                    dictionary[c].Add(new Node(r, distance));
                }
            }

            return dictionary;
        }
        private int ManhattanDistance(int[] point1, int[] point2)
        {
            return Math.Abs(point1[0] - point2[0]) + Math.Abs(point1[1] - point2[1]);
        }
    }
*/

/*    public class Solution
        {
            private record Node(int node, int distance);
            public int MinCostConnectPoints(int[][] points)
            {
                // prims algorithm
                // 1. pick a random node
                // 2. pick the minimum edge from the node
                // 3. add the node to the visited set
                // 4. repeat 2 and 3 until all nodes are visited
                // 5. return the cost
                var graph = BuildTree(points);
                return PrimsAlgor(graph);
            }

            private int PrimsAlgor(Dictionary<int, List<Node>> graph)
            {
                var visited = new HashSet<int>();
                var queue = new PriorityQueue<int, int>();
                queue.Enqueue(0, 0);
              
                var cost = 0;
                while (queue.Count > 0)
                {
                    queue.TryDequeue(out int current, out int priority);
                    if (visited.Contains(current))
                    {
                        continue;
                    }

                    if(!graph.ContainsKey(current))
                    {
                        return cost;
                    }

                    cost += priority;
                    visited.Add(current);
                    
                    foreach (var neighbour in graph[current])
                    {
                        if (!visited.Contains(neighbour.node))
                        {
                            queue.Enqueue(neighbour.node, neighbour.distance);
                        }
                    }
                }

                return cost;
            }


            private Dictionary<int, List<Node>> BuildTree(int[][] points)
            {
                var dictionary = new Dictionary<int, List<Node>>();
                for (int r = 0; r < points.Length; r++)
                {
                    for (int c = r+1; c < points.Length; c++)
                    {
                        var distance = ManhattanDistance(points[r], points[c]);
                        if (!dictionary.ContainsKey(r))
                        {
                            dictionary.Add(r, new List<Node>());
                        }
                        dictionary[r].Add(new Node(c, distance));
                        if (!dictionary.ContainsKey(c))
                        {
                             dictionary.Add(c, new List<Node>());
                        }
                        dictionary[c].Add(new Node(r, distance));
                    }
                }

                return dictionary;
            }
            private int ManhattanDistance(int[] point1, int[] point2)
            {
                return Math.Abs(point1[0] - point2[0]) + Math.Abs(point1[1] - point2[1]);
            }
        }

        */