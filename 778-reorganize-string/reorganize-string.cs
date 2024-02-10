public class Solution
{
    public string ReorganizeString(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var ch in s)
        {
            if (!dict.ContainsKey(ch))
                dict.Add(ch, 0);
            dict[ch]++;
        }

        var pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        // mahheap
        var sb = new StringBuilder();

        foreach (var (key, val) in dict)
        {
            // not possible to equally place the letters if it is larger then half +1 ( max char we can place is half /2 + 1)
            if (val> Math.Ceiling((decimal)s.Length / 2))
                return string.Empty;
            pq.Enqueue(key,  val); // max heap
        }

        var previos = '0';
        while (pq.Count > 0)
        {
            var temp = pq.Dequeue();
            var pop = ' ';
            if (temp == previos)
            {
                var other = pq.Dequeue();
                pop = other;
                pq.Enqueue(previos, dict[previos]);
            }
            else
            {
                pop = temp;
            }

            sb.Append(pop.ToString());
            dict[pop]--;
            previos = pop;
            if(dict[pop] > 0)
             pq.Enqueue(pop, dict[pop]);
        }

        return sb.Length == s.Length ? sb.ToString() : String.Empty;
    }
}