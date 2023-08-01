    public class Solution
    {

        public class UnionFind
        {
            public int _size;
            public int[] _parent;
            public int[] _rank;
            public UnionFind(int size)
            {
                _size = size;
                _parent = new int[size+1];
                _rank = new int[_size];
                for (int i = 0; i < size; i++)
                {
                    _parent[i] = i;
                    _rank[i] =1;
                }
            }

            public int Find(int node)
            {
                if(node == _parent[node])
                {
                    return node;
                }
                return Find(_parent[node]);
            }

            public bool Union(int node1, int node2)
            {
                var parent1 = Find(node1);
                var parent2 = Find(node2);
                Console.WriteLine(parent1);
                Console.WriteLine(parent2);
                if (parent1 != parent2)
                {
                    if (_rank[parent1] > _rank[parent2])
                    {
                        _parent[parent2] = parent1;
                        _rank[parent1]+= _rank[parent2];
                    }
                    else
                    {
                        _parent[parent1] = parent2;
                        _rank[parent2]+= _rank[parent1];
                    }
                    return true;
                }

                return false;
            }
        }
        public int FindCircleNum(int[][] isConnected)
        {
            //BuildGraph(isConnected, out Dictionary<int,List<int>> graph);

            int num = 0;
            var visited = new HashSet<int>();
            var unionFind = new UnionFind(isConnected.Length);
            for (int i = 0; i < isConnected.Length; i++)
            {
                for (int j = 0; j < isConnected[0].Length; j++)
                {
                    if (isConnected[i][j] == 1)
                    {
                        if(unionFind.Union(i, j))
                        {
                            num++;
                        }
                    }
                }
            }

           return isConnected.Length - num;
        }

    }
