 public class Solution
 {
     public IList<IList<int>> AllPathsSourceTarget(int[][] graph)
     {
         var result = new List<IList<int>>();
         var current = new List<int>();
         var target = graph.Length - 1;
         if (graph.Length == 0)
         {
             return result;
         }
         current.Add(0);
         FindPathesWithBacktracing(graph, result, 0, current);
         return result;
     }

     private void FindPathesWithBacktracing(int[][] graph, List<IList<int>> result, int currentNode, List<int> current)
     {
         // target is the last node
         // check if reached the target
         if (currentNode == graph.Length - 1)
         {
             result.Add(new List<int>(current));
             return;
         }
         // simple dfs
         // graph[0] -- list of neighbors
         for (int i = 0; i < graph[currentNode].Length; i++)
         {
             current.Add(graph[currentNode][i]);
             FindPathesWithBacktracing(graph, result, graph[currentNode][i], current);
             current.RemoveAt(current.Count - 1);
         }
     }
 }