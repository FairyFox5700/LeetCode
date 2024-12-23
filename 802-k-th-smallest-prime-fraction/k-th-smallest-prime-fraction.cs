public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        
        var pq = new PriorityQueue<(int,int), double>();
        var count = 0;
        var endIndex = arr.Count() -1;
        var leftIndex = 0;
        // init pq
        var end = arr[endIndex];
        for( int i = 0; i< arr.Count()-1; i++)
        {
            pq.Enqueue((i, endIndex), (double)arr[i]/ end);
        }

       


        
        for( int i = 0; i< k-1; i++)
        {
            var (i1, i2) = pq.Dequeue();

            if(i1 < i2-1)
            {
                pq.Enqueue((i1,i2-1), (double)arr[i1]/ arr[i2-1]);
            }
        }

        if(pq.Count > 0)
        {
            var (i1, i2) = pq.Dequeue();

            return new int[]
            {
                arr[i1],
                arr[i2]
            };
        }

        return new int[0];
    }

}