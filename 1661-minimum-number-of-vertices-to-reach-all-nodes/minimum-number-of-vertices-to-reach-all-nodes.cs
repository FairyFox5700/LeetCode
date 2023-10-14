 public class Solution
 {
     public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
     {
        var incomindEdges = new int[n];
        for (int i = 0; i < edges.Count; i++)
        {
            incomindEdges[edges[i][1]]++;
        }


        var result = new List<int>();
        for (int i = 0; i < incomindEdges.Length; i++)
        {
            if (incomindEdges[i] == 0)
            {
                 result.Add(i);
            }
        }

        return result;
     }
 }