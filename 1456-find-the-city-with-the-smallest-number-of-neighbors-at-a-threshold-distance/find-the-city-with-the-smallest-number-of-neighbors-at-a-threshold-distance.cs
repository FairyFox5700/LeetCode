public class Solution
{
    public int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        // Floyd-Warshall to calculate all-pairs shortest distances
        var distances = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                distances[i, j] = i == j ? 0 : int.MaxValue;
            }
        }

        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];
            var weight = edge[2];
            distances[u, v] = distances[v, u] = weight; // Undirected graph
        }

        for (int k = 0; k < n; k++)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (distances[i, k] != int.MaxValue && distances[k, j] != int.MaxValue)
                    {
                        distances[i, j] = Math.Min(distances[i, j], distances[i, k] + distances[k, j]);
                    }
                }
            }
        }

        int minCityCount = int.MaxValue;
        int city = -1;

        for (var i = 0; i < n; i++)
        {
            var cityCount = 0;
            for (var j = 0; j < n; j++)
            {
                if (i != j && distances[i, j] <= distanceThreshold)
                {
                    cityCount++;
                }
            }

            if (cityCount <= minCityCount)
            {
                city = i;
                minCityCount = cityCount;
            }
        }

        return city;
    }
}
