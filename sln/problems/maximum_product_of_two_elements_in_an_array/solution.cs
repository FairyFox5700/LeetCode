    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            // 1. sort and access last 2 elements
            // 2. use max heap i.e. priority queue and acess top 2 elements. */

            //Descending Sort, Integer
            var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            /*(x, y) => y - x: This is a lambda expression that defines the comparison logic. In this case, it's a descending order comparison. It means that when two integers x and y are compared, if y - x is positive, it means that y has higher priority (should come before) x. This results in a max heap behavior where the largest elements have the highest priority.*/

            foreach (var num in nums)
            {
                queue.Enqueue(num, num);
            }
            
            var first = queue.Dequeue();
            var second = queue.Dequeue();
            return (first - 1) * (second - 1);

        }
    }