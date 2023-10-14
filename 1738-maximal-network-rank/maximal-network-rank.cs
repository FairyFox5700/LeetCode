 public class Solution
 {
     public int MaximalNetworkRank(int n, int[][] roads)
     {
            // 1: 1, 3:1,2:1, 3:1
            // 0: 2, 1:3 , 2: 1, 3:1, 3:0
            var hashSet = new HashSet<(int, int)>();
            var rank = new int[n];
            for (int i = 0; i < roads.Length; i++)
            {
                var v1 = roads[i][0];
                var v2 = roads[i][1];
                rank[v1]++;
                rank[v2]++;
                hashSet.Add((v1, v2));
            }
            var max = int.MinValue;
            for (int i = 0; i < rank.Length; i++)
            {
                for (int j = i+1; j < rank.Length; j++)
                {
                    var sum = rank[j] + rank[i];
                    Console.WriteLine(sum);
                    if (hashSet.Contains((i, j)) || hashSet.Contains((j,i)))
                    {
                        sum-=1;
                    }
                    max = Math.Max(max, sum);
                }
            }

            return max== int.MinValue?0:max;
     }
 }
