      public class Solution
      {
          public int MinimumEffortPath(int[][] heights)
          {
             
              var minDistanceHeights = new int[heights.Count(), heights[0].Count()];

              for (int i = 0; i < heights.Count(); i++)
              {
                  for (int j = 0; j < heights[0].Count(); j++)
                  {
                      minDistanceHeights[i, j] = int.MaxValue;
                  }
              }

              var visited = new bool[heights.Count(), heights[0].Count()];

              var pq = new PriorityQueue<(int, int, int), int>();
              pq.Enqueue((0, 0, 0), 0);

              var dirrections = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };

              while (pq.Count > 0)
              {
                  var (x, y, distance) = pq.Dequeue();
                  minDistanceHeights[x, y] = distance;
                  
                  if(x == heights.Count() - 1 && y == heights[0].Count() - 1)
                  {
                      return distance;
                  }

                  for (int i = 0; i < dirrections.GetLength(0); i++)
                  {
                  
                      var newX = x + dirrections[i, 0];
                      var newY = y + dirrections[i, 1];
                   

                      if (newX < 0 || newX >= heights.Count() || newY < 0 || newY >= heights[0].Count())
                      {
                          continue;
                      }

                      if (visited[newX, newY])
                      {
                          continue;
                      }
                      visited[x, y] = true;
                      var newDistance = Math.Max( distance, Math.Abs(heights[x][y] - heights[newX][newY])); // always take max effort
                      pq.Enqueue((newX, newY, newDistance), newDistance);
                  }

              }

              return -1;
          }
      }