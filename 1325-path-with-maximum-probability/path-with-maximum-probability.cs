public class Solution
{
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
    {
        // Bellman-Ford algorithm
        var distances = new double[n];
        distances[start_node] = 1;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < edges.Length; j++) // Fixed the loop index
            {
                var edge = edges[j];
                var u = edge[0];
                var v = edge[1];
                var prob = succProb[j];
                var tempDistanceU = distances[u] * prob;
                var tempDistanceV = distances[v] * prob;

                if (distances[v] < tempDistanceU)
                {
                    distances[v] = tempDistanceU;
                }

                if (distances[u] < tempDistanceV)
                {
                    distances[u] = tempDistanceV;
                }
            }
        }

        return distances[end_node];
    }
}
