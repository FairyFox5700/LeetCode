    public class Solution
    {
        public int[] FindRedundantConnection(int[][] edges)
        {
            Console.WriteLine(edges.Length+1);
            var uf = new UnionFind(edges.Length+1);
            var result = new int[2];
            for (int i = 0; i < edges.Length; i++)
            {
                var v1 = edges[i][0];
                var v2 = edges[i][1];
                if (uf.Union(v1, v2) == 0)
                {
                    result.SetValue(v1, 0);
                    result.SetValue(v2, 1);
                }

            }

            return result;
        }
    


    public class UnionFind
    {
        private int _size;
        private int[] _parent;
        private int[] _rank;
        public UnionFind(int size)
        {
            _size = size;
            _parent = new int[_size];
            _rank = new int[_size];

            for (int i = 0; i < _size; i++)
            {
                _parent[i] = i;
            }
        }
        public int Union(int v1, int v2)
        {
            var root1 = Find(v1);
            var root2 = Find(v2);

            if (root1 != root2)
            {
                if (_rank[root1] > _rank[root2])
                {
                    _parent[root2] = root1;
                    _rank[root1] += _rank[root2];
                }
                else
                {
                    _parent[root1] = root2;
                    _rank[root2] += _rank[root1];
                }

                return 1;
            }

            return 0;
        }

        public int Find(int v)
        {
            if (_parent[v] != v)
            {
                return Find(_parent[v]);
            }

            return _parent[v];
        }
    }
}