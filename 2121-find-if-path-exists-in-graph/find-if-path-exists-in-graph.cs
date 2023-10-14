 public class Solution
 {
     public bool ValidPath(int n, int[][] edges, int source, int destination)
     {
         var visited = new HashSet<int>();
         var uf = new UnionFind(n);

         for (int i = 0; i < edges.Length; i++)
         {
             var v1 = edges[i][0];
             var v2 = edges[i][1];
             uf.Connect(edges[i][0], edges[i][1]);
         }

         return uf.Connect(source, destination);

     }

     public class UnionFind
     {
         private int[] _parent;
         private int[] _rank;

         public UnionFind(int n)
         {
             _parent = new int[n];
             _rank = new int[n];
                for (int i = 0; i < n; i++)
                {
                    _parent[i] = i;
                    _rank[i] =0;
                }
         }

         public int FindParent(int v)
         {
             // recursively find parent
             while (v != _parent[v])
             {
                 v = _parent[v];
             }

             Console.WriteLine(v);
             return _parent[v];
         }

         public bool Connect(int v1, int v2)
         {
                var parent1 = FindParent(v1);
                var parent2 = FindParent(v2);

                if (parent1 != parent2)
                {
                    if (_rank[parent1] > _rank[parent2])
                    {
                        _parent[parent2] = parent1;
                        _rank[parent1]++;
                    }
                    else
                    {
                        _parent[parent1] = parent2;
                        _rank[parent2]++;
                    }
                }
                else
                {
                    return true;
                }

                return false;
         }
     }
 }