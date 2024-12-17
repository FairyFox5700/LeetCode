public class Solution {

    public string LongestDiverseString(int a, int b, int c)
    {
        var pq = new PriorityQueue<(string, int), int>();
        if(a>0)
            pq.Enqueue(("a", a), -a);
        if(b>0)
            pq.Enqueue(("b", b), -b);
        if(c> 0)
            pq.Enqueue(("c", c), -c);

        var sb = new StringBuilder();
        while (pq.Count > 0)
        {
            var (item, count) = pq.Dequeue();
            
            if(sb.Length > 1 
                && sb[sb.Length -1].ToString() == item 
                && sb[sb.Length -2].ToString() == item )
            {
                if(pq.Count == 0)
                    break;

                var (tempItem, tempCount) = (item, count);
                (item, count) = pq.Dequeue();
                sb.Append(item);
                if (count-1 > 0)
                {
                    pq.Enqueue((item, (count-1)), -(count-1));
                }

                pq.Enqueue((tempItem, tempCount), -tempCount);
            }
            else
            {
                    sb.Append(item);
                    if (count-1 > 0)
                    {
                        pq.Enqueue((item, (count-1)), -(count-1));
                    }
            }
        }


        return sb.ToString();
    }
}