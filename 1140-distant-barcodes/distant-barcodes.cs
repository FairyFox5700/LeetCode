public class Solution {
    public int[] RearrangeBarcodes(int[] barcodes) {
        
        //barcodes = [1,1,1,2,2,2]
        //[2,1,2,1,2,1]
        // 1,1,1
        // dict = [1: 3, 2: 3]
        // pg (1, 3), (2, 3)
  
        var dict = new Dictionary<int,int>();

        foreach(var item in barcodes)
        {
            if( !dict.ContainsKey(item))
            {
                dict.Add(item, 0);
            }

            dict[item]++;
        }

        var pq = new PriorityQueue<(int,int),int>();
        foreach(var (key, val ) in dict)
        {
           
            pq.Enqueue((key,val), -val);
        }

        // 1: 4, 2; 2 , 3: 2
       
        var result = new List<int>();
 
        while( pq.Count > 1 )
        {
            var (current, priority) = pq.Dequeue();
            

            result.Add(current);

            var (nextElement,nextElementPriority) = pq.Dequeue();
            result.Add(nextElement);

            if(priority-1 >0)
                pq.Enqueue((current, priority-1), -(priority-1));
            if(nextElementPriority-1>0)
                pq.Enqueue((nextElement, nextElementPriority-1), -(nextElementPriority-1));
        }

        if(pq.Count > 0) // elements left
        {
            result.Add(pq.Dequeue().Item1);
        }

        return result.ToArray();
    }
}