    public class Solution
    {
        public int MinimumOperations(int[] nums, int start, int goal)
        {
            // BFS to reach the goal
            /*x + nums[i]
            x - nums[i]
            x ^ nums[i] (bitwise-XOR)*/
            //nums = [2,4,12]
            var queue = new Queue<(int,int)>();
            var visted = new HashSet<int>();
            queue.Enqueue((start, 0));
            while (queue.Count > 0)
            {
                for(int i = 0; i< queue.Count; i++)
                {
                var (item, result) = queue.Dequeue();
                foreach (var num in nums)
                {
                    var plus = item + num;
                    var minus = item - num;
                    var xor = item ^ num;
                    
                    if (plus == goal || minus == goal || xor == goal)
                    {
                        return result + 1;
                    }
                    
                    if(plus >=0 && plus <=1000 && !visted.Contains(plus))
                    {
                        queue.Enqueue((plus, result + 1));
                        visted.Add(plus);
                    }
                    if(minus >=0 &&  minus <=1000 && !visted.Contains(minus))
                    {
                        queue.Enqueue((minus, result + 1));
                        visted.Add(minus);
                    }
                    if(xor >=0&& xor <=1000 && !visted.Contains(xor))
                    {
                        queue.Enqueue((xor, result + 1));
                        visted.Add(xor);
                    } 
                    }
                 }

            }
            return -1;
        }
    }