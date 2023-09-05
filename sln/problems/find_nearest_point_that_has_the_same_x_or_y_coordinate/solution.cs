    public class Solution
    {
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var minDistance = int.MaxValue;
            var index = -1;
            for (int i = 0; i < points.Length; i++)
            {
                var x1 = points[i][0];
                var y1 = points[i][1];
                if (x == x1 || y == y1)
                {
                    var distance = Distance(x, x1, y, y1);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        index = i;
                    }

                }
            }

            return index;
        }

        private int Distance(int x, int x1, int y, int y1)
        {
            return Math.Abs(x - x1) + Math.Abs(y - y1);
        }
    }