public class Solution {
    public int MinMoves(int target, int maxDoubles) {
        if(target == 1)
            return 0;
        if(maxDoubles == 0)
            return target -1; // only one way to reach target, to descrease each time
        if(target%2==0 && maxDoubles >0)
         return 1+ MinMoves(target/2, maxDoubles-1);
        return 1+ MinMoves(target-1, maxDoubles);
    }
}

/* BFS
    public class Solution
    {
        public int MinMoves(int target, int maxDoubles)
        {
            var queue = new Queue<(int, int)>();
            queue.Enqueue((target, 0));
            var visited = new HashSet<int>();
        
            while (queue.Count > 0)
            {
         
                    var (el, steps) = queue.Dequeue();
                    Console.WriteLine(el);
                    if (el == 1)
                    {
                        return steps;
                    }

                    if (maxDoubles > 0 && el%2 == 0)
                    {
                        if (!visited.Contains(el/2))
                        {
                            queue.Enqueue((el/2, steps+1));
                            visited.Add(el/2);
                            maxDoubles--;
                        }
                      
                    }
                
                    if (!visited.Contains(el - 1))
                    {
                        queue.Enqueue((el - 1, steps +1));
                        visited.Add(el - 1);
                    }
            }

            return -1;
        }
    }

    */