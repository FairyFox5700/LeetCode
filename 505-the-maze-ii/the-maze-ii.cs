public class Solution {
    public int ShortestDistance(int[][] maze, int[] start, int[] destination) {
         int[][] dist = new int[maze.Length][];

                for (int i = 0; i < dist.Count(); i++)
                {
                    dist[i] = new int[maze[0].Count()];
                    for (int j = 0; j < maze[0].Count(); j++)
                    {

                        dist[i][j] = int.MaxValue;
                    }
                }

                var directions = new List<(int, int)>()
                {
                    (0,1), //down
                     (-1, 0), //left
                    (1, 0), //right
                     (0,-1)  //up
                };
                
                var queue = new Queue<(int, int)>();
                queue.Enqueue((start[0], start[1]));
                 int rows = maze.Length;
                int cols = maze[0].Length;

                var destR = destination[0];
                var destC = destination[1];

                dist[start[0]][ start[1]] = 0; // starting point

                while (queue.Count > 0)
                {
                    var (currentR, currentC) = queue.Dequeue();
                   
                    // 4 directions
                    foreach (var direction in directions)
                    {
                        int newR = currentR + direction.Item1;
                        int newC = currentC + direction.Item2;
                        var counter = 0;
                        while ((newR >= 0 && newR < rows) && (newC >= 0 && newC < cols)
                        && maze[newR][newC] != 1)
                        {
                            ++counter;
                            newR += direction.Item1;
                            newC += direction.Item2;
                        }

                        Console.WriteLine(" row:" + newR + " col:" + newC);
                        Console.WriteLine(counter);
                      

                        if (dist[currentR][currentC] + counter < dist[newR-direction.Item1][newC-direction.Item2])
                        {
                            dist[newR-direction.Item1][newC-direction.Item2] = dist[currentR][currentC] + counter;
                            queue.Enqueue((newR-direction.Item1, newC-direction.Item2));
                        }
                  
                    }
                }

                return dist[destination[0]][destination[1]] == int.MaxValue ? -1 : dist[destination[0]][destination[1]];
            
    }
}