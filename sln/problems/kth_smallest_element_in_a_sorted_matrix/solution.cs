    public class Solution
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var pq = new PriorityQueue<(int, int), int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            //max heap

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int i = 0; i < matrix[0].Length; i++)
                {
                
                    
                        pq.Enqueue((r, i), matrix[r][i]);
                            if(pq.Count>k)
                    {
                        pq.Dequeue();
                    }
                    
                    
                }
            }

        
            var item = pq.Dequeue();
            return matrix[item.Item1][item.Item2];
        }
    }