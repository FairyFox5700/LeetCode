public class Solution {
 public int LastStoneWeight(int[] stones)
        {
            var q = new PriorityQueue<int, int>();
            //stone has weight
            // we store weight as comparison
            // on each step we need to select largest
            //Represents a collection of items that have a value and a priority. On dequeue, the item with the lowest priority value is removed.
            //then we assign negative value for weight -> to be selected in priority queue first
            foreach (var stone in stones)
            {
                q.Enqueue(stone, -stone);
            }

            while (q.Count > 1)
            {
                int dif = q.Dequeue() - q.Dequeue();
                if (dif != 0) q.Enqueue(dif, -dif);
            }

            return (q.Count == 0) ? 0 : q.Peek();
        }
   
}